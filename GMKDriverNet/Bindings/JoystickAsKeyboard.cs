using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GMKDriverNET.Bindings
{
    public class JoystickAsKeyboard
    {
        public JoystickIO input { get; set; }
        public Axis inputAxis { get; set; }
        public List<byte> key { get; set; }
        public float rotate { get; set; }
        public float deadzone { get; set; }

        [JsonIgnore]
        public bool IsPressed;

        public override string ToString()
        {
            return input.ToString() + ":" + DeviceConfig.AxisToString(inputAxis) + " -> " + LanguageHelper.LookupPhrase("keyPress");
        }

        public JoystickAsKeyboard()
        {
            this.key = new List<byte>();
        }

        public JoystickAsKeyboard(JoystickIO input, Axis inputAxis, List<byte> key, float rotate, float deadzone)
        {
            this.input = input;
            this.inputAxis = inputAxis;
            this.key = new List<byte> { key[0], key[1], key[2] };
            this.rotate = rotate;
            this.deadzone = deadzone;
            this.IsPressed = false;
        }
    }
}
