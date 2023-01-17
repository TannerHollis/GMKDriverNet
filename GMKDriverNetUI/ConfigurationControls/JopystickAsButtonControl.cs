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
    public partial class JoystickAsButtonControl : UserControl
    {
        private JoystickAsButton _joystickAsButton;
        private TreeNode _node;
        private bool _initialized;
        private bool _selecting = false;

        public JoystickAsButtonControl()
        {
            InitializeComponent();
        }

        public void LoadWidget(TreeNode node)
        {
            _node = node;
            _joystickAsButton = (JoystickAsButton)_node.Tag;
            _initialized = false;
            inputJoystick.SelectedIndex = (int)_joystickAsButton.input;
            inputAxis.SelectedIndex = (int)_joystickAsButton.inputAxis;
            outputButton.SelectedIndex = (int)_joystickAsButton.output;
            thresholdSlider.Value = (int)(_joystickAsButton.threshold * 100.0f);
            thresholdValueLabel.Text = (_joystickAsButton.threshold * 100).ToString() + "%";
            this.Visible = true;
            _initialized = true;
        }

        private void valueChanged(object sender, EventArgs e)
        {
            if(_initialized)
            {
                _joystickAsButton.input = (JoystickIO)inputJoystick.SelectedIndex;
                _joystickAsButton.inputAxis = (Axis)inputAxis.SelectedIndex;
                _joystickAsButton.output = (ButtonIO)outputButton.SelectedIndex;
                _joystickAsButton.threshold = (float)(thresholdSlider.Value) / 100.0f;
                thresholdValueLabel.Text = (_joystickAsButton.threshold * 100).ToString() + "%";
                if(!_selecting)
                    _node.Text = _joystickAsButton.ToString();
            }
        }

        private void threshold_Validating(object sender, CancelEventArgs e)
        {
            int value = thresholdSlider.Value;
            if(value > 100)
            {
                value = 100;
            }
            else if(value < 0)
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
