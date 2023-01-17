using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Nefarius.ViGEm.Client;
using HidLibrary;
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

        private static DeviceList _deviceAssociations;
        private static List<Thread> _threads = new List<Thread>();
        private static List<GMKDevice> _devices = new List<GMKDevice>();
        private static IEnumerable<HidDevice> _hidDevices;
        private static TextBox _console;
        private static bool _run;

        public static DeviceList DeviceAssociations { get { return _deviceAssociations; } }
        public static Thread[] Threads { get { return _threads.ToArray(); } }
        public static GMKDevice[] Devices { get { return _devices.ToArray(); } }

        public static void SetConsole(TextBox console)
        {
            _console = console;
        }

        private static void WriteLine(string text)
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

        public static void Stop()
        {
            foreach(GMKDevice device in _devices)
            {
                device.Stop();
            }

            foreach(Thread thread in _threads)
            {
                thread.Join();
            }

            _run = false;
        }


        public static void Loop()
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
                while(HidDevices.Enumerate().Count() == _hidDevices.Count())
                {
                    Thread.Sleep(500);
                }

                Thread.Sleep(1000);
            }
        }

        public static string GetSerialNumber(HidDevice device)
        {
            device.ReadSerialNumber(out byte[] serialNumber);
            return Encoding.Unicode.GetString(serialNumber).TrimEnd('\0');
        }

        private static List<GMKDevice> ScanAndStartDevices()
        {
            List<GMKDevice> newDevices = new List<GMKDevice>();

            if (_deviceAssociations == null)
            {
                _deviceAssociations = DeviceList.Load();
            }

            _threads.RemoveAll(thread => !thread.IsAlive);

            _devices.RemoveAll(device => !device.UsbDevice.IsOpen);

            _hidDevices = HidDevices.Enumerate();

            foreach(HidDevice device in _hidDevices)
            {
                // Check VID and PID
                bool gmkDeviceFound = device.Attributes.VendorId == GMK_VID && 
                    (device.Attributes.ProductId == JOYSTICK_PID || device.Attributes.ProductId == CONTROLLER_PID);
                if (!gmkDeviceFound)
                    continue;

                // Get serialNumber
                string serialNumber = GetSerialNumber(device);

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

                if (device.Attributes.ProductId == JOYSTICK_PID)
                {
                    GMKJoystick joystick = new GMKJoystick(device, config, _console);
                    newDevices.Add(joystick);
                }

                if(device.Attributes.ProductId == CONTROLLER_PID)
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
            }

            _devices.AddRange(newDevices);
            return newDevices;
        }

        public static void Run(object device)
        {
            GMKDevice gmkDevice = (GMKDevice)device;
            gmkDevice.Run();
        }
    }
}
