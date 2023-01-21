using System.Windows.Forms;

using GMKDriverNET;
using GMKDriverNET.Bindings;

namespace GMKDriverNETUI.ConfigurationControls
{
    public partial class JoystickAsKeyboardControl : UserControl
    {
        private JoystickAsKeyboard _joystickAsKeyboard;
        private TreeNode _node;

        private bool _initialized;

        private delegate void OnUpdateForm();
        private OnUpdateForm _updateForm;

        public JoystickAsKeyboardControl()
        {
            InitializeComponent();
            _updateForm = UpdateForm;
        }

        public void LoadWidget(TreeNode node, DeviceConfig config)
        {
            _node = node;
            _joystickAsKeyboard = (JoystickAsKeyboard)_node.Tag;
            _initialized = false;

            inputJoystick.LoadJoystick(_joystickAsKeyboard.input, config.type, false, _updateForm);
            inputAxis.LoadAxis(_joystickAsKeyboard.inputAxis, _updateForm);
            key.LoadKey(_joystickAsKeyboard.key, _updateForm);
            deadzone.LoadDeadzone(_joystickAsKeyboard.deadzone, _updateForm);

            this.Visible = true;
            _initialized = true;
        }

        private void UpdateForm()
        {
            if (_initialized)
            {
                _joystickAsKeyboard.input = inputJoystick.Joystick;
                _joystickAsKeyboard.inputAxis = inputAxis.Axis;
                _joystickAsKeyboard.key = key.Key;
                _joystickAsKeyboard.deadzone = deadzone.Deadzone;

                _node.Text = _joystickAsKeyboard.ToString();
            }
        }
    }
}
