using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMKDriverNetUI
{
    public class Logger
    {
        public static readonly string MyDocumentsFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public static readonly string GMKDriverFolderPath = Path.Combine(MyDocumentsFolderPath, "GMKDriver");
        public static readonly string LogFile = Path.Combine(GMKDriverFolderPath, "log.txt");

        public static void Log(string message)
        {
            string logMessage = FormatLogMessage(message);

            // If GMK Driver folder doesn't exist
            if(!Directory.Exists(GMKDriverFolderPath))
            {
                Directory.CreateDirectory(GMKDriverFolderPath);
            }

            if(!File.Exists(LogFile))
            {
                File.WriteAllText(LogFile, logMessage);
            }
            else
            {
                File.AppendAllText(LogFile, logMessage);
            }
        }

        private static string FormatLogMessage(string message)
        {
            return DateTime.Now.ToString("g", DateTimeFormatInfo.InvariantInfo) + " - " + message + "\n";
        }
    }
}
