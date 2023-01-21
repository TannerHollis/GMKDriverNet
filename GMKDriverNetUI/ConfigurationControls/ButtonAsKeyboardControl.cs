using System.Windows.Forms;

using GMKDriverNET;
using GMKDriverNET.Bindings;

namespace GMKDriverNETUI.ConfigurationControls
{
    public partial class ButtonAsKeyboardControl : UserControl
    {
        private ButtonAsKeyboard _buttonAsKeyboard;
        private TreeNode _node;
        
        private bool _initialized;

        private delegate void OnUpdateForm();
        private OnUpdateForm _updateForm;

        public ButtonAsKeyboardControl()
        {
            InitializeComponent();
            _updateForm = UpdateForm;
        }

        public void LoadWidget(TreeNode node, DeviceConfig config)
        {
            _node = node;
            _buttonAsKeyboard = (ButtonAsKeyboard)_node.Tag;
            _initialized = false;

            inputButton.LoadButton(_buttonAsKeyboard.input, config.type, false, _updateForm);
            key.LoadKey(_buttonAsKeyboard.key, _updateForm);
            
            this.Visible = true;
            _initialized = true;
        }

        private void UpdateForm()
        {
            if (_initialized)
            {
                _buttonAsKeyboard.input = inputButton.Button;
                _buttonAsKeyboard.key = key.Key;

                _node.Text = _buttonAsKeyboard.ToString();
            }
        }
    }
}
