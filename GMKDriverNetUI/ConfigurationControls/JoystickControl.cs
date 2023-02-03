using GMKDriverNET;
using System;
using System.Windows.Forms;

namespace GMKDriverNETUI.ConfigurationControls
{
    public partial class JoystickControl : UserControl
    {
        private string[] joystickInputJoysticks = { "Left Joystick" };
        private string[] controllerInputJoystick = { "Left Joystick", "Right Joystick" };
        private string[] outputJoysticks = { "Left Joystick", "Right Joystick" };

        private JoystickIO _joystick;
        private Delegate _updateForm;
        private bool _isInitialized;

        public JoystickIO Joystick { get { return _joystick; } }

        public JoystickControl()
        {
            InitializeComponent();
        }

        public void LoadJoystick(JoystickIO asJoystick, GMKControllerType type, bool isOutput, Delegate updateForm)
        {
            _isInitialized = false;

            joystick.Items.Clear();
            if (isOutput)
            {
                joystick.Items.AddRange(outputJoysticks);
            }
            else if (type == GMKControllerType.Joystick)
            {
                joystick.Items.AddRange(joystickInputJoysticks);
            }
            else if (type == GMKControllerType.Controller)
            {
                joystick.Items.AddRange(controllerInputJoystick);
            }

            _joystick = asJoystick;
            joystick.SelectedIndex = (int)asJoystick;
            _updateForm = updateForm;

            _isInitialized = true;
        }

        private void joystick_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isInitialized)
            {
                _joystick = (JoystickIO)joystick.SelectedIndex;
                _updateForm.DynamicInvoke();
            }
        }
    }
}
