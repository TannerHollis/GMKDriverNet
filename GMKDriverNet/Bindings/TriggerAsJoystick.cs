namespace GMKDriverNET.Bindings
{
    public class TriggerAsJoystick
    {
        public TriggerIO input { get; set; }
        public JoystickIO output { get; set; }
        public Axis outputAxis { get; set; }
        public float deadzone { get; set; }
        public bool linear { get; set; }

        public override string ToString()
        {
            return input.ToString() + " -> " + output.ToString() + ":" + DeviceConfig.AxisToString(outputAxis);
        }

        public TriggerAsJoystick(TriggerIO input, JoystickIO output, Axis outputAxis, float deadzone, bool linear)
        {
            this.input = input;
            this.output = output;
            this.outputAxis = outputAxis;
            this.deadzone = deadzone;
            this.linear = linear;
        }
    }
}
