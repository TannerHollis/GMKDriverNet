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
    public partial class JoystickAsTriggerControl : UserControl
    {
        private JoystickAsTrigger _joystickAsKeyboard;
        private TreeNode _node;
        private bool _initialized;
        private bool _selecting = false;

        public JoystickAsTriggerControl()
        {
            InitializeComponent();
        }

        public void LoadWidget(TreeNode node)
        {
            _node = node;
            _joystickAsKeyboard = (JoystickAsTrigger)_node.Tag;
            _initialized = false;
            inputJoystick.SelectedIndex = (int)_joystickAsKeyboard.input;
            inputAxis.SelectedIndex = (int)_joystickAsKeyboard.output;
            outputTrigger.SelectedIndex = (int)_joystickAsKeyboard.output;
            thresholdSlider.Value = (int)(_joystickAsKeyboard.threshold * 100.0f);
            linear.Checked = _joystickAsKeyboard.linear;
            this.Visible = true;
            _initialized = true;
        }

        private void valueChanged(object sender, EventArgs e)
        {
            if(_initialized)
            {
                _joystickAsKeyboard.input = (JoystickIO)inputJoystick.SelectedIndex;
                _joystickAsKeyboard.inputAxis = (Axis)inputAxis.SelectedIndex;
                _joystickAsKeyboard.output = (TriggerIO)outputTrigger.SelectedIndex;
                _joystickAsKeyboard.threshold = (float)(thresholdSlider.Value / 100.0f);
                _joystickAsKeyboard.linear = linear.Checked;
                if (!_selecting)
                    _node.Text = _joystickAsKeyboard.ToString();
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
