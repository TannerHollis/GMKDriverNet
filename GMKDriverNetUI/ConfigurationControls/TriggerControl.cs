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
    public partial class TriggerControl : UserControl
    {
        private TriggerIO _trigger;
        private Delegate _updateForm;
        private bool _isInitialized;

        public TriggerIO Trigger { get { return _trigger; } }

        public TriggerControl()
        {
            InitializeComponent();
        }

        public void LoadTrigger(TriggerIO asTrigger, Delegate updateForm)
        {
            _isInitialized = false;
            _trigger = asTrigger;
            trigger.SelectedIndex = (int)asTrigger;
            _updateForm = updateForm;
            _isInitialized = true;
        }

        private void button_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(_isInitialized)
            {
                _trigger = (TriggerIO)trigger.SelectedIndex;
                _updateForm.DynamicInvoke();
            }
        }
    }
}
