using System.Security.Permissions;

namespace GMKDriverNET.Bindings
{
    public class JoystickAsTrigger
    {
        public JoystickIO input { get; set; }
        public Axis inputAxis { get; set; }
        public TriggerIO output { get; set; }
        public float rotate { get; set; }
        public float deadzone { get; set; }
        public bool linear { get; set; }

        public override string ToString()
        {
            return input.ToString() + ":" + DeviceConfig.AxisToString(inputAxis) + " -> " + output.ToString() + " Trigger";
        }

        public JoystickAsTrigger()
        {
            // Do nothing...
        }

        public JoystickAsTrigger(JoystickIO input, Axis inputAxis, TriggerIO output, float rotate, float deadzone, bool linear)
        {
            this.input = input;
            this.inputAxis = inputAxis;
            this.output = output;
            this.rotate = rotate;
            this.deadzone = deadzone;
            this.linear = linear;
        }
    }
}
