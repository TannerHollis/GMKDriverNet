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
        private ButtonAsTrigger _buttonAsTrigger;
        private TreeNode _node;
        
        private bool _initialized;

        private delegate void OnUpdateForm();
        private OnUpdateForm _updateForm;

        public ButtonAsTriggerControl()
        {
            InitializeComponent();
            _updateForm = UpdateForm;
        }

        public void LoadWidget(TreeNode node)
        {
            _node = node;
            _buttonAsTrigger = (ButtonAsTrigger)_node.Tag;
            _initialized = false;

            inputButton.LoadButton(_buttonAsTrigger.input, _updateForm);
            outputTrigger.LoadTrigger(_buttonAsTrigger.output, _updateForm);
            
            this.Visible = true;
            _initialized = true;
        }

        private void UpdateForm()
        {
            if (_initialized)
            {
                _buttonAsTrigger.input = inputButton.Button;
                _buttonAsTrigger.output = outputTrigger.Trigger;

                _node.Text = _buttonAsTrigger.ToString();
            }
        }
    }
}
