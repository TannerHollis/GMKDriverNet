using Nefarius.ViGEm.Client.Targets;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Nefarius.ViGEm.Client.Targets.Xbox360;

namespace GMKDriverNET
{
    public class XInputController
    {
        private readonly double[] snapRightZone = new double[] { 10.0 / 180.0 * Math.PI, 60.0 / 180.0 * Math.PI };
        private readonly double[] snapLeftZone = new double[] { 120.0 / 180.0 * Math.PI, 170.0 / 180.0 * Math.PI };
        private readonly double snapRightAngle = 14.0 / 180.0 * Math.PI;
        private readonly double snapLeftAngle = 166.0 / 180.0 * Math.PI;

        bool up;
        bool down;
        bool left;
        bool right;
        bool start;
        bool back;
        bool lth;
        bool rth;
        bool lb;
        bool rb;
        bool xbox;
        bool _reserved;
        bool a;
        bool b;
        bool x;
        bool y;
        Int16 leftX;
        Int16 leftY;
        Int16 rightX;
        Int16 rightY;
        char triggerLeft;
        char triggerRight;

        UInt16 buttons;

        public XInputController()
        {
            up = false;
            down = false;
            left = false;
            right = false;
            start = false;
            back = false;
            lth = false;
            rth = false;
            lb = false;
            rb = false;
            xbox = false;
            _reserved = false;
            a = false;
            b = false;
            x = false; 
            y = false;
            leftX = 0;
            leftY = 0;
            rightX = 0;
            rightY = 0;
            triggerLeft = (char)0;
            triggerRight = (char)0;
        }

        private bool GetBit(byte b, int bitNumber)
        {
            return (b & (1 << bitNumber)) != 0;
        }

        public void Map(byte[] bytes)
        {
            buttons = (UInt16)(bytes[1] << 8 | bytes[0]);

            up = GetBit(bytes[0], 0);
            down = GetBit(bytes[0], 1);
            left = GetBit(bytes[0], 2);
            right = GetBit(bytes[0], 3);
            start = GetBit(bytes[0], 4);
            back = GetBit(bytes[0], 5);
            lth = GetBit(bytes[0], 6);
            rth = GetBit(bytes[0], 7);

            lb = GetBit(bytes[1], 0);
            rb = GetBit(bytes[1], 1);
            xbox = GetBit(bytes[1], 2);
            _reserved = GetBit(bytes[1], 3);
            a = GetBit(bytes[1], 4);
            b = GetBit(bytes[1], 5);
            x = GetBit(bytes[1], 6);
            y = GetBit(bytes[1], 7);

            leftX = (Int16)(bytes[3] << 8 | bytes[2]);
            leftY = (Int16)(bytes[5] << 8 | bytes[4]);

            rightX = (Int16)(bytes[7] << 8 | bytes[6]);
            rightY = (Int16)(bytes[9] << 8 | bytes[8]);

            triggerLeft = (char)bytes[10];
            triggerRight = (char)bytes[11];
        }

        public byte[] ToBytes()
        {
            byte[] buttons = new byte[2];
            byte one = 1;
            byte zero = 0;
            buttons[0] |= (byte)((up ? one : zero) << 0);
            buttons[0] |= (byte)((down ? one : zero) << 1);
            buttons[0] |= (byte)((left ? one : zero) << 2);
            buttons[0] |= (byte)((right ? one : zero) << 3);
            buttons[0] |= (byte)((start ? one : zero) << 4);
            buttons[0] |= (byte)((back ? one : zero) << 5);
            buttons[0] |= (byte)((lth ? one : zero) << 6);
            buttons[0] |= (byte)((rth ? one : zero) << 7);
            buttons[1] |= (byte)((lb ? one : zero) << 0);
            buttons[1] |= (byte)((rb ? one : zero) << 1);
            buttons[1] |= (byte)((xbox ? one : zero) << 2);
            buttons[1] |= (byte)((_reserved ? one : zero) << 3);
            buttons[1] |= (byte)((a ? one : zero) << 4);
            buttons[1] |= (byte)((b ? one : zero) << 5);
            buttons[1] |= (byte)((x ? one : zero) << 6);
            buttons[1] |= (byte)((y ? one : zero) << 7);
            return new byte[] { 
                buttons[0],
                buttons[1],
                (byte)(leftX & 0xFF),
                (byte)((leftX >> 8) & 0xFF),
                (byte)(leftY & 0xFF),
                (byte)((leftY >> 8) & 0xFF),
                (byte)(rightX & 0xFF),
                (byte)((rightX >> 8) & 0xFF),
                (byte)(rightY & 0xFF),
                (byte)((rightY >> 8) & 0xFF),
                (byte)triggerLeft,
                (byte)triggerRight
            };
        }

        public void MapToConfig(DeviceConfig config)
        {
            XInputController tmp = new XInputController();

            // ButtonAsButton
            foreach(ButtonAsButton asButton in config.buttons.asButtons)
            {
                tmp.SetButton(asButton.output, GetButton(asButton.input));
            }

            // ButtonAsJoystick
            foreach(ButtonAsJoystick asJoystick in config.buttons.asJoysticks)
            {
                bool state = GetButton(asJoystick.input);
                if(state)
                {
                    Int16 value = state ? Int16.MaxValue : (Int16)0;
                    tmp.SetJoystick(asJoystick.output, asJoystick.outputAxis, value);
                }
            }
            
            // ButtonAsTrigger
            foreach(ButtonAsTrigger asTrigger in config.buttons.asTriggers)
            {
                bool state = GetButton(asTrigger.input);
                if (state)
                {
                    char value = state ? (char)0xFF : (char)0;
                    tmp.SetTrigger(asTrigger.output, value);
                }
            }

            // JoystickAsButton
            foreach(JoystickAsButton asButton in config.joysticks.asButtons)
            {
                float value = GetPercentage(GetJoystick(asButton.input, asButton.inputAxis));

                tmp.SetButton(asButton.output, value > asButton.threshold);
            }

            // JoystickAsJoystick
            foreach(JoystickAsJoystick asJoystick in config.joysticks.asJoysticks)
            {
                double x = GetPercentage(GetJoystick(asJoystick.input, Axis.XPositive));
                double y = GetPercentage(GetJoystick(asJoystick.input, Axis.YPositive));

                double angle = Math.Atan2(y, x);
                double mag = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

                double rotateRadians = asJoystick.rotate / 180.0f * (float)Math.PI;

                angle += rotateRadians;

                double newX = mag * Math.Cos(angle);
                double newY = mag * Math.Sin(angle);

                if (asJoystick.snapMode76)
                {
                    double angleDeg = angle * 180 / Math.PI;
                    if (angle > snapRightZone[0] && angle < snapRightZone[1])
                    {
                        newX = mag * Math.Cos(snapRightAngle);
                        newY = mag * Math.Sin(snapRightAngle);
                    }
                    
                    if (angle > snapLeftZone[0] && angle < snapLeftZone[1])
                    {
                        newX = mag * Math.Cos(snapLeftAngle);
                        newY = mag * Math.Sin(snapLeftAngle);
                    }
                }

                Int16 newXInt = GetInt((float)newX, asJoystick.linear);
                Int16 newYInt = GetInt((float)newY, asJoystick.linear);

                //Int16 newXInt = Math.Abs(newX) > asJoystick.threshold ? GetInt((float)newX, asJoystick.linear) : (Int16)0;
                //Int16 newYInt = Math.Abs(newY) > asJoystick.threshold ? GetInt((float)newY, asJoystick.linear) : (Int16)0;

                tmp.SetJoystick(asJoystick.output, Axis.XPositive, newXInt);
                tmp.SetJoystick(asJoystick.output, Axis.YPositive, newYInt);
            }

            // JoystickAsTrigger
            foreach(JoystickAsTrigger asTrigger in config.joysticks.asTriggers)
            {
                float value = GetPercentage(GetJoystick(asTrigger.input, asTrigger.inputAxis));
                
                char newValue = value > asTrigger.threshold ? GetChar((float)value, asTrigger.linear) : (char)0;

                tmp.SetTrigger(asTrigger.output, newValue);
            }

            // TriggerAsButton
            foreach(TriggerAsButton asButton in config.triggers.asButtons)
            {
                float value = GetPercentage(GetTrigger(asButton.input));

                tmp.SetButton(asButton.output, value > asButton.threshold);
            }

            // TriggerAsJoystick
            foreach(TriggerAsJoystick asJoystick in config.triggers.asJoysticks)
            {
                float value = GetPercentage(GetTrigger(asJoystick.input));

                Int16 newValue = value > asJoystick.threshold ? GetInt(value, asJoystick.linear) : (Int16)0;

                tmp.SetJoystick(asJoystick.output, asJoystick.outputAxis, newValue);
            }

            // TriggerAsTrigger
            foreach(TriggerAsTrigger asTrigger in config.triggers.asTriggers)
            {
                float value = GetTrigger(asTrigger.input);

                char newValue = GetChar(value, asTrigger.linear);

                tmp.SetTrigger(asTrigger.output, newValue);
            }

            Map(tmp.ToBytes());
        }

        private static float GetPercentage(Int16 value)
        {
            return (float)((float)value / (float)-Int16.MinValue);
        }

        private static float GetPercentage(char value)
        {
            return (float)((float)value / (char)0xFF);
        }

        private static Int16 GetInt(float value, bool linear = false)
        {
            if(linear)
            {
                float maxVal = (float)Int16.MaxValue;
                float ret = value * maxVal;
                if(Math.Abs(ret) > maxVal)
                {
                    ret = Math.Sign(ret) * maxVal;
                }
                return (Int16)ret;
            }
            else
            {
                return (Int16)((Math.Pow(value, 3)) * (float)Int16.MaxValue);
            }
        }

        private static char GetChar(float value, bool linear = false)
        {
            if (linear)
            {
                return (char)(value * (float)0xFF);
            }
            else
            {
                return (char)((Math.Pow(value, 1.7)) * (float)0xFF);
            }

        }

        private void SetTrigger(TriggerIO trigger, char value)
        {
            switch(trigger)
            {
                case TriggerIO.Left:
                    triggerLeft = value;
                    break;

                case TriggerIO.Right:
                    triggerRight = value;
                    break;

                default:
                    // Do nothing...
                    break;
            }
        }

        private char GetTrigger(TriggerIO trigger)
        {
            switch(trigger)
            {
                case TriggerIO.Left:
                    return triggerLeft;

                case TriggerIO.Right:
                    return triggerRight;

                default:
                    return (char)0;
            }
        }

        private void SetJoystick(JoystickIO joystick, Axis axis, Int16 value)
        {
            switch(joystick)
            {
                case JoystickIO.Left:
                    switch(axis)
                    {
                        case Axis.XPositive:
                            leftX = value;
                            break;

                        case Axis.XNegative:
                            leftX = (Int16)(-1 * value);
                            break;

                        case Axis.YPositive:
                            leftY = value;
                            break;

                        case Axis.YNegative:
                            leftY = (Int16)(-1 * value);
                            break;
                    }
                    break;

                case JoystickIO.Right:
                    switch (axis)
                    {
                        case Axis.XPositive:
                            rightX = value;
                            break;

                        case Axis.XNegative:
                            rightX = (Int16)(-1*value);
                            break;

                        case Axis.YPositive:
                            rightY = value;
                            break;

                        case Axis.YNegative:
                            rightY = (Int16)(-1 * value);
                            break;
                    }
                    break;

                default:
                    // Do nothing...
                    break;
            }
        }

        private Int16 GetJoystick(JoystickIO joystick, Axis axis)
        {
            switch (joystick)
            {
                case JoystickIO.Left:
                    switch (axis)
                    {
                        case Axis.XPositive:
                            return leftX;

                        case Axis.XNegative:
                            return (Int16)(-1 * leftX);

                        case Axis.YPositive:
                            return leftY;

                        case Axis.YNegative:
                            return (Int16)(-1 * leftY);

                        default:
                            return 0;
                    }

                case JoystickIO.Right:
                    switch (axis)
                    {
                        case Axis.XPositive:
                            return rightX;

                        case Axis.XNegative:
                            return (Int16)(-1 * rightX);

                        case Axis.YPositive:
                            return rightY;

                        case Axis.YNegative:
                            return (Int16)(-1 * rightY);

                        default:
                            return 0;
                    }

                default:
                    return 0;
            }
        }

        private void SetButton(ButtonIO button, bool state)
        {
            switch (button)
            {
                case ButtonIO.A:
                    a = state;
                    break;

                case ButtonIO.B:
                    b = state;
                    break;

                case ButtonIO.X:
                    x = state;
                    break;

                case ButtonIO.Y:
                    y = state;
                    break;

                case ButtonIO.Start:
                    start = state;
                    break;

                case ButtonIO.Back:
                    back = state;
                    break;

                case ButtonIO.Xbox:
                    xbox = state;
                    break;

                case ButtonIO.LeftThumb:
                    lth = state;
                    break;

                case ButtonIO.RightThumb:
                    rth = state;
                    break;

                case ButtonIO.LeftBumper:
                    lb = state;
                    break;

                case ButtonIO.RightBumper:
                    rb = state;
                    break;

                case ButtonIO.Up:
                    up = state;
                    break;

                case ButtonIO.Down:
                    down = state;
                    break;

                case ButtonIO.Left:
                    left = state;
                    break;

                case ButtonIO.Right:
                    right = state;
                    break;

                default:
                    // Do nothing...
                    break;
            }
        }

        private bool GetButton(ButtonIO button)
        {
            switch (button)
            {
                case ButtonIO.A:
                    return a;

                case ButtonIO.B:
                    return b;

                case ButtonIO.X:
                    return x;

                case ButtonIO.Y:
                    return y;

                case ButtonIO.Start:
                    return start;

                case ButtonIO.Back:
                    return back;

                case ButtonIO.Xbox:
                    return xbox;

                case ButtonIO.LeftThumb:
                    return lth;

                case ButtonIO.RightThumb:
                    return rth;

                case ButtonIO.LeftBumper:
                    return lb;

                case ButtonIO.RightBumper:
                    return rb;

                case ButtonIO.Up:
                    return up;

                case ButtonIO.Down:
                    return down;

                case ButtonIO.Left:
                    return left;

                case ButtonIO.Right:
                    return right;

                default:
                    return false;
            }
        }

        public void SetController(in IXbox360Controller controller)
        {
            controller.SetButtonsFull(buttons);
            controller.SetAxisValue(Xbox360Axis.LeftThumbX, leftX);
            controller.SetAxisValue(Xbox360Axis.LeftThumbY, leftY);
            controller.SetAxisValue(Xbox360Axis.RightThumbX, rightX);
            controller.SetAxisValue(Xbox360Axis.RightThumbY, rightY);
            controller.SetSliderValue(Xbox360Slider.LeftTrigger, Convert.ToByte(triggerLeft));
            controller.SetSliderValue(Xbox360Slider.RightTrigger, Convert.ToByte(triggerRight));
        }
    }
}
