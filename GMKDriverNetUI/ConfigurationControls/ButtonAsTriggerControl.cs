using GMKDriverNET;
using GMKDriverNET.Bindings;
using System.Windows.Forms;

namespace GMKDriverNETUI.ConfigurationControls
{
    public partial class ButtonAsTriggerControl : UserControl
    {
        private ButtonAsTrigger _buttonAsTrigger;
        private TreeNode _node;

        private bool _initialized;

        private delegate void OnUpdateForm();
        private OnUpdateForm _updateForm;

        public ButtonAsTriggerControl()
        {
            InitializeComponent();
            _updateForm = UpdateForm;
            UpdateTextWithLanguage();
        }

        private void UpdateTextWithLanguage()
        {
            inputButtonLabel.Text = LanguageHelper.LookupPhrase("inputButton");
            outputTriggerLabel.Text = LanguageHelper.LookupPhrase("outputTrigger");
        }

        public void LoadWidget(TreeNode node, DeviceConfig config)
        {
            _node = node;
            _buttonAsTrigger = (ButtonAsTrigger)_node.Tag;
            _initialized = false;

            inputButton.LoadButton(_buttonAsTrigger.input, config.type, false, _updateForm);
            outputTrigger.LoadTrigger(_buttonAsTrigger.output, config.type, true, _updateForm);

            this.Visible = true;
            _initialized = true;
        }

        private void UpdateForm()
        {
            if (_initialized)
            {
                _buttonAsTrigger.input = inputButton.Button;
                _buttonAsTrigger.output = outputTrigger.Trigger;

                _node.Text = _buttonAsTrigger.ToString();
            }
        }
    }
}
