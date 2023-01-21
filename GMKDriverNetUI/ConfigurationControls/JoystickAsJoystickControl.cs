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
    public partial class JoystickAsJoystickControl : UserControl
    {
        private JoystickAsJoystick _joystickAsJoystick;
        private TreeNode _node;
        
        private bool _initialized;

        private delegate void OnUpdateForm();
        private OnUpdateForm _updateForm;

        public JoystickAsJoystickControl()
        {
            InitializeComponent();
            _updateForm = UpdateForm;
        }

        public void LoadWidget(TreeNode node)
        {
            _node = node;
            _joystickAsJoystick = (JoystickAsJoystick)_node.Tag;
            _initialized = false;

            inputJoystick.LoadJoystick(_joystickAsJoystick.input, _updateForm);
            outputJoystick.LoadJoystick(_joystickAsJoystick.output, _updateForm);
            rotate.LoadRotate(_joystickAsJoystick.rotate, _updateForm);
            deadzone.LoadDeadzone(_joystickAsJoystick.threshold, _updateForm);
            linear.LoadBool(_joystickAsJoystick.linear, _updateForm);
            snap76.LoadBool(_joystickAsJoystick.snapMode76, _updateForm);

            this.Visible = true;
            _initialized = true;
        }

        private void UpdateForm()
        {
            if(!_initialized)
            {
                _joystickAsJoystick.input = inputJoystick.Joystick;
                _joystickAsJoystick.output = outputJoystick.Joystick;
                _joystickAsJoystick.rotate = rotate.Rotate;
                _joystickAsJoystick.threshold = deadzone.Deadzone;
                _joystickAsJoystick.linear = linear.Bool;
                _joystickAsJoystick.snapMode76 = snap76.Bool;

                _node.Text = _joystickAsJoystick.ToString();
            }
        }
    }
}
