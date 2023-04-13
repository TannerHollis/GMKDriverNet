using LibUsbDotNet;
using LibUsbDotNet.LibUsb;
using LibUsbDotNet.Main;
using Nefarius.ViGEm.Client;
using Nefarius.ViGEm.Client.Targets;
using System;
using System.Threading;
using System.Windows.Forms;

namespace GMKDriverNET
{
    public enum GMKControllerType
    {
        Joystick = 0,
        JoystickL3 = 1,
        Controller = 10,
        Undefined = 99,
    }

    public abstract class GMKDevice
    {
        private int _vid = 0x483;
        private int _pid;
        private int _interfaceN;
        private int _endpoint;
        private int _endpointBufferSize;
        private GMKControllerType _type;
        private UsbDevice _hidDevice;
        private DeviceConfig _config;
        private TextBox _consoleOutput;
        private string _serialNumber;
        private bool _run;
        private bool _paused;
        private XInputController _before;

        public int VID { get { return _vid; } }
        public int PID { get { return _pid; } }
        public int InterfaceN { get { return _interfaceN; } }
        public int EndpointN { get { return _endpoint; } }
        public bool IsRunning { get { return _run; } }

        public DeviceConfig Config
        {
            get
            {
                return _config;
            }
            set
            {
                if (value.name != _config.name)
                {
                    WriteLine("Configuration loaded: " + value.name);
                    _config = value;
                }
                else if (value.name == _config.name)
                {
                    WriteLine("Configuration updated.");
                    _config = value;
                }
            }
        }
        public GMKControllerType Type { get { return _type; } }
        public UsbDevice UsbDevice { get { return _hidDevice; } }
        public string SerialNumber { get { return _serialNumber; } }
        public bool IsPaused { get { return _paused; } }

        public XInputController ControllerBefore { get { return _before; } }

        public GMKDevice(int pid,
            int interfaceN,
            int endpoint,
            int endpointBufferSize,
            GMKControllerType type,
            UsbDevice hidDevice,
            DeviceConfig config,
            TextBox consoleOutput)
        {
            _pid = pid;
            _interfaceN = interfaceN;
            _endpoint = endpoint;
            _endpointBufferSize = endpointBufferSize;
            _type = type;
            _hidDevice = hidDevice;
            _config = config;
            _consoleOutput = consoleOutput;
            _serialNumber = GMKDriver.GetSerialNumber(_hidDevice);

            _before = new XInputController();
        }

        public void Run()
        {
            Connect();

            Loop();
        }

        public void Stop()
        {
            WriteLine(LanguageHelper.LookupPhrase("driverStopped"));
            _run = false;
            _paused = false;
        }

        public void Resume()
        {
            WriteLine(LanguageHelper.LookupPhrase("driverResumed"));
            _paused = false;
        }

        public void Pause()
        {
            WriteLine(LanguageHelper.LookupPhrase("driverPaused"));
            _paused = true;
        }

        private void Connect()
        {

            _hidDevice.Open();

            _hidDevice.SetConfiguration(_hidDevice.Configuration);

            _hidDevice.ClaimInterface(_interfaceN);
        }

        public void WriteLine(string text)
        {
            text = _type + ":" + _serialNumber + " - " + text;
            if (_consoleOutput != null)
            {
                _consoleOutput.Invoke((MethodInvoker)delegate
                {
                    _consoleOutput.AppendText(text + "\r\n");
                    _consoleOutput.Refresh();
                });
            }
            else
            {
                Console.WriteLine(text);
            }
        }

        private void Loop()
        {
            try
            {
                XInputController controller = new XInputController();
                ViGEmClient vigemClient = new ViGEmClient();
                IXbox360Controller xbox360Controller = vigemClient.CreateXbox360Controller();

                xbox360Controller.Connect();

                WriteLine(LanguageHelper.LookupPhrase("driverStarted"));

                if (_type == GMKControllerType.Joystick)
                {
                    WriteLine(LanguageHelper.LookupPhrase("rotateJoystick"));
                }
                else if (_type == GMKControllerType.Controller)
                {
                    WriteLine(LanguageHelper.LookupPhrase("rotateJoysticks"));
                }

                _run = true;
                _paused = false;

                UsbEndpointReader reader = _hidDevice.OpenEndpointReader((ReadEndpointID)_endpoint, _endpointBufferSize);

                byte[] readBuffer = new byte[_endpointBufferSize];
                byte[] dataBuffer = new byte[_endpointBufferSize - 1];

                Error ec = Error.Success;

                while (_run && ec == Error.Success)
                {
                    ec = reader.Read(readBuffer, 0, out int bytesRead);

                    if (bytesRead == _endpointBufferSize)
                    {
                        System.Array.Copy(readBuffer, 1, dataBuffer, 0, _endpointBufferSize - 1);
                        controller.Map(dataBuffer);
                        _before = controller.Clone(); // Used for GUI
                        controller.MapToConfig(_config);
                        controller.SetController(xbox360Controller);
                    }

                    if (_paused)
                    {
                        XInputController tmp = new XInputController();
                        tmp.SetController(xbox360Controller);
                        while (_paused)
                        {
                            Thread.Sleep(500);
                        }
                    }
                }

                if (!_run)
                {
                    return;
                }

                WriteLine(LanguageHelper.LookupPhrase("deviceDisconnected"));
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
            finally
            {
                _run = false;
                if (_hidDevice != null)
                {
                    if (_hidDevice.IsOpen)
                    {

                        IUsbDevice wholeUsbDevice = _hidDevice as IUsbDevice;
                        // null check
                        wholeUsbDevice?.ReleaseInterface(_interfaceN);

                        _hidDevice.Close();
                    }
                    _hidDevice = null;
                }
            }
        }
    }
}
