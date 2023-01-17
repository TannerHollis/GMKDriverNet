using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HidLibrary;

namespace HIDLibraryTest
{
    internal class Program
    {
        private const int VendorId = 0x483;
        private static readonly int[] ProductIds = new[] { 0x5750, 0x5740 };
        private static int _currentProductId;
        private static HidDevice _device;
        private static bool _attached;

        static void Main()
        {
            foreach (var productId in ProductIds)
            {
                _device = HidDevices.Enumerate(VendorId, productId).FirstOrDefault();

                if (_device == null) continue;

                _currentProductId = productId;

                _device.OpenDevice();

                _device.Inserted += DeviceAttachedHandler;
                _device.Removed += DeviceRemovedHandler;

                _device.MonitorDeviceEvents = true;

                _device.ReadReport(OnReport);
                break;
            }

            if (_device != null)
            {
                Console.WriteLine("Gamepad found, press any key to exit.");
                //Console.ReadKey();
                //_device.CloseDevice();
            }
            else
            {
                Console.WriteLine("Could not find a gamepad.");
                Console.ReadKey();
            }

            while(true)
            {
                _device.Read();
            }
        }

        private static void OnReport(HidReport report)
        {
            if (_attached == false) { return; }

            if (report.Data.Length > 0)
            {
                Console.WriteLine(BitConverter.ToString(report.Data));
            }

            _device.ReadReport(OnReport);
        }

        private static void DeviceAttachedHandler()
        {
            _attached = true;
            Console.WriteLine("Gamepad attached.");
            _device.ReadReport(OnReport);
        }

        private static void DeviceRemovedHandler()
        {
            _attached = false;
            Console.WriteLine("Gamepad removed.");
        }
    }
}
