using System.Windows.Forms;

using GMKDriverNET;
using GMKDriverNET.Bindings;

namespace GMKDriverNETUI.ConfigurationControls
{
    public partial class TriggerAsButtonControl : UserControl
    {
        private TriggerAsButton _triggerAsButton;
        private TreeNode _node;

        private bool _initialized;

        private delegate void OnUpdateForm();
        private OnUpdateForm _updateForm;

        public TriggerAsButtonControl()
        {
            InitializeComponent();
            _updateForm = UpdateForm;
        }

        public void LoadWidget(TreeNode node, DeviceConfig config)
        {
            _node = node;
            _triggerAsButton = (TriggerAsButton)_node.Tag;
            _initialized = false;

            inputTrigger.LoadTrigger(_triggerAsButton.input, config.type, false, _updateForm);
            outputButton.LoadButton(_triggerAsButton.output, config.type, true, _updateForm);
            deadzone.LoadDeadzone(_triggerAsButton.deadzone, _updateForm);
            
            this.Visible = true;
            _initialized = true;
        }

        private void UpdateForm()
        {
            if (_initialized)
            {
                _triggerAsButton.input = inputTrigger.Trigger;
                _triggerAsButton.output = outputButton.Button;
                _triggerAsButton.deadzone = deadzone.Deadzone;
                
                _node.Text = _triggerAsButton.ToString();
            }
        }
    }
}
