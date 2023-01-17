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
    public partial class TriggerAsJoystickControl : UserControl
    {
        private TriggerAsJoystick _triggerAsJoystick;
        private TreeNode _node;
        private bool _initialized;
        private bool _selecting = false;

        public TriggerAsJoystickControl()
        {
            InitializeComponent();
        }

        public void LoadWidget(TreeNode node)
        {
            _node = node;
            _triggerAsJoystick = (TriggerAsJoystick)_node.Tag;
            _initialized = false;
            inputTrigger.SelectedIndex = (int)_triggerAsJoystick.input;
            outputJoystick.SelectedIndex = (int)_triggerAsJoystick.output;
            outputAxis.SelectedIndex = (int)_triggerAsJoystick.outputAxis;
            thresholdSlider.Value = (int)(_triggerAsJoystick.threshold * 100.0f);
            linear.Checked = _triggerAsJoystick.linear;
            this.Visible = true;
            _initialized = true;
        }

        private void valueChanged(object sender, EventArgs e)
        {
            if(_initialized)
            {
                _triggerAsJoystick.input = (TriggerIO)inputTrigger.SelectedIndex;
                _triggerAsJoystick.output = (JoystickIO)outputJoystick.SelectedIndex;
                _triggerAsJoystick.outputAxis = (Axis)outputAxis.SelectedIndex;
                _triggerAsJoystick.threshold = (float)(thresholdSlider.Value / 100.0f);
                _triggerAsJoystick.linear = linear.Checked;
                if (!_selecting)
                    _node.Text = _triggerAsJoystick.ToString();
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
