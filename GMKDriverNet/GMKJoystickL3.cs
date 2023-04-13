using LibUsbDotNet.LibUsb;
using System.Windows.Forms;

namespace GMKDriverNET
{
    public class GMKJoystickL3 : GMKDevice
    {
        public GMKJoystickL3(UsbDevice usbDevice, DeviceConfig config, TextBox console) :
            base(0x5751,
                0,
                0x81,
                13,
                GMKControllerType.JoystickL3,
                usbDevice,
                config,
                console)
        {
            // Do nothing...
        }
    }
}
