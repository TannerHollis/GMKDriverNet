using LibUsbDotNet.LibUsb;
using LibUsbDotNet.Main;
using LibUsbDotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using GMKDriverNET;
using System.Runtime.InteropServices;
using System.IO;

namespace LibUsbDotNetTest
{
    internal class Program
    {
        public static IUsbDevice MyUsbDevice;

        #region SET YOUR USB Vendor and Product ID!

        public static UsbDeviceFinder MyUsbFinder = new UsbDeviceFinder(0x483, 0x5750);

        #endregion

        public static void Main(string[] args)
        {
            Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));

            Thread t = new Thread(RunDriver);
            t.Start();
            t.Join();
        }

        

        private static void RunDriver()
        {
            GMKDriver.Loop();
        }
    }
}
