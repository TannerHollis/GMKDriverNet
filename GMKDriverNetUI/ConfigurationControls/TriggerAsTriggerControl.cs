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

        public void LoadWidget(TreeNode node)
        {
            _node = node;
            _triggerAsTrigger = (TriggerAsTrigger)_node.Tag;
            _initialized = false;

            inputTrigger.LoadTrigger(_triggerAsTrigger.input, _updateForm);
            outputTrigger.LoadTrigger(_triggerAsTrigger.output, _updateForm);
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
