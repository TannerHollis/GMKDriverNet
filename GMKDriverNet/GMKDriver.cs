using LibUsbDotNet.LibUsb;
using Nefarius.ViGEm.Client;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GMKDriverNET
{
    public class GMKDriver
    {
        public static string Version { get { return "v0.94.0"; } }

        private const int GMK_VID = 0x483;
        private const int GMK_JOYSTICK_PID = 0x5750;
        private const int GMK_CONTROLLER_PID = 0x5740;

        private static DeviceList _deviceList;
        private static List<Thread> _threads = new List<Thread>();
        private static List<GMKDevice> _gmkDevices = new List<GMKDevice>();
        private static TextBox _console;
        private static bool _run;
        private static string _oldWindowTitle;

        public static DeviceList DeviceList { 
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
            catch(Exception ex)
            {
                WriteLine(ex.Message);
                return false;
            }
            
        }

        public static void Stop()
        {
            foreach(GMKDevice device in _gmkDevices)
            {
                device.Stop();
            }

            foreach(Thread thread in _threads)
            {
                thread.Join();
            }

            _gmkDevices.RemoveAll(device => !device.IsRunning);

            _threads.RemoveAll(thread => !thread.IsAlive);

            _run = false;
        }

        public static void Loop()
        {
            _oldWindowTitle = ActiveWindowTitle();

            using (UsbContext context = new UsbContext())
            {
                WriteLine("Scanning devices...");
                List<GMKDevice> newDevices = new List<GMKDevice>();

                _run = true;

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

            if (_deviceList == null)
            {
                _deviceList = DeviceList.Load();
            }

            _threads.RemoveAll(thread => !thread.IsAlive);

            _gmkDevices.RemoveAll(device => !device.IsRunning);

            using (UsbDeviceCollection usbDevices = context.List())
            {
                foreach (UsbDevice device in usbDevices)
                {
                    // Check VID and PID
                    bool gmkDeviceFound = device.VendorId == GMK_VID &&
                        (device.ProductId == GMK_JOYSTICK_PID || device.ProductId == GMK_CONTROLLER_PID);
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

                    DeviceConfigAssociations configAssociation = _deviceList.LookupSerialNumber(serialNumber);

                    DeviceConfig config;

                    if (device.ProductId == GMK_JOYSTICK_PID)
                    {
                        if (configAssociation == null)
                        {
                            _deviceList.AddNewDevice(serialNumber, GMKControllerType.Joystick);
                            config = DeviceConfig.DefaultJoystick;
                            _deviceList.AddConfiguration(serialNumber, config, true);
                        }
                        else
                        {
                            config = DeviceConfig.FromFile(configAssociation.defaultConfigFile, GMKControllerType.Joystick);
                        }

                        GMKJoystick joystick = new GMKJoystick(device.Clone() as UsbDevice, config, _console);
                        newDevices.Add(joystick);
                    }

                    if (device.ProductId == GMK_CONTROLLER_PID)
                    {
                        if (configAssociation == null)
                        {
                            _deviceList.AddNewDevice(serialNumber, GMKControllerType.Controller);
                            config = DeviceConfig.DefaultController;
                            _deviceList.AddConfiguration(serialNumber, config, true);
                        }
                        else
                        {
                            config = DeviceConfig.FromFile(configAssociation.defaultConfigFile, GMKControllerType.Controller);
                        }

                        GMKController controller = new GMKController(device.Clone() as UsbDevice, config, _console);
                        _gmkDevices.Add(controller);
                    }
                }
            }    

            foreach(GMKDevice device in newDevices)
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
            //Create the variable
            const int nChar = 256;
            StringBuilder ss = new StringBuilder(nChar);

            //Run GetForeGroundWindows and get active window informations
            //assign them into handle pointer variable
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

            foreach(GMKDevice device in _gmkDevices)
            {
                DeviceConfigAssociations deviceAssociations = _deviceList.LookupSerialNumber(device.SerialNumber);

                foreach(DeviceConfig config in deviceAssociations.Configs)
                {
                    if(!config.gameAssociationEnabled)
                    {
                        continue;
                    }
                    else
                    {
                        if(currentWindow.Contains(config.gameAssociation) && device.Config.name != config.name && config.gameAssociation != string.Empty)
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
