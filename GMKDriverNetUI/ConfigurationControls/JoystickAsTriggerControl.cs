using System.Windows.Forms;

using GMKDriverNET;
using GMKDriverNET.Bindings;

namespace GMKDriverNETUI.ConfigurationControls
{
    public partial class JoystickAsTriggerControl : UserControl
    {
        private JoystickAsTrigger _joystickAsKeyboard;
        private TreeNode _node;
        
        private bool _initialized;

        private delegate void OnUpdateForm();
        private OnUpdateForm _updateForm;

        public JoystickAsTriggerControl()
        {
            InitializeComponent();
            _updateForm = UpdateForm;
        }

        public void LoadWidget(TreeNode node, DeviceConfig config)
        {
            _node = node;
            _joystickAsKeyboard = (JoystickAsTrigger)_node.Tag;
            _initialized = false;

            inputJoystick.LoadJoystick(_joystickAsKeyboard.input, config.type, false, _updateForm);
            inputAxis.LoadAxis(_joystickAsKeyboard.inputAxis, _updateForm);
            outputTrigger.LoadTrigger(_joystickAsKeyboard.output, config.type, true, _updateForm);
            deadzone.LoadDeadzone(_joystickAsKeyboard.deadzone, _updateForm);
            linear.LoadBool(_joystickAsKeyboard.linear, _updateForm);

            this.Visible = true;
            _initialized = true;
        }

        private void UpdateForm()
        {
            if (_initialized)
            {
                _joystickAsKeyboard.input = inputJoystick.Joystick;
                _joystickAsKeyboard.inputAxis = inputAxis.Axis;
                _joystickAsKeyboard.output = outputTrigger.Trigger;
                _joystickAsKeyboard.deadzone = deadzone.Deadzone;
                _joystickAsKeyboard.linear = linear.Bool;

                _node.Text = _joystickAsKeyboard.ToString();
            }
        }
    }
}
