using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GMKDriverNET
{
    public class DeviceConfigAssociations
    {
        public string serialNumber { get; set; }
        public List<string> configFiles { get; set; }
        public string defaultConfigFile { get; set; }
        public GMKControllerType type { get; set; }

        public List<DeviceConfig> Configs;

        public DeviceConfigAssociations()
        {
            configFiles = new List<string>();
            Configs = new List<DeviceConfig>();
        }
    }

    public class DeviceList
    {
        public List<DeviceConfigAssociations> associations { get; set; }

        private bool _fileChanged = false;

        public DeviceList()
        {
            associations = new List<DeviceConfigAssociations>();
        }

        public static string GetDeviceListFileName()
        {
            return Path.Combine(GetGMKDriverFolder(), "deviceList.json");
        }

        public static string GetGMKDriverFolder()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "GMKDriver");
        }

        public static DeviceList Load()
        {
            if(!Directory.Exists(GetGMKDriverFolder()))
            {
                Directory.CreateDirectory(GetGMKDriverFolder());
            }

            string fileName = GetDeviceListFileName();
            if (!File.Exists(fileName))
            {
                DeviceList newDeviceList = new DeviceList();
                newDeviceList.Save();
                return newDeviceList;
            }
            string jsonString = File.ReadAllText(fileName);
            DeviceList deviceList = JsonSerializer.Deserialize<DeviceList>(jsonString);

            foreach(DeviceConfigAssociations configAssociations in deviceList.associations)
            {
                foreach(string configFile in configAssociations.configFiles)
                {
                    configAssociations.Configs.Add(DeviceConfig.FromFile(configFile, configAssociations.type));
                }
            }
            return deviceList;
        }

        public void Save()
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;

            string jsonString = JsonSerializer.Serialize<DeviceList>(this, options);
            File.WriteAllText(GetDeviceListFileName(), jsonString);
            _fileChanged = true;
        }

        public DeviceConfigAssociations LookupSerialNumber(string serialNumber)
        {
            if(_fileChanged)
            {
                associations = Load().associations;
                _fileChanged = false;
            }

            foreach(DeviceConfigAssociations association in associations)
            {
                if(association.serialNumber == serialNumber)
                {
                    return association;
                }
            }
            return null;
        }

        public void AddNewDevice(string serialNumber, GMKControllerType type)
        {
            DeviceConfigAssociations configAssociation = new DeviceConfigAssociations();
            configAssociation.serialNumber = serialNumber;
            configAssociation.type = type;
            associations.Add(configAssociation);
            Save();
        }

        public void AddConfiguration(string serialNumber, DeviceConfig config, bool setDefault)
        {
            DeviceConfigAssociations configAssociation = LookupSerialNumber(serialNumber);

            foreach(string configFile in configAssociation.configFiles)
            {
                if(configFile == config.name)
                {
                    return;
                }
            }

            string file = config.name;

            config.ToFile();
            configAssociation.configFiles.Add(file);
            
            if(configAssociation.defaultConfigFile == null || setDefault)
            {
                configAssociation.defaultConfigFile = file;
            }
            Save();
        }

        public void RemoveConfiguration(string serialNumber, DeviceConfig config, bool delete)
        {
            DeviceConfigAssociations configAssociation = LookupSerialNumber(serialNumber);
            configAssociation.configFiles.Remove(config.name);
            
            if(delete)
            {
                string fileName = Path.Combine(DeviceConfig.GetDeviceConfigFolder(), config.name + ".json");
                File.Delete(fileName);
            }
            Save();
        }

        public void SetDefaultConfiguration(string serialNumber, DeviceConfig config)
        {
            DeviceConfigAssociations configAssociation = LookupSerialNumber(serialNumber);
            configAssociation.defaultConfigFile = config.name;
            Save();
        }

        public void RenameConfiguration(string serialNumber, DeviceConfig config, string newName)
        {
            DeviceConfigAssociations configAssociation = LookupSerialNumber(serialNumber);

            bool isDefault = IsConfigurationDefault(serialNumber, config);

            RemoveConfiguration(serialNumber, config, true);

            config.name = newName;

            AddConfiguration(serialNumber, config, isDefault);
            Save();
        }

        public bool IsConfigurationDefault(string serialNumber, DeviceConfig config)
        {
            DeviceConfigAssociations configAssociation = LookupSerialNumber(serialNumber);
            return config.name == configAssociation.defaultConfigFile;
        }
    }
}
