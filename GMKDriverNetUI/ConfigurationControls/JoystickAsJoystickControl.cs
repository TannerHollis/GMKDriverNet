using System.Windows.Forms;

using GMKDriverNET;
using GMKDriverNET.Bindings;

namespace GMKDriverNETUI.ConfigurationControls
{
    public partial class JoystickAsJoystickControl : UserControl
    {
        private JoystickAsJoystick _joystickAsJoystick;
        private TreeNode _node;
        
        private bool _initialized;

        private delegate void OnUpdateForm();
        private OnUpdateForm _updateForm;

        public JoystickAsJoystickControl()
        {
            InitializeComponent();
            _updateForm = UpdateForm;
        }

        public void LoadWidget(TreeNode node, DeviceConfig config)
        {
            _node = node;
            _joystickAsJoystick = (JoystickAsJoystick)_node.Tag;
            _initialized = false;

            inputJoystick.LoadJoystick(_joystickAsJoystick.input, config.type, false, _updateForm);
            outputJoystick.LoadJoystick(_joystickAsJoystick.output, config.type, true, _updateForm);
            rotate.LoadRotate(_joystickAsJoystick.rotate, _updateForm);
            deadzone.LoadDeadzone(_joystickAsJoystick.deadzone, _updateForm);
            linear.LoadBool(_joystickAsJoystick.linear, _updateForm);
            snap76.LoadBool(_joystickAsJoystick.snapMode76, _updateForm);

            this.Visible = true;
            _initialized = true;
        }

        private void UpdateForm()
        {
            if(_initialized)
            {
                _joystickAsJoystick.input = inputJoystick.Joystick;
                _joystickAsJoystick.output = outputJoystick.Joystick;
                _joystickAsJoystick.rotate = rotate.Rotate;
                _joystickAsJoystick.deadzone = deadzone.Deadzone;
                _joystickAsJoystick.linear = linear.Bool;
                _joystickAsJoystick.snapMode76 = snap76.Bool;

                _node.Text = _joystickAsJoystick.ToString();
            }
        }
    }
}
