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
    public partial class ButtonAsJoystickControl : UserControl
    {
        private ButtonAsJoystick _buttonAsJoystick;
        private TreeNode _node;
        private bool _initialized;

        public ButtonAsJoystickControl()
        {
            InitializeComponent();
        }

        public void LoadWidget(TreeNode node)
        {
            _node = node;
            _buttonAsJoystick = (ButtonAsJoystick)_node.Tag;
            _initialized = false;
            inputButton.SelectedIndex = (int)_buttonAsJoystick.input;
            outputJoystick.SelectedIndex = (int)_buttonAsJoystick.output;
            outputAxis.SelectedIndex = (int)_buttonAsJoystick.outputAxis;
            this.Visible = true;
            _initialized = true;
        }

        private void valueChanged(object sender, EventArgs e)
        {
            if(_initialized)
            {
                _buttonAsJoystick.input = (ButtonIO)inputButton.SelectedIndex;
                _buttonAsJoystick.output = (JoystickIO)outputJoystick.SelectedIndex;
                _buttonAsJoystick.outputAxis = (Axis)outputAxis.SelectedIndex;
                _node.Text = _buttonAsJoystick.ToString();
            }
        }
    }
}
