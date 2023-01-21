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
    public partial class KeyboardControl : UserControl
    {
        private byte _key;
        private Delegate _updateForm;
        private bool _isInitialized;

        public byte Key { get { return _key; } }

        public KeyboardControl()
        {
            InitializeComponent();
        }

        public void LoadKey(byte asKey, Delegate updateForm)
        {
            _isInitialized = false;
            _key = asKey;
            key.Text = ((char)asKey).ToString();
            _updateForm = updateForm;
            _isInitialized = true;
        }

        private void key_TextChanged(object sender, EventArgs e)
        {
            if (_isInitialized)
            {
                _key = (byte)key.Text[0];
                _updateForm.DynamicInvoke();
            }
        }
    }
}
