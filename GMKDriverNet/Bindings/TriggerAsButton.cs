namespace GMKDriverNET.Bindings
{
    public class TriggerAsButton
    {
        public TriggerIO input { get; set; }
        public ButtonIO output { get; set; }
        public float deadzone { get; set; }

        public override string ToString()
        {
            return input.ToString() + " -> " + output.ToString();
        }

        public TriggerAsButton(TriggerIO input, ButtonIO output, float deadzone)
        {
            this.input = input;
            this.output = output;
            this.deadzone = deadzone;
        }
    }
}
