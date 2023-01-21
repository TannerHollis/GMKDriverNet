﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GMKDriverNET
{
    public class ButtonAsButton
    {
        public ButtonIO input { get; set; }
        public ButtonIO output { get; set; }

        override public string ToString()
        {
            return input.ToString() + " -> " + output.ToString();
        }

        public ButtonAsButton(ButtonIO input, ButtonIO output)
        {
            this.input = input;
            this.output = output;
        }
    }

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

    public class ButtonAsTrigger
    {
        public ButtonIO input { get; set; }
        public TriggerIO output { get; set; }

        override public string ToString()
        {
            return input.ToString() + " -> " + output.ToString();
        }

        public ButtonAsTrigger(ButtonIO input, TriggerIO output)
        {
            this.input = input;
            this.output = output;
        }
    }

    public class ButtonAsKeyboard
    {
        public ButtonIO input { get; set; }
        public byte key { get; set; }

        public override string ToString()
        {
            return input.ToString() + " -> " + (char)key;
        }

        public ButtonAsKeyboard(ButtonIO input, byte key)
        {
            this.input = input;
            this.key = key;
        }
    }

    public class ButtonConfigs
    {
        public List<ButtonAsButton> asButtons { get; set; }
        public List<ButtonAsJoystick> asJoysticks { get; set; }
        public List<ButtonAsTrigger> asTriggers { get; set; }
        public List<ButtonAsKeyboard> asKeyboards { get; set; }
        public ButtonConfigs()
        {
            asButtons = new List<ButtonAsButton>();
            asJoysticks = new List<ButtonAsJoystick>();
            asTriggers = new List<ButtonAsTrigger>();
            asKeyboards = new List<ButtonAsKeyboard>();
        }
    }

    public class JoystickAsButton
    {
        public JoystickIO input { get; set; }
        public Axis inputAxis { get; set; }
        public ButtonIO output { get; set; }
        public float threshold { get; set;}

        public override string ToString()
        {
            return input.ToString() + ":" + DeviceConfig.AxisToString(inputAxis) + " -> " + output.ToString(); 
        }

        public JoystickAsButton(JoystickIO input, Axis inputAxis, ButtonIO output, float threshold)
        {
            this.input = input;
            this.inputAxis = inputAxis;
            this.output = output;
            this.threshold = threshold;
        }
    }

    public class JoystickAsJoystick
    {
        public JoystickIO input { get; set; }
        public JoystickIO output { get; set;}
        public float rotate { get; set; }
        public float threshold { get; set; }
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

    public class JoystickAsTrigger
    {
        public JoystickIO input { get; set;}
        public Axis inputAxis { get; set; }
        public TriggerIO output { get; set;}
        public float threshold { get; set; }
        public bool linear { get; set; }

        public override string ToString()
        {
            return input.ToString() + ":" + DeviceConfig.AxisToString(inputAxis) + " -> " + output.ToString() + " Trigger";
        }

        public JoystickAsTrigger(JoystickIO input, Axis inputAxis, TriggerIO output, float threshold, bool linear)
        {
            this.input = input;
            this.inputAxis = inputAxis;
            this.output = output;
            this.threshold = threshold;
            this.linear = linear;
        }
    }

    public class JoystickAsKeyboard
    {
        public JoystickIO input { get; set; }
        public Axis inputAxis { get; set; }
        public byte key { get; set; }
        public float threshold { get; set; }

        public override string ToString()
        {
            return input.ToString() + ":" + DeviceConfig.AxisToString(inputAxis) + " -> " + (char)key;
        }

        public JoystickAsKeyboard(JoystickIO input, Axis inputAxis, byte key, float threshold)
        {
            this.input = input;
            this.inputAxis = inputAxis;
            this.key = key;
            this.threshold = threshold;
        }
    }

    public class JoystickConfigs
    {
        public List<JoystickAsButton> asButtons { get; set; }
        public List<JoystickAsJoystick> asJoysticks { get; set; }
        public List<JoystickAsTrigger> asTriggers { get; set; }
        public List<JoystickAsKeyboard> asKeyboards { get; set; }
        public JoystickConfigs()
        {
            asButtons = new List<JoystickAsButton>();
            asJoysticks = new List<JoystickAsJoystick>();
            asTriggers = new List<JoystickAsTrigger>();
            asKeyboards = new List<JoystickAsKeyboard>();
        }
    }

    public class TriggerAsButton
    {
        public TriggerIO input { get; set; }
        public ButtonIO output { get; set; }
        public float threshold { get; set; }

        public override string ToString()
        {
            return input.ToString() + " -> " + output.ToString();
        }

        public TriggerAsButton(TriggerIO input, ButtonIO output, float threshold)
        {
            this.input = input;
            this.output = output;
            this.threshold = threshold;
        }
    }

    public class TriggerAsJoystick
    {
        public TriggerIO input { get; set; }
        public JoystickIO output { get; set; }
        public Axis outputAxis { get; set; }
        public float threshold { get; set; }
        public bool linear { get; set; }

        public override string ToString()
        {
            return input.ToString() + " -> " + output.ToString() + ":" + DeviceConfig.AxisToString(outputAxis);
        }

        public TriggerAsJoystick(TriggerIO input, JoystickIO output, Axis outputAxis, float threshold, bool linear)
        {
            this.input = input;
            this.output = output;
            this.outputAxis = outputAxis;
            this.threshold = threshold;
            this.linear = linear;
        }
    }

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

    public class TriggerAsKeyboard
    {
        public TriggerIO input { get; set; }
        public byte key { get; set; }
        public float threshold { get; set; }

        public override string ToString()
        {
            return input.ToString() + " -> " + (char)key;
        }

        public TriggerAsKeyboard(TriggerIO input, byte key, float threshold)
        {
            this.input = input;
            this.key = key;
            this.threshold = threshold;
        }
    }

    public class TriggerConfigs
    {
        public List<TriggerAsButton> asButtons { get; set; }
        public List<TriggerAsJoystick> asJoysticks { get; set; }
        public List<TriggerAsTrigger> asTriggers { get; set; }
        public List<TriggerAsKeyboard> asKeyboards { get; set; }
        public TriggerConfigs()
        {
            asButtons = new List<TriggerAsButton>();
            asJoysticks = new List<TriggerAsJoystick>();
            asTriggers = new List<TriggerAsTrigger>();
            asKeyboards = new List<TriggerAsKeyboard>();
        }
    }

    public enum ButtonIO
    {
        A,
        B,
        X,
        Y,
        Start,
        Back,
        Xbox,
        LeftThumb,
        RightThumb,
        LeftBumper,
        RightBumper,
        Up,
        Down,
        Left,
        Right,
    }

    public enum JoystickIO
    {
        Left,
        Right
    }

    public enum TriggerIO
    {
        Left,
        Right
    }

    public enum Axis
    {
        XPositive,
        XNegative,
        YPositive,
        YNegative
    }

    public class DeviceConfig
    {
        public string name { get; set; }
        public string gameAssociation { get; set; }
        public bool gameAssociationEnabled { get; set; }
        public ButtonConfigs buttons { get; set; }
        public JoystickConfigs joysticks { get; set; }
        public TriggerConfigs triggers { get; set; }

        public DeviceConfig(string name)
        {
            this.name = name;
            buttons = new ButtonConfigs();
            joysticks = new JoystickConfigs();
            triggers = new TriggerConfigs();
        }

        public void Remove(object bindingIn)
        {
            try
            {
                ButtonAsButton binding = (ButtonAsButton)bindingIn;
                buttons.asButtons.Remove(binding);
            }
            catch { }

            try
            {
                ButtonAsJoystick binding = (ButtonAsJoystick)bindingIn;
                buttons.asJoysticks.Remove(binding);
            }
            catch { }

            try
            {
                ButtonAsTrigger binding = (ButtonAsTrigger)bindingIn;
                buttons.asTriggers.Remove(binding);
            }
            catch { }

            try
            {
                ButtonAsKeyboard binding = (ButtonAsKeyboard)bindingIn;
                buttons.asKeyboards.Remove(binding);
            }
            catch { }

            try
            {
                JoystickAsButton binding = (JoystickAsButton)bindingIn;
                joysticks.asButtons.Remove(binding);
            }
            catch { }

            try
            {
                JoystickAsJoystick binding = (JoystickAsJoystick)bindingIn;
                joysticks.asJoysticks.Remove(binding);
            }
            catch { }

            try
            {
                JoystickAsTrigger binding = (JoystickAsTrigger)bindingIn;
                joysticks.asTriggers.Remove(binding);
            }
            catch { }

            try
            {
                JoystickAsKeyboard binding = (JoystickAsKeyboard)bindingIn;
                joysticks.asKeyboards.Remove(binding);
            }
            catch { }

            try
            {
                TriggerAsButton binding = (TriggerAsButton)bindingIn;
                triggers.asButtons.Remove(binding);
            }
            catch { }

            try
            {
                TriggerAsJoystick binding = (TriggerAsJoystick)bindingIn;
                triggers.asJoysticks.Remove(binding);
            }
            catch { }

            try
            {
                TriggerAsTrigger binding = (TriggerAsTrigger)bindingIn;
                triggers.asTriggers.Remove(binding);
            }
            catch { }

            try
            {
                TriggerAsKeyboard binding = (TriggerAsKeyboard)bindingIn;
                triggers.asKeyboards.Remove(binding);
            }
            catch { }
        }

        public static bool ConfigNameExists(string name)
        {
            foreach(string fileName in Directory.GetFiles("Configs", "*.json"))
            {
                if(Path.GetFileNameWithoutExtension(fileName) == name)
                {
                    return true;
                }
            }
            return false;
        }

        public void ToFile()
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented= true;

            if(!Directory.Exists("Configs"))
            {
                Directory.CreateDirectory("Configs");
            }

            string fileName = "Configs\\" + name + ".json";

            string jsonString = JsonSerializer.Serialize<DeviceConfig>(this, options);
            File.WriteAllText(fileName, jsonString);
        }

        public static DeviceConfig FromFile(string file)
        {
            string fileName = "Configs\\" + file + ".json";
            string jsonString = File.ReadAllText(fileName);
            return JsonSerializer.Deserialize<DeviceConfig>(jsonString);
        }

        public static DeviceConfig Default
        {
            get 
            {
                DeviceConfig c = new DeviceConfig("Default_v1.0");

                // Buttons
                c.buttons.asButtons.Add(new ButtonAsButton(ButtonIO.A, ButtonIO.A));
                c.buttons.asButtons.Add(new ButtonAsButton(ButtonIO.B, ButtonIO.B));
                c.buttons.asButtons.Add(new ButtonAsButton(ButtonIO.X, ButtonIO.X));
                c.buttons.asButtons.Add(new ButtonAsButton(ButtonIO.Y, ButtonIO.Y));
                c.buttons.asButtons.Add(new ButtonAsButton(ButtonIO.Back, ButtonIO.Back));
                c.buttons.asButtons.Add(new ButtonAsButton(ButtonIO.Start, ButtonIO.Start));
                c.buttons.asButtons.Add(new ButtonAsButton(ButtonIO.LeftThumb, ButtonIO.LeftThumb));
                c.buttons.asButtons.Add(new ButtonAsButton(ButtonIO.RightThumb, ButtonIO.RightThumb));
                c.buttons.asButtons.Add(new ButtonAsButton(ButtonIO.LeftBumper, ButtonIO.LeftBumper));
                c.buttons.asButtons.Add(new ButtonAsButton(ButtonIO.RightBumper, ButtonIO.RightBumper));
                c.buttons.asButtons.Add(new ButtonAsButton(ButtonIO.Up, ButtonIO.Up));
                c.buttons.asButtons.Add(new ButtonAsButton(ButtonIO.Down, ButtonIO.Down));
                c.buttons.asButtons.Add(new ButtonAsButton(ButtonIO.Left, ButtonIO.Left));
                c.buttons.asButtons.Add(new ButtonAsButton(ButtonIO.Right, ButtonIO.Right));

                // Joysticks
                c.joysticks.asJoysticks.Add(new JoystickAsJoystick(JoystickIO.Left, JoystickIO.Left, 0.1f, true, false));
                c.joysticks.asJoysticks.Add(new JoystickAsJoystick(JoystickIO.Right, JoystickIO.Right, 0.1f, true, false));

                // Triggers
                c.triggers.asTriggers.Add(new TriggerAsTrigger(TriggerIO.Left, TriggerIO.Left, true));
                c.triggers.asTriggers.Add(new TriggerAsTrigger(TriggerIO.Right, TriggerIO.Right, true));

                // For testing
                //c.joysticks.asButtons.Add(new JoystickAsButton(JoystickIO.Left, Axis.XPositive, ButtonIO.A, 0.2f));
                //c.joysticks.asTriggers.Add(new JoystickAsTrigger(JoystickIO.Left, Axis.XPositive, TriggerIO.Right, 0.0f, true));
                return c;
            }
        }

        public static string AxisToString(Axis axis)
        {
            switch (axis)
            {
                case Axis.XPositive:
                    return "X+";
                case Axis.XNegative:
                    return "X-";
                case Axis.YPositive:
                    return "Y+";
                case Axis.YNegative:
                    return "Y-";
                default:
                    return "";
            }
        }
    }
}
