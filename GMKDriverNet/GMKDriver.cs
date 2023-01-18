using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Nefarius.ViGEm.Client;
using LibUsbDotNet.LibUsb;
using LibUsbDotNet.Main;
using LibUsbDotNet;
using Nefarius.ViGEm.Client.Targets;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using System.IO.Ports;

namespace GMKDriverNET
{
    public class GMKDriver
    {
        private const int GMK_VID = 0x483;
        private const int JOYSTICK_PID = 0x5750;
        private const int CONTROLLER_PID = 0x5740;

        private DeviceList _deviceAssociations;
        private List<Thread> _threads = new List<Thread>();
        private List<GMKDevice> _devices = new List<GMKDevice>();
        private UsbDeviceCollection _hidDevices;
        private UsbContext _context;
        private TextBox _console;
        private bool _run;

        public DeviceList DeviceAssociations { get { return _deviceAssociations; } }
        public Thread[] Threads { get { return _threads.ToArray(); } }
        public GMKDevice[] Devices { get { return _devices.ToArray(); } }

        public void SetConsole(TextBox console)
        {
            _console = console;
        }

        private void WriteLine(string text)
        {
            List<string> consoleOutputList = new List<string>();
            if (_console != null)
            {
                consoleOutputList = new List<string>();
                consoleOutputList.AddRange(_console.Lines);
                consoleOutputList.Add(text);
                _console.Invoke((MethodInvoker)delegate
                {
                    _console.Lines = consoleOutputList.ToArray();
                    _console.Refresh();
                });
            }
            else
            {
                Console.WriteLine(text);
            }
        }

        public void Stop()
        {
            foreach(GMKDevice device in _devices)
            {
                device.Stop();
            }

            foreach(Thread thread in _threads)
            {
                thread.Join();
            }

            _threads.RemoveAll(thread => !thread.IsAlive);

            _run = false;
        }


        public void Loop()
        {
            using (_context = new UsbContext())
            {
                WriteLine("Scanning devices...");
                List<GMKDevice> newDevices;

                _run = true;

                while (_run)
                {
                    // Scan for devices and start their respective driver
                    newDevices = ScanAndStartDevices();

                    // Inform user device was connected
                    foreach (GMKDevice device in newDevices)
                    {
                        WriteLine("GMK: " + device.Type + " found. SN: " + device.SerialNumber);
                    }

                    // Wait for device enumeration by polling
                    while (_devices.Count() == _hidDevices.Count())
                    {
                        Thread.Sleep(100);
                    }

                    Thread.Sleep(1000);
                }
                _hidDevices.Dispose();
            }
            _context.Dispose();
            _context = null;
            _hidDevices = null;
        }

        public static string GetSerialNumber(IUsbDevice device)
        {
            string serialNumber;
            if (!device.IsOpen)
            {
                if(!device.TryOpen())
                {
                    return "NA";
                }
            }

            serialNumber = device.Info.SerialNumber;
            
            device.Close();
            
            return serialNumber;
        }

        private List<GMKDevice> ScanAndStartDevices()
        {
            List<GMKDevice> newDevices = new List<GMKDevice>();

            if (_deviceAssociations == null)
            {
                _deviceAssociations = DeviceList.Load();
            }

            _threads.RemoveAll(thread => !thread.IsAlive);

            _devices.RemoveAll(device => !device.IsRunning);

            _hidDevices = _context.List();

            foreach(IUsbDevice device in _hidDevices)
            {
                // Check VID and PID
                bool gmkDeviceFound = device.VendorId == GMK_VID && 
                    (device.ProductId == JOYSTICK_PID || device.ProductId == CONTROLLER_PID);
                if (!gmkDeviceFound)
                    continue;

                // Get serialNumber
                string serialNumber = GetSerialNumber(device);

                if(serialNumber == "NA")
                {
                    continue;
                }

                // Check if device already has a driver attached
                gmkDeviceFound = false;
                foreach(GMKDevice gmkDevice in _devices)
                {
                    if (gmkDevice.SerialNumber.Equals(serialNumber))
                    {
                        gmkDeviceFound = true;
                        break;
                    }
                }

                // If device is already being used, close and continue for loop
                if (gmkDeviceFound)
                {
                    continue;
                }

                DeviceConfigAssociations configAssociation = _deviceAssociations.LookupSerialNumber(serialNumber);

                DeviceConfig config;

                if (configAssociation == null)
                {
                    DeviceAssociations.AddNewDevice(serialNumber);
                    config = DeviceConfig.Default;
                    DeviceAssociations.AddConfiguration(serialNumber, config, true);
                }
                else
                {
                    config = DeviceConfig.FromFile(configAssociation.defaultConfigFile);
                }

                if (device.ProductId == JOYSTICK_PID)
                {
                    GMKJoystick joystick = new GMKJoystick(device, config, _console);
                    newDevices.Add(joystick);
                }

                if(device.ProductId == CONTROLLER_PID)
                {
                    GMKController controller = new GMKController(device, config, _console);
                    _devices.Add(controller);
                }
            }

            foreach(GMKDevice device in newDevices)
            {
                Thread t = new Thread(new ParameterizedThreadStart(Run));
                _threads.Add(t);
                t.Start(device);
                _devices.Add(device);
            }

            return newDevices;
        }

        public static void Run(object device)
        {
            GMKDevice gmkDevice = (GMKDevice)device;
            gmkDevice.Run();
        }
    }
}
