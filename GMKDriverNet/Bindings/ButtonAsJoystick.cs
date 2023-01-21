namespace GMKDriverNET.Bindings
{
    public class ButtonAsJoystick
    {
        public ButtonIO input { get; set; }
        public JoystickIO output { get; set; }
        public Axis outputAxis { get; set; }

        override public string ToString()
        {
            return input.ToString() + " -> " + output.ToString() + ", " + DeviceConfig.AxisToString(outputAxis);
        }

        public ButtonAsJoystick(ButtonIO input, JoystickIO output, Axis outputAxis)
        {
            this.input = input;
            this.output = output;
            this.outputAxis = outputAxis;
        }
    }
}
