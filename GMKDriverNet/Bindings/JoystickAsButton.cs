namespace GMKDriverNET.Bindings
{
    public class JoystickAsButton
    {
        public JoystickIO input { get; set; }
        public Axis inputAxis { get; set; }
        public ButtonIO output { get; set; }
        public float rotate { get; set; }
        public float deadzone { get; set; }

        public override string ToString()
        {
            return input.ToString() + ":" + DeviceConfig.AxisToString(inputAxis) + " -> " + output.ToString();
        }

        public JoystickAsButton()
        {
            // Do nothing...
        }

        public JoystickAsButton(JoystickIO input, Axis inputAxis, ButtonIO output, float rotate, float deadzone)
        {
            this.input = input;
            this.inputAxis = inputAxis;
            this.output = output;
            this.rotate = rotate;
            this.deadzone = deadzone;
        }
    }
}
