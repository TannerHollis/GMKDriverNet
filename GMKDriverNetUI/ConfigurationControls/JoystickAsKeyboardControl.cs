using GMKDriverNET;
using GMKDriverNET.Bindings;
using System.Linq;
using System.Windows.Forms;

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
            UpdateTextWithLanguage();
        }

        private void UpdateTextWithLanguage()
        {
            inputJoystickLabel.Text = LanguageHelper.LookupPhrase("inputJoystick");
            inputAxisLabel.Text = LanguageHelper.LookupPhrase("inputAxis");
            keyLabel.Text = LanguageHelper.LookupPhrase("outputKeys");
            rotateLabel.Text = LanguageHelper.LookupPhrase("rotate");
            deadzoneLabel.Text = LanguageHelper.LookupPhrase("deadzone");
        }

        public void LoadWidget(TreeNode node, DeviceConfig config)
        {
            _node = node;
            _joystickAsKeyboard = (JoystickAsKeyboard)_node.Tag;
            _initialized = false;

            inputJoystick.LoadJoystick(_joystickAsKeyboard.input, config.type, false, _updateForm);
            inputAxis.LoadAxis(_joystickAsKeyboard.inputAxis, _updateForm);
            key.LoadKey(_joystickAsKeyboard.key.ToArray(), _updateForm);
            rotate.LoadRotate(_joystickAsKeyboard.rotate, _updateForm);
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
                _joystickAsKeyboard.key = key.Key.ToList<byte>();
                _joystickAsKeyboard.rotate = rotate.Rotate;
                _joystickAsKeyboard.deadzone = deadzone.Deadzone;

                _node.Text = _joystickAsKeyboard.ToString();
            }
        }
    }
}
