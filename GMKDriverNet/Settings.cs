using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GMKDriverNET
{
    public class Settings
    {
        public static readonly string MyDocumentsFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public static readonly string GMKDriverFolderPath = Path.Combine(MyDocumentsFolderPath, "GMKDriver");
        public static readonly string ConfigsFolderPath = Path.Combine(GMKDriverFolderPath, "Configs");
        public static readonly string SettingsFileName = Path.Combine(GMKDriverFolderPath, "settings.json");
        public static readonly string DeviceListFileName = Path.Combine(GMKDriverFolderPath, "deviceList.json");

        public bool FirstRun { get; set; }
        public string LastVersionRun { get; set; }
        public string Language { get; set; }

        public Settings()
        {
            //Do nothing...
        }

        public static Settings Default
        {
            get
            {
                Settings settings = new Settings();
                settings.Language = "EN";
                settings.FirstRun = true;
                settings.LastVersionRun = "v0.0";
                return settings;
            }
        }

        public void ToFile()
        {
            if(!Directory.Exists(GMKDriverFolderPath))
            {
                Directory.CreateDirectory(GMKDriverFolderPath);
            }
            
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;

            string jsonString = JsonSerializer.Serialize(this, options);
            File.WriteAllText(SettingsFileName, jsonString);
        }

        public static Settings FromFile()
        {
            string jsonString = File.ReadAllText(SettingsFileName);

            return JsonSerializer.Deserialize<Settings>(jsonString);
        }

        public static Settings Load()
        {
            if (!File.Exists(SettingsFileName))
            {
                Settings settings = Settings.Default;
                settings.ToFile();
                return settings;
            }
            else
            {
                return Settings.FromFile();
            }
        }

        public static string GetLanguage()
        {
            return Load().Language;
        }

        public static void SetLanguage(string language)
        {
            Settings settings = Load();
            settings.Language = language;
            settings.ToFile();
        }

        public static bool GetFirstRun()
        {
            return Load().FirstRun;
        }

        public static void SetFirstRun(bool firstRun)
        {
            Settings settings = Load();
            settings.FirstRun = firstRun;
            settings.ToFile();
        }

        public static string GetLastVersionRun()
        {
            return Load().LastVersionRun;
        }

        public static void SetLastVersionRun(string lastVersionRun)
        {
            Settings settings = Load();
            settings.LastVersionRun = lastVersionRun;
            settings.ToFile();
        }
    }
}
