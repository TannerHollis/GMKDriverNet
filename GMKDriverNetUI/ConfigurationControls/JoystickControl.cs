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
    public partial class JoystickControl : UserControl
    {
        private JoystickIO _joystick;
        private Delegate _updateForm;
        private bool _isInitialized;

        public JoystickIO Joystick { get { return _joystick; } }

        public JoystickControl()
        {
            InitializeComponent();
        }

        public void LoadJoystick(JoystickIO asJoystick, Delegate updateForm)
        {
            _isInitialized = false;
            _joystick = asJoystick;
            joystick.SelectedIndex = (int)asJoystick;
            _updateForm = updateForm;
            _isInitialized = true;
        }

        private void joystick_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isInitialized)
            {
                _joystick = (JoystickIO)joystick.SelectedIndex;
                _updateForm.DynamicInvoke();
            }
        }
    }
}
