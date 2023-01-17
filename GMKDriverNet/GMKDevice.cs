using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HidLibrary;
using Nefarius.ViGEm.Client.Targets;
using Nefarius.ViGEm.Client;
using System.Threading;

namespace GMKDriverNET
{
    public enum GMKError
    {
        OK,
        InvalidEndpoint,
        AlreadyOpen,
        Disconnected,
        ClaimError,
        ReadTimeout,
    }
    public enum  GMKControllerType{
        Joystick = 0,
        Controller,
        Undefined
    }

    public abstract class GMKDevice
    {
        private int _vid = 0x483;
        private int _pid;
        private int _interfaceN;
        private int _endpoint;
        private uint _endpointBufferSize;
        private GMKControllerType _type;
        private HidDevice _hidDevice;
        private DeviceConfig _config;
        private TextBox _consoleOutput;
        private string _serialNumber;
        private bool _run;
        private bool _paused;

        private XInputController _controller;
        private IXbox360Controller _xbox360Controller;
        private ViGEmClient _vigemClient;

        public int VID { get { return _vid; } }
        public int PID { get { return _pid; } }
        public int Interface { get { return _interfaceN; } }
        public int Endpoint { get { return _endpoint; } }
        public DeviceConfig Config { 
            get 
            { 
                return _config; 
            } 
            set 
            {
                if(value.name != _config.name)
                {
                    WriteLine("Configuration loaded: " + value.name);
                    _config = value;
                }
                else if(value.name == _config.name)
                {
                    WriteLine("Configuration updated.");
                    _config = value;
                }
            }
        }
        public GMKControllerType Type { get { return _type; } }
        public HidDevice UsbDevice { get { return _hidDevice; } }
        public string SerialNumber { get { return _serialNumber; } }
        public bool IsPaused { get { return _paused; } }

        public GMKDevice(int pid,
            int interfaceN,
            int endpoint,
            uint endpointBufferSize,
            GMKControllerType type,
            HidDevice hidDevice,
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
        }

        public GMKError Run()
        {
            GMKError ret;

            ret = Connect();
            if(ret != GMKError.OK)
            {
                return ret;
            }

            ret = Loop();

            return ret;
        }

        public void Stop()
        {
            _run = false;
            _paused &= false;
        }

        public void Resume()
        {
            WriteLine("Driver resumed.");
            _paused &= false;
        }

        public void Pause()
        {
            WriteLine("Driver paused.");
            _paused = true;
        }

        private GMKError Connect()
        {

            if (!_hidDevice.IsOpen)
            {
                _hidDevice.OpenDevice();
                WriteLine("Successfully opened device.");
                return GMKError.OK;
            }
            else
            {
                WriteLine("Device is already open.");
                return GMKError.AlreadyOpen;
            }
        }

        private void WriteLine(string text)
        {
            text = _type + ":" + _serialNumber + " - " + text;
            List<string> consoleOutputList = new List<string>();
            if (_consoleOutput != null)
            {
                consoleOutputList = new List<string>();
                consoleOutputList.AddRange(_consoleOutput.Lines);
                consoleOutputList.Add(text);
                _consoleOutput.Invoke((MethodInvoker)delegate
                {
                    _consoleOutput.Lines = consoleOutputList.ToArray();
                    _consoleOutput.Refresh();
                });
            }
            else
            {
                Console.WriteLine(text);
            }
        }

        private GMKError Loop()
        {
            _controller = new XInputController();
            _vigemClient = new ViGEmClient();
            _xbox360Controller = _vigemClient.CreateXbox360Controller();

            _xbox360Controller.Connect();

            WriteLine("Starting driver...");

            _hidDevice.Inserted += DeviceAttachedHandler;
            _hidDevice.Removed += DeviceRemovedHandler;

            _hidDevice.MonitorDeviceEvents = true;

            _hidDevice.ReadReport(OnReport);

            _run = true;
            _paused = false;

            while (_run)
            {
               // Do nothing...
               // Events are handled by delegates
            }

            _hidDevice.CloseDevice();

            return GMKError.OK;
        }

        private void DeviceAttachedHandler()
        {
            WriteLine("Device attached.");
            _hidDevice.ReadReport(OnReport);
        }

        private void DeviceRemovedHandler()
        {
            WriteLine("Device removed.");
        }

        private void OnReport(HidReport report)
        {
            // Subtract one byte for reportID
            if (report.Data.Length == _endpointBufferSize - 1)
            {
                while(_paused)
                {
                    Thread.Sleep(100);
                }

                _controller.Map(report.Data);
                _controller.MapToConfig(_config);
                _controller.SetController(_xbox360Controller);
                _hidDevice.ReadReport(OnReport);
            }
        }
    }
}
