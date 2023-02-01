using System.Windows.Forms;

using GMKDriverNET;
using GMKDriverNET.Bindings;

namespace GMKDriverNETUI.ConfigurationControls
{
    public partial class ButtonAsJoystickControl : UserControl
    {
        private ButtonAsJoystick _buttonAsJoystick;
        private TreeNode _node;
        
        private bool _initialized;

        private delegate void OnUpdateForm();
        private OnUpdateForm _updateForm;

        public ButtonAsJoystickControl()
        {
            InitializeComponent();
            _updateForm = UpdateForm;
            UpdateTextWithLanguage();
        }

        private void UpdateTextWithLanguage()
        {
            inputButtonLabel.Text = LanguageHelper.LookupPhrase("inputButton");
            outputJoystickLabel.Text = LanguageHelper.LookupPhrase("outputJoystick");
            outputAxisLabel.Text = LanguageHelper.LookupPhrase("outputAxis");
        }

        public void LoadWidget(TreeNode node, DeviceConfig config)
        {
            _node = node;
            _buttonAsJoystick = (ButtonAsJoystick)_node.Tag;
            _initialized = false;

            inputButton.LoadButton(_buttonAsJoystick.input, config.type, false, _updateForm);
            outputJoystick.LoadJoystick(_buttonAsJoystick.output, config.type, true, _updateForm);
            outputAxis.LoadAxis(_buttonAsJoystick.outputAxis, _updateForm);
            
            this.Visible = true;
            _initialized = true;
        }

        private void UpdateForm()
        {
            if (_initialized)
            {
                _buttonAsJoystick.input = inputButton.Button;
                _buttonAsJoystick.output = outputJoystick.Joystick;
                _buttonAsJoystick.outputAxis = outputAxis.Axis;

                _node.Text = _buttonAsJoystick.ToString();
            }
        }
    }
}
