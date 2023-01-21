using System.Collections.Generic;

namespace GMKDriverNET.Bindings
{
    public class TriggerConfigs
    {
        public List<TriggerAsButton> asButtons { get; set; }
        public List<TriggerAsJoystick> asJoysticks { get; set; }
        public List<TriggerAsTrigger> asTriggers { get; set; }
        public List<TriggerAsKeyboard> asKeyboards { get; set; }
        public TriggerConfigs()
        {
            asButtons = new List<TriggerAsButton>();
            asJoysticks = new List<TriggerAsJoystick>();
            asTriggers = new List<TriggerAsTrigger>();
            asKeyboards = new List<TriggerAsKeyboard>();
        }
    }
}
