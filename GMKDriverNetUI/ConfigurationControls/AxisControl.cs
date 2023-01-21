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
    public partial class AxisControl : UserControl
    {
        private Axis _axis;
        private Delegate _updateForm;
        private bool _isInitialized;

        public Axis Axis { get { return _axis; } }

        public AxisControl()
        {
            InitializeComponent();
        }

        public void LoadAxis(Axis asAxis, Delegate updateForm)
        {
            _isInitialized = false;
            _axis = asAxis;
            axis.SelectedIndex = (int)asAxis;
            _updateForm = updateForm;
            _isInitialized = true;
        }

        private void button_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(_isInitialized)
            {
                _axis = (Axis)axis.SelectedIndex;
                _updateForm.DynamicInvoke();
            }
        }
    }
}
