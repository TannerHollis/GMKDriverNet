namespace GMKDriverNET.Bindings
{
    public class TriggerAsKeyboard
    {
        public TriggerIO input { get; set; }
        public byte key { get; set; }
        public float deadzone { get; set; }

        public override string ToString()
        {
            return input.ToString() + " -> " + (char)key;
        }

        public TriggerAsKeyboard(TriggerIO input, byte key, float threshold)
        {
            this.input = input;
            this.key = key;
            this.deadzone = threshold;
        }
    }
}
