using GMKDriverNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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

        private delegate void OnUpdateForm();
        private OnUpdateForm _updateForm;

        public ButtonAsButtonControl()
        {
            InitializeComponent();
            _updateForm = UpdateForm;
        }

        public void LoadWidget(TreeNode node)
        {
            _node = node;
            _buttonAsButton = (ButtonAsButton)_node.Tag;
            _initialized = false;

            inputButton.LoadButton(_buttonAsButton.input, _updateForm);
            outputButton.LoadButton(_buttonAsButton.output, _updateForm);
            
            this.Visible = true;
            _initialized = true;
        }

        private void UpdateForm()
        {
            if (_initialized)
            {
                _buttonAsButton.input = inputButton.Button;
                _buttonAsButton.output = outputButton.Button;

                _node.Text = _buttonAsButton.ToString();
            }
        }
    }
}
