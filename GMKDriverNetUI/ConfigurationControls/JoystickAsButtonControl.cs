using System.Windows.Forms;

using GMKDriverNET;
using GMKDriverNET.Bindings;

namespace GMKDriverNETUI.ConfigurationControls
{
    public partial class JoystickAsButtonControl : UserControl
    {
        private JoystickAsButton _joystickAsButton;
        private TreeNode _node;
        
        private bool _initialized;

        private delegate void OnUpdateForm();
        private OnUpdateForm _updateForm;

        public JoystickAsButtonControl()
        {
            InitializeComponent();
            _updateForm = UpdateForm;
        }

        public void LoadWidget(TreeNode node, DeviceConfig config)
        {
            _node = node;
            _joystickAsButton = (JoystickAsButton)_node.Tag;
            _initialized = false;

            inputJoystick.LoadJoystick(_joystickAsButton.input, config.type, false, _updateForm);
            inputAxis.LoadAxis(_joystickAsButton.inputAxis, _updateForm);
            outputButton.LoadButton(_joystickAsButton.output, config.type, true, _updateForm);
            deadzone.LoadDeadzone(_joystickAsButton.deadzone, _updateForm);
            
            this.Visible = true;
            _initialized = true;
        }

        private void UpdateForm()
        {
            if (_initialized)
            {
                _joystickAsButton.input = inputJoystick.Joystick;
                _joystickAsButton.inputAxis = inputAxis.Axis;
                _joystickAsButton.output = outputButton.Button;
                _joystickAsButton.deadzone = deadzone.Deadzone;

                _node.Text = _joystickAsButton.ToString();
            }
        }
    }
}
