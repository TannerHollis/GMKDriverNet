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

        private delegate void OnUpdateForm();
        private OnUpdateForm _updateForm;

        public ButtonAsKeyboardControl()
        {
            InitializeComponent();
            _updateForm = UpdateForm;
        }

        public void LoadWidget(TreeNode node)
        {
            _node = node;
            _buttonAsKeyboard = (ButtonAsKeyboard)_node.Tag;
            _initialized = false;

            inputButton.LoadButton(_buttonAsKeyboard.input, _updateForm);
            key.LoadKey(_buttonAsKeyboard.key, _updateForm);
            
            this.Visible = true;
            _initialized = true;
        }

        private void UpdateForm()
        {
            if (_initialized)
            {
                _buttonAsKeyboard.input = inputButton.Button;
                _buttonAsKeyboard.key = key.Key;

                _node.Text = _buttonAsKeyboard.ToString();
            }
        }
    }
}
