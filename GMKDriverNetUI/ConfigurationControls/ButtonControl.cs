using GMKDriverNET;
using System;
using System.Windows.Forms;

namespace GMKDriverNETUI.ConfigurationControls
{
    public partial class ButtonControl : UserControl
    {
        private string[] joystickInputButtons = { "A" };
        private string[] controllerInputButtons = { "A", "B", "X", "Y", "Start", "Back", "Xbox", "LeftThumb", "RightThumb", "LeftBumper", "RightBumper", "Up", "Down", "Left", "Right" };
        private string[] outputButtons = { "A", "B", "X", "Y", "Start", "Back", "Xbox", "LeftThumb", "RightThumb", "LeftBumper", "RightBumper", "Up", "Down", "Left", "Right" };

        private ButtonIO _button;
        private Delegate _updateForm;
        private bool _isInitialized;

        public ButtonIO Button { get { return _button; } }

        public ButtonControl()
        {
            InitializeComponent();
        }

        public void LoadButton(ButtonIO asButton, GMKControllerType type, bool isOutput, Delegate updateForm)
        {
            _isInitialized = false;

            button.Items.Clear();
            if (isOutput)
            {
                button.Items.AddRange(outputButtons);
            }
            else if (type == GMKControllerType.Joystick)
            {
                button.Items.AddRange(joystickInputButtons);
            }
            else if (type == GMKControllerType.Controller)
            {
                button.Items.AddRange(controllerInputButtons);
            }

            _button = asButton;
            button.SelectedIndex = (int)asButton;
            _updateForm = updateForm;
            
            _isInitialized = true;
        }

        private void button_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(_isInitialized)
            {
                _button = (ButtonIO)button.SelectedIndex;
                _updateForm.DynamicInvoke();
            }
        }
    }
}
