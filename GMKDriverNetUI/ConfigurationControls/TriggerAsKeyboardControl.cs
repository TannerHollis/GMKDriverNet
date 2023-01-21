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
    public partial class TriggerAsKeyboardControl : UserControl
    {
        private TriggerAsKeyboard _triggerAsKeyboard;
        private TreeNode _node;

        private bool _initialized;

        private delegate void OnUpdateForm();
        private OnUpdateForm _updateForm;

        public TriggerAsKeyboardControl()
        {
            InitializeComponent();
            _updateForm = UpdateForm;
        }

        public void LoadWidget(TreeNode node)
        {
            _node = node;
            _triggerAsKeyboard = (TriggerAsKeyboard)_node.Tag;
            _initialized = false;

            inputTrigger.LoadTrigger(_triggerAsKeyboard.input, _updateForm);
            key.LoadKey(_triggerAsKeyboard.key, _updateForm);
            deadzone.LoadDeadzone(_triggerAsKeyboard.threshold, _updateForm);

            this.Visible = true;
            _initialized = true;
        }

        private void UpdateForm()
        {
            if (_initialized)
            {
                _triggerAsKeyboard.input = inputTrigger.Trigger;
                _triggerAsKeyboard.key = key.Key;
                _triggerAsKeyboard.threshold = deadzone.Deadzone;

                _node.Text = _triggerAsKeyboard.ToString();
            }
        }
    }
}
