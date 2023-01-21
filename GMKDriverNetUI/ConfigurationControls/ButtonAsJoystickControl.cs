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
    public partial class ButtonAsJoystickControl : UserControl
    {
        private ButtonAsJoystick _buttonAsJoystick;
        private TreeNode _node;
        
        private bool _initialized;

        private delegate void OnUpdateForm();
        private OnUpdateForm _updateForm;

        public ButtonAsJoystickControl()
        {
            InitializeComponent();
            _updateForm = UpdateForm;
        }

        public void LoadWidget(TreeNode node)
        {
            _node = node;
            _buttonAsJoystick = (ButtonAsJoystick)_node.Tag;
            _initialized = false;

            inputButton.LoadButton(_buttonAsJoystick.input, _updateForm);
            outputJoystick.LoadJoystick(_buttonAsJoystick.output, _updateForm);
            outputAxis.LoadAxis(_buttonAsJoystick.outputAxis, _updateForm);
            
            this.Visible = true;
            _initialized = true;
        }

        private void UpdateForm()
        {
            if (_initialized)
            {
                _buttonAsJoystick.input = inputButton.Button;
                _buttonAsJoystick.output = outputJoystick.Joystick;
                _buttonAsJoystick.outputAxis = outputAxis.Axis;

                _node.Text = _buttonAsJoystick.ToString();
            }
        }
    }
}
