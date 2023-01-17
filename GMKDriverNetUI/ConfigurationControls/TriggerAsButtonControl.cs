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
        private bool _selecting = false;

        public TriggerAsButtonControl()
        {
            InitializeComponent();
        }

        public void LoadWidget(TreeNode node)
        {
            _node = node;
            _triggerAsButton = (TriggerAsButton)_node.Tag;
            _initialized = false;
            inputTrigger.SelectedIndex = (int)_triggerAsButton.input;
            outputButton.SelectedIndex = (int)_triggerAsButton.output;
            thresholdSlider.Value = (int)(_triggerAsButton.threshold * 100.0f);
            this.Visible = true;
            _initialized = true;
        }

        private void valueChanged(object sender, EventArgs e)
        {
            if(_initialized)
            {
                _triggerAsButton.input = (TriggerIO)inputTrigger.SelectedIndex;
                _triggerAsButton.output = (ButtonIO)outputButton.SelectedIndex;
                _triggerAsButton.threshold = (float)(thresholdSlider.Value / 100.0f);
                if (!_selecting)
                    _node.Text = _triggerAsButton.ToString();
            }
        }

        private void threshold_Validating(object sender, CancelEventArgs e)
        {
            int value = thresholdSlider.Value;
            if (value > 100)
            {
                value = 100;
            }
            else if (value < 0)
            {
                value = 0;
            }
            thresholdSlider.Value = value;
        }

        private void thresholdSlider_MouseUp(object sender, MouseEventArgs e)
        {
            _selecting = false;
        }

        private void thresholdSlider_MouseDown(object sender, MouseEventArgs e)
        {
            _selecting = true;
        }
    }
}
