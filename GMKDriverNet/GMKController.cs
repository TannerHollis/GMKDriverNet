using LibUsbDotNet.LibUsb;
using System.Windows.Forms;

namespace GMKDriverNET
{
    public class GMKController : GMKDevice
    {
        public GMKController(UsbDevice usbDevice, DeviceConfig config, TextBox console) :
            base(0x5740,
                2,
                0x83,
                13,
                GMKControllerType.Controller,
                usbDevice,
                config,
                console)
        {
            // Do nothing...
        }
    }
}
