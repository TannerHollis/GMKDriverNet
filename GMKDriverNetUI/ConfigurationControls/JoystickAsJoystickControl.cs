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
    public partial class JoystickAsJoystickControl : UserControl
    {
        private JoystickAsJoystick _joystickAsJoystick;
        private TreeNode _node;
        private bool _initialized;
        private bool _selecting = false;

        public JoystickAsJoystickControl()
        {
            InitializeComponent();
        }

        public void LoadWidget(TreeNode node)
        {
            _node = node;
            _joystickAsJoystick = (JoystickAsJoystick)_node.Tag;
            _initialized = false;
            inputJoystick.SelectedIndex = (int)_joystickAsJoystick.input;
            outputJoystick.SelectedIndex = (int)_joystickAsJoystick.output;
            
            rotateSlider.Value = (int)_joystickAsJoystick.rotate;
            rotateValueLabel.Text = (_joystickAsJoystick.rotate).ToString() + "°";

            thresholdSlider.Value = (int)(_joystickAsJoystick.threshold * 100.0f);
            thresholdValueLabel.Text = (_joystickAsJoystick.threshold * 100).ToString() + "%";

            linear.Checked = _joystickAsJoystick.linear;
            snapMode76.Checked = _joystickAsJoystick.snapMode76;
            this.Visible = true;
            _initialized = true;
        }

        private void valueChanged(object sender, EventArgs e)
        {
            if(_initialized)
            {
                _joystickAsJoystick.input = (JoystickIO)inputJoystick.SelectedIndex;
                _joystickAsJoystick.output = (JoystickIO)outputJoystick.SelectedIndex;
                _joystickAsJoystick.rotate = (float)rotateSlider.Value;
                
                rotateValueLabel.Text = (_joystickAsJoystick.rotate).ToString() + "°";

                _joystickAsJoystick.threshold = (float)(thresholdSlider.Value) / 100.0f;
                thresholdValueLabel.Text = (_joystickAsJoystick.threshold * 100).ToString() + "%";

                _joystickAsJoystick.linear = linear.Checked;
                _joystickAsJoystick.snapMode76 = snapMode76.Checked;

                if (!_selecting)
                    _node.Text = _joystickAsJoystick.ToString();
            }
        }

        private void rotate_Validating(object sender, CancelEventArgs e)
        {
            int value = rotateSlider.Value;
            if(value > 180)
            {
                value = 180;
            }
            else if(value < -180)
            {
                value = -180;
            }
            rotateSlider.Value = value;
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
