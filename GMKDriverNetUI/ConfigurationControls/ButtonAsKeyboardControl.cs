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
    public partial class ButtonAsKeyboardControl : UserControl
    {
        private ButtonAsKeyboard _buttonAsKeyboard;
        private TreeNode _node;
        private bool _initialized;

        public ButtonAsKeyboardControl()
        {
            InitializeComponent();
        }

        public void LoadWidget(TreeNode node)
        {
            _node = node;
            _buttonAsKeyboard = (ButtonAsKeyboard)_node.Tag;
            _initialized = false;
            inputButton.SelectedIndex = (int)_buttonAsKeyboard.input;
            outputKey.Text = ((char)_buttonAsKeyboard.key).ToString();
            this.Visible = true;
            _initialized = true;
        }

        private void valueChanged(object sender, EventArgs e)
        {
            if(_initialized)
            {
                _buttonAsKeyboard.input = (ButtonIO)inputButton.SelectedIndex;
                _buttonAsKeyboard.key = (byte)outputKey.Text.ToCharArray()[0];
                _node.Text = _buttonAsKeyboard.ToString();
            }
        }
    }
}
