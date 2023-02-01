using System.Windows.Forms;

using GMKDriverNET;
using GMKDriverNET.Bindings;

namespace GMKDriverNETUI.ConfigurationControls
{
    public partial class TriggerAsKeyboardControl : UserControl
    {
        private TriggerAsKeyboard _triggerAsKeyboard;
        private TreeNode _node;

        private bool _initialized;

        private delegate void OnUpdateForm();
        private OnUpdateForm _updateForm;

        public TriggerAsKeyboardControl()
        {
            InitializeComponent();
            _updateForm = UpdateForm;
            UpdateTextWithLanguage();
        }

        private void UpdateTextWithLanguage()
        {
            inputTriggerLabel.Text = LanguageHelper.LookupPhrase("inputTrigger");
            outputKeyLabel.Text = LanguageHelper.LookupPhrase("outputKey");
            thresholdLabel.Text = LanguageHelper.LookupPhrase("deadzone");
        }

        public void LoadWidget(TreeNode node, DeviceConfig config)
        {
            _node = node;
            _triggerAsKeyboard = (TriggerAsKeyboard)_node.Tag;
            _initialized = false;

            inputTrigger.LoadTrigger(_triggerAsKeyboard.input, config.type, false, _updateForm);
            key.LoadKey(_triggerAsKeyboard.key, _updateForm);
            deadzone.LoadDeadzone(_triggerAsKeyboard.deadzone, _updateForm);

            this.Visible = true;
            _initialized = true;
        }

        private void UpdateForm()
        {
            if (_initialized)
            {
                _triggerAsKeyboard.input = inputTrigger.Trigger;
                _triggerAsKeyboard.key = key.Key;
                _triggerAsKeyboard.deadzone = deadzone.Deadzone;

                _node.Text = _triggerAsKeyboard.ToString();
            }
        }
    }
}
