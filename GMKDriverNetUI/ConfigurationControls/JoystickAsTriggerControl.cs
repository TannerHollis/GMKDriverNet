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
    public partial class JoystickAsTriggerControl : UserControl
    {
        private JoystickAsTrigger _joystickAsKeyboard;
        private TreeNode _node;
        
        private bool _initialized;

        private delegate void OnUpdateForm();
        private OnUpdateForm _updateForm;

        public JoystickAsTriggerControl()
        {
            InitializeComponent();
            _updateForm = UpdateForm;
        }

        public void LoadWidget(TreeNode node)
        {
            _node = node;
            _joystickAsKeyboard = (JoystickAsTrigger)_node.Tag;
            _initialized = false;

            inputJoystick.LoadJoystick(_joystickAsKeyboard.input, _updateForm);
            inputAxis.LoadAxis(_joystickAsKeyboard.inputAxis, _updateForm);
            outputTrigger.LoadTrigger(_joystickAsKeyboard.output, _updateForm);
            deadzone.LoadDeadzone(_joystickAsKeyboard.threshold, _updateForm);
            linear.LoadBool(_joystickAsKeyboard.linear, _updateForm);

            this.Visible = true;
            _initialized = true;
        }

        private void UpdateForm()
        {
            if (_initialized)
            {
                _joystickAsKeyboard.input = inputJoystick.Joystick;
                _joystickAsKeyboard.inputAxis = inputAxis.Axis;
                _joystickAsKeyboard.output = outputTrigger.Trigger;
                _joystickAsKeyboard.threshold = deadzone.Deadzone;
                _joystickAsKeyboard.linear = linear.Bool;

                _node.Text = _joystickAsKeyboard.ToString();
            }
        }
    }
}
