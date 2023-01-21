namespace GMKDriverNET.Bindings
{
    public class JoystickAsJoystick
    {
        public JoystickIO input { get; set; }
        public JoystickIO output { get; set;}
        public float rotate { get; set; }
        public float deadzone { get; set; }
        public bool linear { get; set; }
        public bool snapMode76 { get; set; }

        public override string ToString()
        {
            return input.ToString() + " -> " + output.ToString();
        }

        public JoystickAsJoystick(JoystickIO input, JoystickIO output, float rotate, bool linear, bool snapMode76)
        {
            this.input = input;
            this.output = output;
            this.rotate = rotate;
            this.linear = linear;
            this.snapMode76 = snapMode76;
        }
    }
}
