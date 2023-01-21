using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibUsbDotNet.LibUsb;
using LibUsbDotNet.Main;
using LibUsbDotNet;

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
