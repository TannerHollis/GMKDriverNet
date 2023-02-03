using System;
using System.Windows.Forms;

namespace GMKDriverNETUI.ConfigurationControls
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

        private void bool_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isInitialized)
            {
                _bool = checkBox.Checked;
                _updateForm.DynamicInvoke();
            }
        }
    }
}
