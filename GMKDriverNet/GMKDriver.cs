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
using System.Reflection;
using System.Diagnostics;

namespace GMKDriverNET
{
    public class GMKDriver
    {
        private static string Version { get { return "v1.7"; } }

        private const int GMK_VID = 0x483;
        private const int JOYSTICK_PID = 0x5750;
        private const int CONTROLLER_PID = 0x5740;

        private static DeviceList _deviceAssociations;
        private static List<Thread> _threads = new List<Thread>();
        private static List<GMKDevice> _devices = new List<GMKDevice>();
        private static TextBox _console;
        private static bool _run;

        private static string _oldWindow;

        public static DeviceList DeviceAssociations { get { return _deviceAssociations; } }
        public static Thread[] Threads { get { return _threads.ToArray(); } }
        public static GMKDevice[] Devices { get { return _devices.ToArray(); } }

        public static void MakeStartupApp()
        {
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            key.SetValue("GMK Driver", Application.ExecutablePath);
        }
        
        public static bool IsStartupApp()
        {
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            return key.GetValue("GMK Driver") != null;
        }

        public static void RemoveStartupApp()
        {
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            key.DeleteValue("GMK Driver", false);
        }

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

        public static bool CheckViGEmInstalled()
        {
            try
            {
                ViGEmClient viGEmClient = new ViGEmClient();
                return true;
            }
            catch(Exception ex)
            {
                return false;
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

            _devices.RemoveAll(device => !device.IsRunning);

            _threads.RemoveAll(thread => !thread.IsAlive);

            _run = false;
        }

        public static void Loop()
        {
            _oldWindow = ActiveWindowTitle();

            using (UsbContext context = new UsbContext())
            {
                WriteLine("GMK Driver Version: " + Version);

                WriteLine("Scanning devices...");
                List<GMKDevice> newDevices = new List<GMKDevice>();

                _run = true;

                UsbDeviceCollection currentDevices;

                while (_run)
                {
                    // Scan for devices and start their respective driver
                    newDevices = ScanAndStartDevices(context);

                    // Inform user device was connected
                    foreach (GMKDevice device in newDevices)
                    {
                        WriteLine("GMK: " + device.Type + " found. SN: " + device.SerialNumber);
                    }


                    int beginNumberOfDevices;
                    using (UsbDeviceCollection usbDevices = context.List())
                    {
                        beginNumberOfDevices = usbDevices.Count;
                    }

                    int afterNumberOfDevices = beginNumberOfDevices;

                    // Wait for device enumeration by polling
                    while (beginNumberOfDevices == afterNumberOfDevices && _run)
                    {
                        using (UsbDeviceCollection usbDevices = context.List())
                        {
                            afterNumberOfDevices = usbDevices.Count;
                            Thread.Sleep(250);
                        }
                        Thread.Sleep(100);
                    }
                }
                Stop();
                newDevices.Clear();
            }
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

        private static List<GMKDevice> ScanAndStartDevices(UsbContext context)
        {
            List<GMKDevice> newDevices = new List<GMKDevice>();

            if (_deviceAssociations == null)
            {
                _deviceAssociations = DeviceList.Load();
            }

            _threads.RemoveAll(thread => !thread.IsAlive);

            _devices.RemoveAll(device => !device.IsRunning);

            using (UsbDeviceCollection usbDevices = context.List())
            {
                foreach (UsbDevice device in usbDevices)
                {
                    // Check VID and PID
                    bool gmkDeviceFound = device.VendorId == GMK_VID &&
                        (device.ProductId == JOYSTICK_PID || device.ProductId == CONTROLLER_PID);
                    if (!gmkDeviceFound)
                        continue;

                    // Get serialNumber
                    string serialNumber = GetSerialNumber(device);

                    if (serialNumber == "NA")
                    {
                        continue;
                    }

                    // Check if device already has a driver attached
                    gmkDeviceFound = false;
                    foreach (GMKDevice gmkDevice in _devices)
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
                        _deviceAssociations.AddNewDevice(serialNumber);
                        config = DeviceConfig.Default;
                        _deviceAssociations.AddConfiguration(serialNumber, config, true);
                    }
                    else
                    {
                        config = DeviceConfig.FromFile(configAssociation.defaultConfigFile);
                    }

                    if (device.ProductId == JOYSTICK_PID)
                    {
                        GMKJoystick joystick = new GMKJoystick(device.Clone() as UsbDevice, config, _console);
                        newDevices.Add(joystick);
                    }

                    if (device.ProductId == CONTROLLER_PID)
                    {
                        GMKController controller = new GMKController(device.Clone() as UsbDevice, config, _console);
                        _devices.Add(controller);
                    }
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

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        private static extern int GetWindowText(IntPtr hwnd, StringBuilder ss, int count);

        private static string ActiveWindowTitle()
        {
            //Create the variable
            const int nChar = 256;
            StringBuilder ss = new StringBuilder(nChar);

            //Run GetForeGroundWindows and get active window informations
            //assign them into handle pointer variable
            IntPtr handle = IntPtr.Zero;
            handle = GetForegroundWindow();

            if (GetWindowText(handle, ss, nChar) > 0) return ss.ToString();
            else return "";
        }

        public static void CheckActiveWindowAndChangeConfiguration()
        {
            string currentWindow = ActiveWindowTitle();
            
            if (_oldWindow == currentWindow)
                return;

            _oldWindow = currentWindow;

            foreach(GMKDevice device in _devices)
            {
                DeviceConfigAssociations deviceAssociations = _deviceAssociations.LookupSerialNumber(device.SerialNumber);

                foreach(string configFile in deviceAssociations.configFiles)
                {
                    DeviceConfig config = DeviceConfig.FromFile(configFile);
                    if(!config.gameAssociationEnabled)
                    {
                        break;
                    }
                    else
                    {
                        if(currentWindow.Contains(config.gameAssociation) && device.Config.name != config.name)
                        {
                            device.WriteLine("Auto config found for application: " + config.gameAssociation);
                            device.Config = config;
                        }
                    }
                }
            }
        }
    }
}
