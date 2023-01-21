using GMKDriverNET;
using System;
using System.Windows.Forms;

namespace GMKDriverNETUI.ConfigurationControls
{
    public partial class TriggerControl : UserControl
    {
        private string[] joystickInputTriggers = {  };
        private string[] controllerInputTriggers = { "Left Joystick", "Right Joystick" };
        private string[] outputTriggers = { "Left Joystick", "Right Joystick" };

        private TriggerIO _trigger;
        private Delegate _updateForm;
        private bool _isInitialized;

        public TriggerIO Trigger { get { return _trigger; } }

        public TriggerControl()
        {
            InitializeComponent();
        }

        public void LoadTrigger(TriggerIO asTrigger, GMKControllerType type, bool isOutput, Delegate updateForm)
        {
            _isInitialized = false;

            trigger.Items.Clear();
            if (isOutput)
            {
                trigger.Items.AddRange(outputTriggers);
            }
            else if (type == GMKControllerType.Joystick)
            {
                trigger.Items.AddRange(joystickInputTriggers);
            }
            else if (type == GMKControllerType.Controller)
            {
                trigger.Items.AddRange(controllerInputTriggers);
            }

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
