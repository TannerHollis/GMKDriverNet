namespace GMKDriverNET.Bindings
{
    public class JoystickAsJoystick
    {
        public JoystickIO input { get; set; }
        public JoystickIO output { get; set; }
        public float rotate { get; set; }
        public float deadzone { get; set; }
        public bool linear { get; set; }
        public bool snapMode76 { get; set; }
        public int snap76Intensity { get; set; }

        public override string ToString()
        {
            return input.ToString() + " -> " + output.ToString();
        }

        public JoystickAsJoystick(JoystickIO input, JoystickIO output, float rotate, float deadzone, bool linear, bool snapMode76, int snap76Intensity)
        {
            this.input = input;
            this.output = output;
            this.rotate = rotate;
            this.deadzone = deadzone;
            this.linear = linear;
            this.snapMode76 = snapMode76;
            this.snap76Intensity = snap76Intensity;
        }
    }
}
