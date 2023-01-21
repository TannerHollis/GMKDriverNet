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

using GMKDriverNET;

namespace GMKDriverNetUI.ConfigurationControls
{
    public partial class ButtonControl : UserControl
    {
        private ButtonIO _button;
        private Delegate _updateForm;
        private bool _isInitialized;

        public ButtonIO Button { get { return _button; } }

        public ButtonControl()
        {
            InitializeComponent();
        }

        public void LoadButton(ButtonIO asButton, Delegate updateForm)
        {
            _isInitialized = false;
            _button = asButton;
            button.SelectedIndex = (int)asButton;
            _updateForm = updateForm;
            _isInitialized = true;
        }

        private void button_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(_isInitialized)
            {
                _button = (ButtonIO)button.SelectedIndex;
                _updateForm.DynamicInvoke();
            }
        }
    }
}
