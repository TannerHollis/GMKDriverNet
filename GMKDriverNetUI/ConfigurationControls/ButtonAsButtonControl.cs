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
    public partial class ButtonAsButtonControl : UserControl
    {
        private ButtonAsButton _buttonAsButton;
        private TreeNode _node;
        private bool _initialized;

        public ButtonAsButtonControl()
        {
            InitializeComponent();
        }

        public void LoadWidget(TreeNode node)
        {
            _node = node;
            _buttonAsButton = (ButtonAsButton)_node.Tag;
            _initialized = false;
            inputButton.SelectedIndex = (int)_buttonAsButton.input;
            outputButton.SelectedIndex = (int)_buttonAsButton.output;
            this.Visible = true;
            _initialized = true;
        }

        private void valueChanged(object sender, EventArgs e)
        {
            if(_initialized)
            {
                _buttonAsButton.input = (ButtonIO)inputButton.SelectedIndex;
                _buttonAsButton.output = (ButtonIO)outputButton.SelectedIndex;
                _node.Text = _buttonAsButton.ToString();
            }
        }
    }
}
