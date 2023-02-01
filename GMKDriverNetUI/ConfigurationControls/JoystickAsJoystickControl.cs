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
            UpdateTextWithLanguage();
        }

        private void UpdateTextWithLanguage()
        {
            inputJoystickLabel.Text = LanguageHelper.LookupPhrase("inputJoystick");
            outputJoystickLabel.Text = LanguageHelper.LookupPhrase("outputJoystick");
            rotateLabel.Text = LanguageHelper.LookupPhrase("rotate");
            deadzoneLabel.Text = LanguageHelper.LookupPhrase("deadzone");
            linearLabel.Text = LanguageHelper.LookupPhrase("linear");
            snap76Label.Text = LanguageHelper.LookupPhrase("snapMode");
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
            snap76.LoadSnap76(_joystickAsJoystick.snapMode76, _joystickAsJoystick.snap76Intensity, _updateForm);

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
                _joystickAsJoystick.snap76Intensity = snap76.Intensity;

                _node.Text = _joystickAsJoystick.ToString();
            }
        }
    }
}
