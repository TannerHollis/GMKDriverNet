using GMKDriverNET;
using System;
using System.Windows.Forms;

namespace GMKDriverNETUI.ConfigurationControls
{
    public partial class ButtonControl : UserControl
    {
        private string[] joystickInputButtons = { "A" };
        private string[] joystickL3InputButtons = { "A", "LeftThumb" };
        private string[] controllerInputButtons = { "A", "B", "X", "Y", "Start", "Back", "Xbox", "LeftThumb", "RightThumb", "LeftBumper", "RightBumper", "Up", "Down", "Left", "Right" };
        private string[] outputButtons = { "A", "B", "X", "Y", "Start", "Back", "Xbox", "LeftThumb", "RightThumb", "LeftBumper", "RightBumper", "Up", "Down", "Left", "Right" };

        private ButtonIO _button;
        private Delegate _updateForm;
        private bool _isInitialized;
        private bool _isOutput;
        private GMKControllerType _type;

        public ButtonIO Button { get { return _button; } }

        public ButtonControl()
        {
            InitializeComponent();
        }

        public void LoadButton(ButtonIO asButton, GMKControllerType type, bool isOutput, Delegate updateForm)
        {
            _isInitialized = false;

            _type = type;
            _isOutput = isOutput;

            button.Items.Clear();
            if (isOutput)
            {
                button.Items.AddRange(outputButtons);
                button.SelectedIndex = (int)asButton;
            }
            else if (type == GMKControllerType.Joystick)
            {
                button.Items.AddRange(joystickInputButtons);
                button.SelectedIndex = (int)asButton;
            }
            else if (type == GMKControllerType.JoystickL3)
            {
                button.Items.AddRange(joystickL3InputButtons);
                if (asButton == ButtonIO.A)
                {
                    button.SelectedIndex = 0;
                }
                else if (asButton == ButtonIO.LeftThumb)
                {
                    button.SelectedIndex = 1;
                }
            }
            else if (type == GMKControllerType.Controller)
            {
                button.Items.AddRange(controllerInputButtons);
                button.SelectedIndex = (int)asButton;
            }

            _button = asButton;
            _updateForm = updateForm;

            _isInitialized = true;
        }

        private void button_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isInitialized)
            {
                if(!_isOutput && _type == GMKControllerType.JoystickL3)
                {
                    if(button.SelectedIndex == 0)
                    {
                        _button = ButtonIO.A;
                    }
                    else if(button.SelectedIndex == 1)
                    {
                        _button = ButtonIO.LeftThumb;
                    }
                }
                else
                {
                    _button = (ButtonIO)button.SelectedIndex;
                }
                _updateForm.DynamicInvoke();
            }
        }
    }
}
