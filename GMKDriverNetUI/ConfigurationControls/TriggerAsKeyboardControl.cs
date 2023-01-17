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
    public partial class TriggerAsKeyboardControl : UserControl
    {
        private TriggerAsKeyboard _triggerAsKeyboard;
        private TreeNode _node;
        private bool _initialized;
        private bool _selecting = false;

        public TriggerAsKeyboardControl()
        {
            InitializeComponent();
        }

        public void LoadWidget(TreeNode node)
        {
            _node = node;
            _triggerAsKeyboard = (TriggerAsKeyboard)_node.Tag;
            _initialized = false;
            inputTrigger.SelectedIndex = (int)_triggerAsKeyboard.input;
            outputKey.Text = ((char)_triggerAsKeyboard.key).ToString();
            thresholdSlider.Value = (int)(_triggerAsKeyboard.threshold * 100.0f);
            this.Visible = true;
            _initialized = true;
        }

        private void valueChanged(object sender, EventArgs e)
        {
            if(_initialized)
            {
                _triggerAsKeyboard.input = (TriggerIO)inputTrigger.SelectedIndex;
                _triggerAsKeyboard.key = (byte)outputKey.Text.ToCharArray()[0];
                _triggerAsKeyboard.threshold = (float)(thresholdSlider.Value / 100.0f);
                if(!_selecting)
                    _node.Text = _triggerAsKeyboard.ToString();
            }
        }

        private void threshold_Validating(object sender, CancelEventArgs e)
        {
            int value = thresholdSlider.Value;
            if (value > 180)
            {
                value = 180;
            }
            else if (value < -180)
            {
                value = -180;
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
