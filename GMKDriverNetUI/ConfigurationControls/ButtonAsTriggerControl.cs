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
    public partial class ButtonAsTriggerControl : UserControl
    {
        private ButtonAsTrigger _buttonAsJoystick;
        private TreeNode _node;
        private bool _initialized;

        public ButtonAsTriggerControl()
        {
            InitializeComponent();
        }

        public void LoadWidget(TreeNode node)
        {
            _node = node;
            _buttonAsJoystick = (ButtonAsTrigger)_node.Tag;
            _initialized = false;
            inputButton.SelectedIndex = (int)_buttonAsJoystick.input;
            outputTrigger.SelectedIndex = (int)_buttonAsJoystick.output;
            this.Visible = true;
            _initialized = true;
        }

        private void valueChanged(object sender, EventArgs e)
        {
            if(_initialized)
            {
                _buttonAsJoystick.input = (ButtonIO)inputButton.SelectedIndex;
                _buttonAsJoystick.output = (TriggerIO)outputTrigger.SelectedIndex;
                _node.Text = _buttonAsJoystick.ToString();
            }
        }
    }
}
