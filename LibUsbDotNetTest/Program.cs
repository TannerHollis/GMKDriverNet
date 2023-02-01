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
using GMKDriverNet;
using Microsoft.VisualBasic.FileIO;

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
            CreateLanguageLookupFile();

            Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));

            Thread t = new Thread(RunDriver);
            t.Start();
            t.Join();
        }

        private static void CreateLanguageLookupFile()
        {
            WordLookups lookups = new WordLookups();
            lookups.Language = "EN";

            using (TextFieldParser parser = new TextFieldParser("wordLookups.csv"))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                
                // Read column Headers
                string[] fields = parser.ReadFields();
                
                // Loop until end of document
                while (!parser.EndOfData)
                {
                    fields = parser.ReadFields();
                    WordLookup lookup = new WordLookup();
                    lookup.shortHand = fields[0];
                    lookup.EN = fields[1];
                    lookup.ES = fields[2];
                    lookup.AF = fields[3];
                    lookup.AR = fields[4];
                    lookup.FR = fields[5];
                    lookup.RU = fields[6];
                    lookup.PT = fields[7];
                    lookup.ID = fields[8];
                    lookup.ZH = fields[9];
                    lookup.DE = fields[10];
                    lookup.JA = fields[11];
                    lookup.HI = fields[12];
                    lookups.Lookups.Add(lookup);
                }

                lookups.ToFile();
            }
        }

        private static void RunDriver()
        {
            GMKDriver.Loop();
        }
    }
}
