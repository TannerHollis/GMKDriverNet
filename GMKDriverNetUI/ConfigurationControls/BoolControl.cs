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
    public partial class BoolControl : UserControl
    {
        private bool _bool;
        private Delegate _updateForm;
        private bool _isInitialized;

        public bool Bool { get { return _bool; } }

        public BoolControl()
        {
            InitializeComponent();
        }

        public void LoadBool(bool asBool, Delegate updateForm)
        {
            _isInitialized = false;
            _bool = asBool;
            checkBox.Checked = asBool;
            _updateForm = updateForm;
            _isInitialized = true;
        }

        private void button_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(_isInitialized)
            {
                _bool = checkBox.Checked;
                _updateForm.DynamicInvoke();
            }
        }
    }
}
