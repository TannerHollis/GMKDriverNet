using GMKDriverNET;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace LibUsbDotNetTest
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CreateLanguageLookupFile();

            foreach(char letter in "Tanner")
            {
                Keys key = ConvertCharToVirtualKey(letter);
                Console.WriteLine((int)letter);
            }
            Console.ReadLine();
        }

        public static Keys ConvertCharToVirtualKey(char ch)
        {
            short vkey = VkKeyScan(ch);
            Keys retval = (Keys)(vkey & 0xff);
            int modifiers = vkey >> 8;

            if ((modifiers & 1) != 0) retval |= Keys.Shift;
            if ((modifiers & 2) != 0) retval |= Keys.Control;
            if ((modifiers & 4) != 0) retval |= Keys.Alt;

            return retval;
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern short VkKeyScan(char ch);

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
                    lookups.Lookups.Add(lookup);
                }

                lookups.ToFile();
            }
        }
    }
}
