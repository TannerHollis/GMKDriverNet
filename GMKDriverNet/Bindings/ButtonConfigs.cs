using System.Collections.Generic;

namespace GMKDriverNET.Bindings
{
    public class ButtonConfigs
    {
        public List<ButtonAsButton> asButtons { get; set; }
        public List<ButtonAsJoystick> asJoysticks { get; set; }
        public List<ButtonAsTrigger> asTriggers { get; set; }
        public List<ButtonAsKeyboard> asKeyboards { get; set; }
        public ButtonConfigs()
        {
            asButtons = new List<ButtonAsButton>();
            asJoysticks = new List<ButtonAsJoystick>();
            asTriggers = new List<ButtonAsTrigger>();
            asKeyboards = new List<ButtonAsKeyboard>();
        }
    }
}
