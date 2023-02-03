using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GMKDriverNET.Bindings
{
    public class ButtonAsKeyboard
    {
        public ButtonIO input { get; set; }
        public List<byte> key { get; set; }

        [JsonIgnore]
        public bool IsPressed;

        public override string ToString()
        {
            return input.ToString() + " -> " + LanguageHelper.LookupPhrase("keyPress");
        }

        public ButtonAsKeyboard(ButtonIO input, byte[] key)
        {
            this.input = input;
            this.key = new List<byte> { key[0], key[1], key[2] };
            this.IsPressed = false;
        }
    }
}
