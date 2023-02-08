using GMKDriverNET;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Threading;

namespace LibUsbDotNetTest
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CreateLanguageLookupFile();

            TestKeypressEmulator();
        }

        private static void TestKeypressEmulator()
        {
            for(int i = 3; i > 0; i--)
            {
                Console.WriteLine("{0}...", i);
                Thread.Sleep(1000);
            }

            KeypressEmulator.KeyDown(KeypressEmulator.ScanCodeShort.KEY_A);

            Thread.Sleep(1000);

            KeypressEmulator.KeyUp(KeypressEmulator.ScanCodeShort.KEY_A);
        }

        private static void CreateLanguageLookupFile()
        {
            WordLookups lookups = new WordLookups();

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
                    lookup.NL = fields[13];
                    lookups.Lookups.Add(lookup);
                }

                lookups.ToFile();
            }

            Console.WriteLine("language file written..");
        }
    }
}
