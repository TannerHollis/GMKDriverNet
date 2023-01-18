using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibUsbDotNet.LibUsb;
using LibUsbDotNet.Main;
using LibUsbDotNet;
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
        StoppedRunning
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
        private int _endpointBufferSize;
        private GMKControllerType _type;
        private IUsbDevice _hidDevice;
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
        public bool IsRunning {  get { return _run; } }

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
        public IUsbDevice UsbDevice { get { return _hidDevice; } }
        public string SerialNumber { get { return _serialNumber; } }
        public bool IsPaused { get { return _paused; } }

        public GMKDevice(int pid,
            int interfaceN,
            int endpoint,
            int endpointBufferSize,
            GMKControllerType type,
            IUsbDevice hidDevice,
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

            _xbox360Controller.Disconnect();

            return ret;
        }

        public void Stop()
        {
            WriteLine("Driver stopped.");
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
                _hidDevice.Open();

                _hidDevice.SetConfiguration(_hidDevice.Configuration);

                _hidDevice.ClaimInterface(_interfaceN);

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
            try
            {
                _controller = new XInputController();
                _vigemClient = new ViGEmClient();
                _xbox360Controller = _vigemClient.CreateXbox360Controller();

                _xbox360Controller.Connect();

                WriteLine("Starting driver...");

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
                        _controller.Map(dataBuffer);
                        //_controller.MapToConfig(_config);
                        _controller.SetController(_xbox360Controller);
                    }
                }

                if(!_run)
                {
                    return GMKError.StoppedRunning;
                }

                WriteLine("Device disconnected.");

                return GMKError.OK;
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
                return GMKError.Disconnected;
            }
            finally
            {
                if (_hidDevice != null)
                {
                    if (_hidDevice.IsOpen)
                    {
                        // If this is a "whole" usb device (libusb-win32, linux libusb-1.0)
                        // it exposes an IUsbDevice interface. If not (WinUSB) the 
                        // 'wholeUsbDevice' variable will be null indicating this is 
                        // an interface of a device; it does not require or support 
                        // configuration and interface selection.
                        IUsbDevice wholeUsbDevice = _hidDevice as IUsbDevice;
                        if (!ReferenceEquals(wholeUsbDevice, null))
                        {
                            // Release interface #0.
                            wholeUsbDevice.ReleaseInterface(0);
                        }

                        _hidDevice.Close();
                    }
                    _hidDevice = null;
                }
            }
        }
    }
}
