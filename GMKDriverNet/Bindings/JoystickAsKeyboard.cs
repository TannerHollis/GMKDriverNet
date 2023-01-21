namespace GMKDriverNET.Bindings
{
    public class JoystickAsKeyboard
    {
        public JoystickIO input { get; set; }
        public Axis inputAxis { get; set; }
        public byte key { get; set; }
        public float deadzone { get; set; }

        public override string ToString()
        {
            return input.ToString() + ":" + DeviceConfig.AxisToString(inputAxis) + " -> " + (char)key;
        }

        public JoystickAsKeyboard(JoystickIO input, Axis inputAxis, byte key, float threshold)
        {
            this.input = input;
            this.inputAxis = inputAxis;
            this.key = key;
            this.deadzone = threshold;
        }
    }
}
