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
    public partial class JoystickAsKeyboardControl : UserControl
    {
        private JoystickAsKeyboard _joystickAsKeyboard;
        private TreeNode _node;
        private bool _initialized;
        private bool _selecting = false;

        public JoystickAsKeyboardControl()
        {
            InitializeComponent();
        }

        public void LoadWidget(TreeNode node)
        {
            _node = node;
            _joystickAsKeyboard = (JoystickAsKeyboard)_node.Tag;
            _initialized = false;
            inputJoystick.SelectedIndex = (int)_joystickAsKeyboard.input;
            inputAxis.SelectedIndex = (int)_joystickAsKeyboard.inputAxis;
            outputKey.Text = ((char)_joystickAsKeyboard.key).ToString();
            thresholdSlider.Value = (int)(_joystickAsKeyboard.threshold * 100.0f);
            this.Visible = true;
            _initialized = true;
        }

        private void valueChanged(object sender, EventArgs e)
        {
            if(_initialized)
            {
                _joystickAsKeyboard.input = (JoystickIO)inputJoystick.SelectedIndex;
                _joystickAsKeyboard.inputAxis = (Axis)inputAxis.SelectedIndex;
                _joystickAsKeyboard.key = (byte)outputKey.Text.ToCharArray()[0];
                _joystickAsKeyboard.threshold = (float)(thresholdSlider.Value / 100.0f);
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
