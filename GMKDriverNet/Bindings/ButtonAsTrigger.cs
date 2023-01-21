namespace GMKDriverNET.Bindings
{
    public class ButtonAsTrigger
    {
        public ButtonIO input { get; set; }
        public TriggerIO output { get; set; }

        override public string ToString()
        {
            return input.ToString() + " -> " + output.ToString();
        }

        public ButtonAsTrigger(ButtonIO input, TriggerIO output)
        {
            this.input = input;
            this.output = output;
        }
    }
}
