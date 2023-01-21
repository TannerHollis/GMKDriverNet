namespace GMKDriverNET.Bindings
{
    public class TriggerAsTrigger
    {
        public TriggerIO input { get; set; }
        public TriggerIO output { get; set; }
        public bool linear { get; set; }

        public override string ToString()
        {
            return input.ToString() + " -> " + output.ToString();
        }

        public TriggerAsTrigger(TriggerIO input, TriggerIO output, bool linear)
        {
            this.input = input;
            this.output = output;
            this.linear = linear;
        }
    }
}
