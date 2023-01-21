namespace GMKDriverNET.Bindings
{
    public class JoystickAsButton
    {
        public JoystickIO input { get; set; }
        public Axis inputAxis { get; set; }
        public ButtonIO output { get; set; }
        public float deadzone { get; set;}

        public override string ToString()
        {
            return input.ToString() + ":" + DeviceConfig.AxisToString(inputAxis) + " -> " + output.ToString(); 
        }

        public JoystickAsButton(JoystickIO input, Axis inputAxis, ButtonIO output, float threshold)
        {
            this.input = input;
            this.inputAxis = inputAxis;
            this.output = output;
            this.deadzone = threshold;
        }
    }
}
