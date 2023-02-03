using GMKDriverNET;
using GMKDriverNET.Bindings;
using System.Windows.Forms;

namespace GMKDriverNETUI.ConfigurationControls
{
    public partial class TriggerAsJoystickControl : UserControl
    {
        private TriggerAsJoystick _triggerAsJoystick;
        private TreeNode _node;

        private bool _initialized;

        private delegate void OnUpdateForm();
        private OnUpdateForm _updateForm;

        public TriggerAsJoystickControl()
        {
            InitializeComponent();
            _updateForm = UpdateForm;
            UpdateTextWithLanguage();
        }

        private void UpdateTextWithLanguage()
        {
            inputTriggerLabel.Text = LanguageHelper.LookupPhrase("inputTrigger");
            outputJoystickLabel.Text = LanguageHelper.LookupPhrase("outputJoystick");
            outputAxisLabel.Text = LanguageHelper.LookupPhrase("outputAxis");
            deadzoneLabel.Text = LanguageHelper.LookupPhrase("deadzone");
            linearLabel.Text = LanguageHelper.LookupPhrase("linear");
        }

        public void LoadWidget(TreeNode node, DeviceConfig config)
        {
            _node = node;
            _triggerAsJoystick = (TriggerAsJoystick)_node.Tag;
            _initialized = false;

            inputTrigger.LoadTrigger(_triggerAsJoystick.input, config.type, false, _updateForm);
            outputJoystick.LoadJoystick(_triggerAsJoystick.output, config.type, true, _updateForm);
            outputAxis.LoadAxis(_triggerAsJoystick.outputAxis, _updateForm);
            linear.LoadBool(_triggerAsJoystick.linear, _updateForm);

            this.Visible = true;
            _initialized = true;
        }

        private void UpdateForm()
        {
            if (_initialized)
            {
                _triggerAsJoystick.input = inputTrigger.Trigger;
                _triggerAsJoystick.output = outputJoystick.Joystick;
                _triggerAsJoystick.outputAxis = outputAxis.Axis;
                _triggerAsJoystick.linear = linear.Bool;

                _node.Text = _triggerAsJoystick.ToString();
            }
        }
    }
}
