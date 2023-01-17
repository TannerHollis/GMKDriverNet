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

        public TriggerAsTriggerControl()
        {
            InitializeComponent();
        }

        public void LoadWidget(TreeNode node)
        {
            _node = node;
            _triggerAsTrigger = (TriggerAsTrigger)_node.Tag;
            _initialized = false;
            inputTrigger.SelectedIndex = (int)_triggerAsTrigger.input;
            outputTrigger.SelectedIndex = (int)_triggerAsTrigger.output;
            linear.Checked = _triggerAsTrigger.linear;
            this.Visible = true;
            _initialized = true;
        }

        private void valueChanged(object sender, EventArgs e)
        {
            if(_initialized)
            {
                _triggerAsTrigger.input = (TriggerIO)inputTrigger.SelectedIndex;
                _triggerAsTrigger.output = (TriggerIO)outputTrigger.SelectedIndex;
                _triggerAsTrigger.linear = linear.Checked;
                _node.Text = _triggerAsTrigger.ToString();
            }
        }
    }
}
