using GMKDriverNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace GMKDriverNetUI.ConfigurationControls
{
    public partial class JoystickAsKeyboardControl : UserControl
    {
        private JoystickAsKeyboard _joystickAsKeyboard;
        private TreeNode _node;

        private bool _initialized;

        private delegate void OnUpdateForm();
        private OnUpdateForm _updateForm;

        public JoystickAsKeyboardControl()
        {
            InitializeComponent();
            _updateForm = UpdateForm;
        }

        public void LoadWidget(TreeNode node)
        {
            _node = node;
            _joystickAsKeyboard = (JoystickAsKeyboard)_node.Tag;
            _initialized = false;

            inputJoystick.LoadJoystick(_joystickAsKeyboard.input, _updateForm);
            inputAxis.LoadAxis(_joystickAsKeyboard.inputAxis, _updateForm);
            key.LoadKey(_joystickAsKeyboard.key, _updateForm);
            deadzone.LoadDeadzone(_joystickAsKeyboard.threshold, _updateForm);

            this.Visible = true;
            _initialized = true;
        }

        private void UpdateForm()
        {
            if (!_initialized)
            {
                _joystickAsKeyboard.input = inputJoystick.Joystick;
                _joystickAsKeyboard.inputAxis = inputAxis.Axis;
                _joystickAsKeyboard.key = key.Key;
                _joystickAsKeyboard.threshold = deadzone.Deadzone;

                _node.Text = _joystickAsKeyboard.ToString();
            }
        }
    }
}
