using System.Collections.Generic;

namespace GMKDriverNET.Bindings
{
    public class JoystickConfigs
    {
        public List<JoystickAsButton> asButtons { get; set; }
        public List<JoystickAsJoystick> asJoysticks { get; set; }
        public List<JoystickAsTrigger> asTriggers { get; set; }
        public List<JoystickAsKeyboard> asKeyboards { get; set; }
        public JoystickConfigs()
        {
            asButtons = new List<JoystickAsButton>();
            asJoysticks = new List<JoystickAsJoystick>();
            asTriggers = new List<JoystickAsTrigger>();
            asKeyboards = new List<JoystickAsKeyboard>();
        }
    }
}
