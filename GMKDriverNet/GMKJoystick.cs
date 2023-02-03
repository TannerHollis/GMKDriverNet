using LibUsbDotNet.LibUsb;
using System.Windows.Forms;

namespace GMKDriverNET
{
    public class GMKJoystick : GMKDevice
    {
        public GMKJoystick(UsbDevice usbDevice, DeviceConfig config, TextBox console) :
            base(0x5750,
                0,
                0x81,
                13,
                GMKControllerType.Joystick,
                usbDevice,
                config,
                console)
        {
            // Do nothing...
        }
    }
}
