using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GMKDriverNET.Bindings
{
    public class TriggerAsKeyboard
    {
        public TriggerIO input { get; set; }
        public List<byte> key { get; set; }
        public float deadzone { get; set; }

        [JsonIgnore]
        public bool IsPressed;

        public override string ToString()
        {
            return input.ToString() + " -> " + LanguageHelper.LookupPhrase("keyPress");
        }

        public TriggerAsKeyboard()
        {
            this.key = new List<byte>();
        }

        public TriggerAsKeyboard(TriggerIO input, List<byte> key, float deadzone)
        {
            this.input = input;
            this.key = new List<byte> { key[0], key[1], key[2] };
            this.deadzone = deadzone;
        }
    }
}
