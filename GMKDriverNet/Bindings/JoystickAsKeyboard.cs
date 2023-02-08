using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GMKDriverNET.Bindings
{
    public class JoystickAsKeyboard
    {
        public JoystickIO input { get; set; }
        public List<byte> key { get; set; }
        public float rotate { get; set; }
        public float deadzone { get; set; }

        [JsonIgnore]
        public List<bool> IsPressed;

        public override string ToString()
        {
            return input.ToString() + " -> " + LanguageHelper.LookupPhrase("keyPress");
        }

        public JoystickAsKeyboard()
        {
            this.key = new List<byte>();
            this.IsPressed = new List<bool>() { false, false, false, false };
        }

        public JoystickAsKeyboard(JoystickIO input, List<byte> key, float rotate, float deadzone)
        {
            this.input = input;
            this.key = new List<byte> { key[0], key[1], key[2], key[3] };
            this.rotate = rotate;
            this.deadzone = deadzone;
            this.IsPressed = new List<bool>() { false, false, false, false };
        }
    }
}
