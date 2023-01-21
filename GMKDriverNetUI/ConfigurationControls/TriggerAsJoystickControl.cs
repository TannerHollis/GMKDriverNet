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
    public partial class TriggerAsJoystickControl : UserControl
    {
        private TriggerAsJoystick _triggerAsJoystick;
        private TreeNode _node;

        private bool _initialized;

        private delegate void OnUpdateForm();
        private OnUpdateForm _updateForm;

        public TriggerAsJoystickControl()
        {
            InitializeComponent();
            _updateForm = UpdateForm;
        }

        public void LoadWidget(TreeNode node)
        {
            _node = node;
            _triggerAsJoystick = (TriggerAsJoystick)_node.Tag;
            _initialized = false;

            inputTrigger.LoadTrigger(_triggerAsJoystick.input, _updateForm);
            outputJoystick.LoadJoystick(_triggerAsJoystick.output, _updateForm);
            outputAxis.LoadAxis(_triggerAsJoystick.outputAxis, _updateForm);
            linear.LoadBool(_triggerAsJoystick.linear, _updateForm);

            this.Visible = true;
            _initialized = true;
        }

        private void UpdateForm()
        {
            if (_initialized)
            {
                _triggerAsJoystick.input = inputTrigger.Trigger;
                _triggerAsJoystick.output = outputJoystick.Joystick;
                _triggerAsJoystick.outputAxis = outputAxis.Axis;
                _triggerAsJoystick.linear = linear.Bool;
                
                _node.Text = _triggerAsJoystick.ToString();
            }
        }
    }
}
