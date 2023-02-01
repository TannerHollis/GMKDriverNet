using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

using GMKDriverNET.Bindings;

namespace GMKDriverNET
{

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
        LeftJoystick,
        RightJoystick
    }

    public enum TriggerIO
    {
        LeftTrigger,
        RightTrigger
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
        public GMKControllerType type { get; set; }
        public string gameAssociation { get; set; }
        public bool gameAssociationEnabled { get; set; }
        public ButtonConfigs buttons { get; set; }
        public JoystickConfigs joysticks { get; set; }
        public TriggerConfigs triggers { get; set; }

        public DeviceConfig(string name, GMKControllerType type)
        {
            this.name = name;
            this.type = type;
            buttons = new ButtonConfigs();
            joysticks = new JoystickConfigs();
            triggers = new TriggerConfigs();
        }

        public void RemoveBinding(object bindingIn)
        {
            switch(bindingIn)
            {
                case ButtonAsButton binding:
                    buttons.asButtons.Remove(binding);
                    break;

                case ButtonAsJoystick binding:
                    buttons.asJoysticks.Remove(binding);
                    break;

                case ButtonAsTrigger binding:
                    buttons.asTriggers.Remove(binding);
                    break;

                case ButtonAsKeyboard binding:
                    buttons.asKeyboards.Remove(binding);
                    break;

                case JoystickAsButton binding:
                    joysticks.asButtons.Remove(binding);
                    break;

                case JoystickAsJoystick binding:
                    joysticks.asJoysticks.Remove(binding);
                    break;

                case JoystickAsTrigger binding:
                    joysticks.asTriggers.Remove(binding);
                    break;

                case JoystickAsKeyboard binding:
                    joysticks.asKeyboards.Remove(binding);
                    break;

                case TriggerAsButton binding:
                    triggers.asButtons.Remove(binding);
                    break;

                case TriggerAsJoystick binding:
                    triggers.asJoysticks.Remove(binding);
                    break;

                case TriggerAsTrigger binding:
                    triggers.asTriggers.Remove(binding);
                    break;

                case TriggerAsKeyboard binding:
                    triggers.asKeyboards.Remove(binding);
                    break;

                default:
                    // Do nothing...
                    break;
            }
        }

        public static bool ConfigNameExists(string name)
        {
            foreach(string fileName in Directory.GetFiles(Settings.ConfigsFolderPath, "*.json"))
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

            if(!Directory.Exists(Settings.ConfigsFolderPath))
            {
                Directory.CreateDirectory(Settings.ConfigsFolderPath);
            }

            string fileName = Path.Combine(Settings.ConfigsFolderPath, name + ".json");

            string jsonString = JsonSerializer.Serialize<DeviceConfig>(this, options);
            File.WriteAllText(fileName, jsonString);
        }

        public static DeviceConfig FromFile(string file, GMKControllerType type)
        {
            string fileName = Path.Combine(Settings.ConfigsFolderPath, file + ".json");
            string jsonString = File.ReadAllText(fileName);
            try
            {
                DeviceConfig config = JsonSerializer.Deserialize<DeviceConfig>(jsonString);
                if(config.type != type)
                {
                    string line = string.Format(LanguageHelper.LookupPhrase("defaultLoaded1"), file, type);
                    GMKDriver.WriteLine(line);
                    GMKDriver.WriteLine(LanguageHelper.LookupPhrase("defaultLoaded2"));
                    
                    if(type == GMKControllerType.Joystick)
                    {
                        DeviceConfig defaultConfig = DeviceConfig.DefaultJoystick;
                        defaultConfig.name = file;
                        return defaultConfig;
                    }

                    if(type == GMKControllerType.Controller)
                    {
                        DeviceConfig defaultConfig = DeviceConfig.DefaultController;
                        defaultConfig.name = file;
                        return defaultConfig;
                    }
                }
                return config;
            }
            catch
            {
                string line = string.Format(LanguageHelper.LookupPhrase("failedOpenConfig1"), file);
                GMKDriver.WriteLine(line);
                GMKDriver.WriteLine(LanguageHelper.LookupPhrase("failedOpenConfig2"));
                DeviceConfig config = DeviceConfig.DefaultController;
                config.name = file;
                return config;
            }
            
        }

        public static DeviceConfig DefaultController
        {
            get 
            {
                DeviceConfig c = new DeviceConfig("Default_Controller_v1.0", GMKControllerType.Controller);

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
                c.joysticks.asJoysticks.Add(new JoystickAsJoystick(JoystickIO.LeftJoystick, JoystickIO.LeftJoystick, 0.1f, true, false, 20));
                c.joysticks.asJoysticks.Add(new JoystickAsJoystick(JoystickIO.RightJoystick, JoystickIO.RightJoystick, 0.1f, true, false, 20));

                // Triggers
                c.triggers.asTriggers.Add(new TriggerAsTrigger(TriggerIO.LeftTrigger, TriggerIO.LeftTrigger, true));
                c.triggers.asTriggers.Add(new TriggerAsTrigger(TriggerIO.RightTrigger, TriggerIO.RightTrigger, true));

                // For testing
                //c.joysticks.asButtons.Add(new JoystickAsButton(JoystickIO.Left, Axis.XPositive, ButtonIO.A, 0.2f));
                //c.joysticks.asTriggers.Add(new JoystickAsTrigger(JoystickIO.Left, Axis.XPositive, TriggerIO.Right, 0.0f, true));
                return c;
            }
        }

        public static DeviceConfig DefaultJoystick
        {
            get
            {
                DeviceConfig c = new DeviceConfig("Default_Joystick_v1.0", GMKControllerType.Joystick);

                // Buttons
                c.buttons.asButtons.Add(new ButtonAsButton(ButtonIO.A, ButtonIO.A));

                // Joysticks
                c.joysticks.asJoysticks.Add(new JoystickAsJoystick(JoystickIO.LeftJoystick, JoystickIO.LeftJoystick, 0.1f, true, false, 20));

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
