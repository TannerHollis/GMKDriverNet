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

        public DeviceConfigAssociations()
        {
            configFiles = new List<string>();
        }
    }

    public class DeviceList
    {
        public List<DeviceConfigAssociations> associations { get; set; }

        public DeviceList()
        {
            associations = new List<DeviceConfigAssociations>();
        }

        public static DeviceList Load()
        {
            string jsonString = File.ReadAllText("deviceAssociations.json");
            return JsonSerializer.Deserialize<DeviceList>(jsonString);
        }

        public void Save()
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;

            string jsonString = JsonSerializer.Serialize<DeviceList>(this, options);
            File.WriteAllText("deviceAssociations.json", jsonString);
        }

        public DeviceConfigAssociations LookupSerialNumber(string serialNumber)
        {
            foreach(DeviceConfigAssociations association in associations)
            {
                if(association.serialNumber.Equals(serialNumber))
                {
                    return association;
                }
            }
            return null;
        }

        public void AddNewDevice(string serialNumber)
        {
            DeviceConfigAssociations configAssociation = new DeviceConfigAssociations();
            configAssociation.serialNumber = serialNumber;
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
                File.Delete("Configs\\" + config.name + ".json");
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

            bool isDefault = configAssociation.defaultConfigFile == config.name;

            RemoveConfiguration(serialNumber, config, true);

            config.name = newName;

            AddConfiguration(serialNumber, config, isDefault);
            Save();
        }

        public bool isConfigurationDefault(string serialNumber, DeviceConfig config)
        {
            DeviceConfigAssociations configAssociation = LookupSerialNumber(serialNumber);
            return config.name == configAssociation.defaultConfigFile;
        }
    }
}
