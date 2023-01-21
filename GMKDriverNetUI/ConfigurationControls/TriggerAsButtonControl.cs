using GMKDriverNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMKDriverNetUI.ConfigurationControls
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

        public void LoadWidget(TreeNode node)
        {
            _node = node;
            _triggerAsButton = (TriggerAsButton)_node.Tag;
            _initialized = false;

            inputTrigger.LoadTrigger(_triggerAsButton.input, _updateForm);
            outputButton.LoadButton(_triggerAsButton.output, _updateForm);
            deadzone.LoadDeadzone(_triggerAsButton.threshold, _updateForm);
            
            this.Visible = true;
            _initialized = true;
        }

        private void UpdateForm()
        {
            if (_initialized)
            {
                _triggerAsButton.input = inputTrigger.Trigger;
                _triggerAsButton.output = outputButton.Button;
                _triggerAsButton.threshold = deadzone.Deadzone;
                
                _node.Text = _triggerAsButton.ToString();
            }
        }
    }
}
