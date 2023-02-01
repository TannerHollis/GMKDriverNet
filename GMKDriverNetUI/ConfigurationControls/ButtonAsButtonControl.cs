using System.Windows.Forms;

using GMKDriverNET;
using GMKDriverNET.Bindings;

namespace GMKDriverNETUI.ConfigurationControls
{
    public partial class ButtonAsButtonControl : UserControl
    {
        private ButtonAsButton _buttonAsButton;
        private TreeNode _node;
        
        private bool _initialized;

        private delegate void OnUpdateForm();
        private OnUpdateForm _updateForm;

        public ButtonAsButtonControl()
        {
            InitializeComponent();
            _updateForm = UpdateForm;
            UpdateTextWithLanguage();
        }

        public void UpdateTextWithLanguage()
        {
            inputButtonLabel.Text = LanguageHelper.LookupPhrase("inputButton");
            outputButtonLabel.Text = LanguageHelper.LookupPhrase("outputButton");
        }

        public void LoadWidget(TreeNode node, DeviceConfig config)
        {
            _node = node;
            _buttonAsButton = (ButtonAsButton)_node.Tag;
            _initialized = false;

            inputButton.LoadButton(_buttonAsButton.input, config.type, false, _updateForm);
            outputButton.LoadButton(_buttonAsButton.output, config.type, true, _updateForm);
            
            this.Visible = true;
            _initialized = true;
        }

        private void UpdateForm()
        {
            if (_initialized)
            {
                _buttonAsButton.input = inputButton.Button;
                _buttonAsButton.output = outputButton.Button;

                _node.Text = _buttonAsButton.ToString();
            }
        }
    }
}
