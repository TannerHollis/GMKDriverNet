using LibUsbDotNet.LibUsb;
using Nefarius.ViGEm.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GMKDriverNET
{
    public class GMKDriver
    {
        public static string Version { get { return "v0.95.2"; } }

        private const int GMK_VID = 0x483;
        private const int GMK_JOYSTICK_PID = 0x5750;
        private const int GMK_CONTROLLER_PID = 0x5740;
        private static readonly int[] GMK_PIDS = { GMK_JOYSTICK_PID, GMK_CONTROLLER_PID };

        private static DeviceList _deviceList;
        private static List<Thread> _threads = new List<Thread>();
        private static List<GMKDevice> _gmkDevices = new List<GMKDevice>();
        private static TextBox _console;
        private static bool _run;
        private static string _oldWindowTitle;

        public static DeviceList DeviceList
        {
            get
            {
                return _deviceList;
            }
            set
            {
                _deviceList = value;
            }
        }
        public static Thread[] Threads { get { return _threads.ToArray(); } }
        public static GMKDevice[] GMKDevices { get { return _gmkDevices.ToArray(); } }

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

        public static void WriteLine(string text)
        {
            if (_console != null)
            {
                _console.Invoke((MethodInvoker)delegate
                {
                    _console.AppendText(text + "\r\n");
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
            catch (Exception ex)
            {
                WriteLine(ex.Message);
                return false;
            }

        }

        public static void Stop()
        {
            foreach (GMKDevice device in _gmkDevices)
            {
                device.Stop();
            }

            foreach (Thread thread in _threads)
            {
                thread.Join();
            }

            RemoveInactiveDevices();

            _run = false;
        }

        private static int GetAttachedDevicesCount(UsbContext context)
        {
            int attachedDevices;

            using (UsbDeviceCollection usbDevices = context.List())
            {
                attachedDevices = usbDevices.Count;
            }

            return attachedDevices;
        }

        public static void Loop()
        {
            _oldWindowTitle = ActiveWindowTitle();

            using (UsbContext context = new UsbContext())
            {
                List<GMKDevice> newDevices = new List<GMKDevice>();

                WriteLine(LanguageHelper.LookupPhrase("scanning"));

                _run = true;

                while (_run)
                {
                    // Scan for devices and start their respective driver
                    newDevices = ScanAndStartDevices(context);

                    // If no devices connected, inform user
                    if (GMKDevices.Count() == 0)
                        WriteLine(LanguageHelper.LookupPhrase("noDevicesDetected"));

                    // Inform user device was connected
                    foreach (GMKDevice device in newDevices)
                    {
                        WriteLine("GMK: " + device.Type + " - SN: " + device.SerialNumber);
                    }

                    int beginNumberOfDevices = GetAttachedDevicesCount(context);

                    // Wait for device enumeration by polling, only continue if device count changes
                    while (beginNumberOfDevices == GetAttachedDevicesCount(context) && _run)
                    {
                        Thread.Sleep(750);
                    }

                    if(_run)
                        WriteLine(LanguageHelper.LookupPhrase("rescanning"));
                }
                newDevices.Clear();
            }

            // This line is needed to garbage collect UsbDeviceCollection before exiting function
            Stop();
        }

        public static string GetSerialNumber(IUsbDevice device)
        {
            string serialNumber;
            if (!device.IsOpen)
            {
                if (!device.TryOpen())
                {
                    return "NA";
                }
            }

            serialNumber = device.Info.SerialNumber;

            device.Close();

            return serialNumber;
        }

        private static void RemoveInactiveDevices()
        {
            _threads.RemoveAll(thread => !thread.IsAlive);

            _gmkDevices.RemoveAll(device => !device.IsRunning);
        }

        private static List<GMKDevice> ScanAndStartDevices(UsbContext context)
        {
            List<GMKDevice> newDevices = new List<GMKDevice>();

            if (_deviceList == null)
            {
                _deviceList = DeviceList.Load();
            }

            RemoveInactiveDevices();

            using (UsbDeviceCollection usbDevices = context.List())
            {
                foreach (UsbDevice device in usbDevices)
                {
                    // Check VID and PID
                    if (!(device.VendorId == GMK_VID && GMK_PIDS.Contains(device.ProductId)))
                        continue;

                    // Get serialNumber
                    string serialNumber = GetSerialNumber(device);

                    if (serialNumber == "NA")
                    {
                        continue;
                    }

                    // Check if device already has a driver attached
                    bool gmkDeviceFound = false;
                    foreach (GMKDevice gmkDevice in _gmkDevices)
                    {
                        if (gmkDevice.SerialNumber == serialNumber)
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

                    // Get collection of device configs
                    DeviceConfigCollection configCollection = _deviceList.LookupSerialNumber(serialNumber);

                    DeviceConfig config;

                    // If device PID matches Joystick, 0x5750
                    if (device.ProductId == GMK_JOYSTICK_PID)
                    {
                        if (configCollection == null)
                        {
                            _deviceList.AddNewDevice(serialNumber, GMKControllerType.Joystick);
                            config = DeviceConfig.DefaultJoystick;
                            _deviceList.AddConfiguration(serialNumber, config, true);
                        }
                        else
                        {
                            config = DeviceConfig.FromFile(configCollection.defaultConfigFile, GMKControllerType.Joystick);
                        }

                        GMKJoystick joystick = new GMKJoystick(device.Clone() as UsbDevice, config, _console);
                        newDevices.Add(joystick);
                    }

                    // If device PID matches Controller, 0x5740
                    if (device.ProductId == GMK_CONTROLLER_PID)
                    {
                        if (configCollection == null)
                        {
                            _deviceList.AddNewDevice(serialNumber, GMKControllerType.Controller);
                            config = DeviceConfig.DefaultController;
                            _deviceList.AddConfiguration(serialNumber, config, true);
                        }
                        else
                        {
                            config = DeviceConfig.FromFile(configCollection.defaultConfigFile, GMKControllerType.Controller);
                        }

                        GMKController controller = new GMKController(device.Clone() as UsbDevice, config, _console);
                        newDevices.Add(controller);
                    }
                }
            }

            foreach (GMKDevice device in newDevices)
            {
                Thread t = new Thread(new ParameterizedThreadStart(Run));
                _threads.Add(t);
                t.Start(device);
            }

            _gmkDevices.AddRange(newDevices);

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
            const int nChar = 256;
            StringBuilder ss = new StringBuilder(nChar);

            IntPtr handle = IntPtr.Zero;
            handle = GetForegroundWindow();

            if (GetWindowText(handle, ss, nChar) > 0)
                return ss.ToString();
            else
                return "";
        }

        public static void CheckActiveWindowAndChangeConfiguration()
        {
            string currentWindow = ActiveWindowTitle();

            if (_oldWindowTitle == currentWindow)
                return;

            _oldWindowTitle = currentWindow;

            foreach (GMKDevice device in _gmkDevices)
            {
                DeviceConfigCollection deviceAssociations = _deviceList.LookupSerialNumber(device.SerialNumber);

                foreach (DeviceConfig config in deviceAssociations.Configs)
                {
                    if (!config.gameAssociationEnabled)
                    {
                        continue;
                    }
                    else
                    {
                        if (currentWindow.Contains(config.gameAssociation) && device.Config.name != config.name && config.gameAssociation != string.Empty)
                        {
                            device.WriteLine(LanguageHelper.LookupPhrase("autoConfigFound") + config.gameAssociation);
                            device.Config = config;
                            break;
                        }
                    }
                }
            }
        }
    }
}
