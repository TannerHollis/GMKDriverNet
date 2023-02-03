using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace GMKDriverNET
{
    public class DeviceList
    {
        public List<DeviceConfigCollection> associations { get; set; }

        private bool _fileChanged = false;

        public DeviceList()
        {
            associations = new List<DeviceConfigCollection>();
        }

        public static DeviceList Load()
        {
            // If GMKDriver folder doesn't exist, make dir
            if (!Directory.Exists(Settings.GMKDriverFolderPath))
            {
                Directory.CreateDirectory(Settings.GMKDriverFolderPath);
            }

            // Get device List file, if it doesn't exist, create one
            string fileName = Settings.DeviceListFileName;
            if (!File.Exists(fileName))
            {
                DeviceList newDeviceList = new DeviceList();
                newDeviceList.Save();
                return newDeviceList;
            }

            // Load file normally
            string jsonString = File.ReadAllText(fileName);
            DeviceList deviceList = JsonSerializer.Deserialize<DeviceList>(jsonString);

            // Load each config once, saves time in future. However each configuration will be reloaded from files each time this function
            foreach (DeviceConfigCollection configAssociations in deviceList.associations)
            {
                foreach (string configFile in configAssociations.configFiles)
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
            File.WriteAllText(Settings.DeviceListFileName, jsonString);
            _fileChanged = true;
        }

        public DeviceConfigCollection LookupSerialNumber(string serialNumber)
        {
            if (_fileChanged)
            {
                associations = Load().associations;
                _fileChanged = false;
            }

            foreach (DeviceConfigCollection association in associations)
            {
                if (association.serialNumber == serialNumber)
                {
                    return association;
                }
            }
            return null;
        }

        public void AddNewDevice(string serialNumber, GMKControllerType type)
        {
            DeviceConfigCollection configAssociation = new DeviceConfigCollection
            {
                serialNumber = serialNumber,
                type = type
            };
            associations.Add(configAssociation);
            Save();
        }

        public void AddConfiguration(string serialNumber, DeviceConfig config, bool setDefault)
        {
            DeviceConfigCollection configAssociation = LookupSerialNumber(serialNumber);

            if (IsConfigurationAlreadyAdded(serialNumber, config))
                return;

            string file = config.name;

            config.ToFile();
            configAssociation.configFiles.Add(file);

            if (configAssociation.defaultConfigFile == null || setDefault)
            {
                configAssociation.defaultConfigFile = file;
            }
            Save();
        }

        public bool IsConfigurationAlreadyAdded(string serialNumber, DeviceConfig config)
        {
            DeviceConfigCollection configAssociation = LookupSerialNumber(serialNumber);

            foreach (string configFile in configAssociation.configFiles)
            {
                if (configFile == config.name)
                {
                    return true;
                }
            }

            return false;
        }

        public void RemoveConfiguration(string serialNumber, DeviceConfig config, bool delete)
        {
            DeviceConfigCollection configAssociation = LookupSerialNumber(serialNumber);
            configAssociation.configFiles.Remove(config.name);

            if (delete)
            {
                string fileName = Path.Combine(Settings.ConfigsFolderPath, config.name + ".json");
                File.Delete(fileName);
            }
            Save();
        }

        public void SetDefaultConfiguration(string serialNumber, DeviceConfig config)
        {
            DeviceConfigCollection configAssociation = LookupSerialNumber(serialNumber);
            configAssociation.defaultConfigFile = config.name;
            Save();
        }

        public void RenameConfiguration(string serialNumber, DeviceConfig config, string newName)
        {
            DeviceConfigCollection configAssociation = LookupSerialNumber(serialNumber);

            bool isDefault = IsConfigurationDefault(serialNumber, config);

            RemoveConfiguration(serialNumber, config, true);

            config.name = newName;

            AddConfiguration(serialNumber, config, isDefault);
            Save();
        }

        public bool IsConfigurationDefault(string serialNumber, DeviceConfig config)
        {
            DeviceConfigCollection configAssociation = LookupSerialNumber(serialNumber);
            return config.name == configAssociation.defaultConfigFile;
        }
    }
}
