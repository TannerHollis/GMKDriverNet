using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HidLibrary;

namespace GMKDriverNET
{
	public class GMKController : GMKDevice
	{
		public GMKController(HidDevice usbDevice, DeviceConfig config, TextBox console) : 
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
