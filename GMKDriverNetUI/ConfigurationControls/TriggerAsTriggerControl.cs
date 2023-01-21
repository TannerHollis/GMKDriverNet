using System.Windows.Forms;

using GMKDriverNET;
using GMKDriverNET.Bindings;

namespace GMKDriverNETUI.ConfigurationControls
{
    public partial class TriggerAsTriggerControl : UserControl
    {
        private TriggerAsTrigger _triggerAsTrigger;
        private TreeNode _node;

        private bool _initialized;

        private delegate void OnUpdateForm();
        private OnUpdateForm _updateForm;

        public TriggerAsTriggerControl()
        {
            InitializeComponent();
            _updateForm = UpdateForm;
        }

        public void LoadWidget(TreeNode node, DeviceConfig config)
        {
            _node = node;
            _triggerAsTrigger = (TriggerAsTrigger)_node.Tag;
            _initialized = false;

            inputTrigger.LoadTrigger(_triggerAsTrigger.input, config.type, false, _updateForm);
            outputTrigger.LoadTrigger(_triggerAsTrigger.output, config.type, true, _updateForm);
            linear.LoadBool(_triggerAsTrigger.linear, _updateForm);

            this.Visible = true;
            _initialized = true;
        }

        private void UpdateForm()
        {
            if (_initialized)
            {
                _triggerAsTrigger.input = inputTrigger.Trigger;
                _triggerAsTrigger.output = outputTrigger.Trigger;
                _triggerAsTrigger.linear = linear.Bool;

                _node.Text = _triggerAsTrigger.ToString();
            }
        }
    }
}
