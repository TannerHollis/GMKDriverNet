using GMKDriverNET;
using GMKDriverNetUI;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GMKDriverNETUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                var exists = System.Diagnostics.Process.GetProcessesByName(System.IO.Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location)).Count() > 1;
                if (!exists)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Main());
                }
            }
            catch(Exception e)
            {
                Logger.Log(e.Message);
                GMKDriver.Stop();
            }
        }
    }
}