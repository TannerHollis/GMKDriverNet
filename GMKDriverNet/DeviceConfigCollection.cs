using System.Collections.Generic;

namespace GMKDriverNET
{
    public class DeviceConfigCollection
    {
        public string serialNumber { get; set; }
        public List<string> configFiles { get; set; }
        public string defaultConfigFile { get; set; }
        public GMKControllerType type { get; set; }

        public List<DeviceConfig> Configs;

        public DeviceConfigCollection()
        {
            configFiles = new List<string>();
            Configs = new List<DeviceConfig>();
        }
    }
}
