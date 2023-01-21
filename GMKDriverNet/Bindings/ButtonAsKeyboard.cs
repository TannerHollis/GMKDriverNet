namespace GMKDriverNET.Bindings
{
    public class ButtonAsKeyboard
    {
        public ButtonIO input { get; set; }
        public byte key { get; set; }

        public override string ToString()
        {
            return input.ToString() + " -> " + (char)key;
        }

        public ButtonAsKeyboard(ButtonIO input, byte key)
        {
            this.input = input;
            this.key = key;
        }
    }
}
