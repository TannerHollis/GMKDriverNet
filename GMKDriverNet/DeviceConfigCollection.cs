using GMKDriverNET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
