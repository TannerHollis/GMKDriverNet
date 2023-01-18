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
	public class GMKController : GMKDevice
	{
		public GMKController(IUsbDevice usbDevice, DeviceConfig config, TextBox console) : 
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
