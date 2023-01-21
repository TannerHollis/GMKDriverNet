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
    public partial class JoystickAsButtonControl : UserControl
    {
        private JoystickAsButton _joystickAsButton;
        private TreeNode _node;
        
        private bool _initialized;

        private delegate void OnUpdateForm();
        private OnUpdateForm _updateForm;

        public JoystickAsButtonControl()
        {
            InitializeComponent();
            _updateForm = UpdateForm;
        }

        public void LoadWidget(TreeNode node)
        {
            _node = node;
            _joystickAsButton = (JoystickAsButton)_node.Tag;
            _initialized = false;

            inputJoystick.LoadJoystick(_joystickAsButton.input, _updateForm);
            inputAxis.LoadAxis(_joystickAsButton.inputAxis, _updateForm);
            outputButton.LoadButton(_joystickAsButton.output, _updateForm);
            deadzone.LoadDeadzone(_joystickAsButton.threshold, _updateForm);
            
            this.Visible = true;
            _initialized = true;
        }

        private void UpdateForm()
        {
            if (_initialized)
            {
                _joystickAsButton.input = inputJoystick.Joystick;
                _joystickAsButton.inputAxis = inputAxis.Axis;
                _joystickAsButton.output = outputButton.Button;
                _joystickAsButton.threshold = deadzone.Deadzone;

                _node.Text = _joystickAsButton.ToString();
            }
        }
    }
}
