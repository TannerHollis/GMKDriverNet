using GMKDriverNET;
using GMKDriverNET.Bindings;
using OpenTKDisplay;
using OpenTKDisplay.DrawObjects;
using System;
using System.Windows.Forms;

namespace GMKDriverNETUI.ConfigurationControls
{
    public partial class JoystickAsJoystickControl : UserControl
    {
        private JoystickAsJoystick _joystickAsJoystick;
        private TreeNode _node;

        private bool _initialized;

        private delegate void OnUpdateForm();
        private OnUpdateForm _updateForm;

        private GLDisplay _joystickDisplay;
        private GMKDevice _gmkDevice;
        private DeviceConfig _config;

        public JoystickAsJoystickControl()
        {
            InitializeComponent();
            _updateForm = UpdateForm;
            UpdateTextWithLanguage();
            
            // Load Joystick viewer
            _joystickDisplay = new GLDisplay(this, "Joystick Display");
            joystickView.Controls.Add(_joystickDisplay);
        }

        ~JoystickAsJoystickControl()
        {
            timerJoystickUpdate.Stop();
            _joystickDisplay.GLControl_Unload();
            _joystickDisplay.Dispose();
        }

        private void UpdateTextWithLanguage()
        {
            inputJoystickLabel.Text = LanguageHelper.LookupPhrase("inputJoystick");
            outputJoystickLabel.Text = LanguageHelper.LookupPhrase("outputJoystick");
            rotateLabel.Text = LanguageHelper.LookupPhrase("rotate");
            deadzoneLabel.Text = LanguageHelper.LookupPhrase("deadzone");
            linearLabel.Text = LanguageHelper.LookupPhrase("linear");
            snap76Label.Text = LanguageHelper.LookupPhrase("snapMode");
            legendGroupBox.Text = LanguageHelper.LookupPhrase("legend");
            rawInputLabel.Text = LanguageHelper.LookupPhrase("rawInput");
            outputLabel.Text = LanguageHelper.LookupPhrase("Output");
        }

        public void LoadWidget(TreeNode node, DeviceConfig config, GMKDevice device)
        {
            _node = node;
            _joystickAsJoystick = (JoystickAsJoystick)_node.Tag;
            _gmkDevice = device;
            _config = config;
            _initialized = false;

            inputJoystick.LoadJoystick(_joystickAsJoystick.input, config.type, false, _updateForm);
            outputJoystick.LoadJoystick(_joystickAsJoystick.output, config.type, true, _updateForm);
            rotate.LoadRotate(_joystickAsJoystick.rotate, _updateForm);
            deadzone.LoadDeadzone(_joystickAsJoystick.deadzone, _updateForm);
            linear.LoadBool(_joystickAsJoystick.linear, _updateForm);
            snap76.LoadSnap76(_joystickAsJoystick.snapMode76, _joystickAsJoystick.snap76Intensity, _updateForm);

            // Start joystick update timer
            timerJoystickUpdate.Start();

            this.Visible = true;
            _initialized = true;
        }

        private void UpdateForm()
        {
            if (_initialized)
            {
                _joystickAsJoystick.input = inputJoystick.Joystick;
                _joystickAsJoystick.output = outputJoystick.Joystick;
                _joystickAsJoystick.rotate = rotate.Rotate;
                _joystickAsJoystick.deadzone = deadzone.Deadzone;
                _joystickAsJoystick.linear = linear.Bool;
                _joystickAsJoystick.snapMode76 = snap76.Bool;
                _joystickAsJoystick.snap76Intensity = snap76.Intensity;

                _node.Text = _joystickAsJoystick.ToString();
            }
        }

        private void DrawJoystick()
        {
            if (_gmkDevice == null)
                return;

            _joystickDisplay.ClearDrawObjects();
            Circle joystickOutline = new Circle(0.0f, 0.0f, 1.0f, OpenTKDisplay.Primitives.RGBColor.Black ,false);
            Line yAxis = new Line(0.0f, -1.0f, 0.0f, 1.0f, OpenTKDisplay.Primitives.RGBColor.Black);
            Line xAxis = new Line(-1.0f, 0.0f, 1.0f, 0.0f, OpenTKDisplay.Primitives.RGBColor.Black);

            XInputController beforeConfig = _gmkDevice.ControllerBefore;

            double xBefore = XInputController.GetPercentageInt16(beforeConfig.GetJoystick(inputJoystick.Joystick, Axis.XPositive));
            double yBefore = XInputController.GetPercentageInt16(beforeConfig.GetJoystick(inputJoystick.Joystick, Axis.YPositive));

            beforeConfig.MapToConfig(_config);

            double xAfter = XInputController.GetPercentageInt16(beforeConfig.GetJoystick(inputJoystick.Joystick, Axis.XPositive));
            double yAfter = XInputController.GetPercentageInt16(beforeConfig.GetJoystick(inputJoystick.Joystick, Axis.YNegative));

            Circle afterPosition = new Circle((float)xAfter, (float)yAfter, 0.075f, OpenTKDisplay.Primitives.RGBColor.Blue, true);
            StippledLine lineToAfter = new StippledLine(0.0f, 0.0f, (float)xAfter, (float)yAfter, 0.05f, 0.05f, OpenTKDisplay.Primitives.RGBColor.Blue);

            Circle deadzoneCircle = new Circle(0.0f, 0.0f, deadzone.Deadzone, OpenTKDisplay.Primitives.RGBColor.Red.Fade(0.5f), true);

            bool isDifferent = Math.Abs(xBefore - xAfter) > 0.05 || Math.Abs(yBefore - yAfter) > 0.05;

            if (isDifferent)
            {
                Circle beforePosition = new Circle((float)xBefore, (float)yBefore, 0.075f, OpenTKDisplay.Primitives.RGBColor.Green, true);
                StippledLine lineToBefore = new StippledLine(0.0f, 0.0f, (float)xBefore, (float)yBefore, 0.05f, 0.05f, OpenTKDisplay.Primitives.RGBColor.Green);
                _joystickDisplay.AddDrawObject(lineToBefore);
                _joystickDisplay.AddDrawObject(beforePosition);
            }

            _joystickDisplay.AddDrawObject(afterPosition);
            _joystickDisplay.AddDrawObject(lineToAfter);

            _joystickDisplay.AddDrawObject(yAxis);
            _joystickDisplay.AddDrawObject(xAxis);
            _joystickDisplay.AddDrawObject(joystickOutline);
            _joystickDisplay.AddDrawObject(deadzoneCircle);

            if(snap76.Bool)
            {
                OpenTKDisplay.Primitives.RGBColor snapColor = new OpenTKDisplay.Primitives.RGBColor(0.7f, 0.0f, 0.7f, 0.7f);
                float rightAngle = (90.0f - (float)snap76.Intensity) / 180.0f * (float)Math.PI;
                float leftAngle = (90.0f + (float)snap76.Intensity) / 180.0f * (float)Math.PI;
                Line snap76R1 = new Line(0.0f, 0.0f, (float)Math.Cos(rightAngle), (float)Math.Sin(rightAngle), snapColor);
                Line snap76R0 = new Line(0.0f, 0.0f, (float)Math.Cos(0.174533f), (float)Math.Sin(0.174533f), snapColor);
                Line snap76L1 = new Line(0.0f, 0.0f, (float)Math.Cos(leftAngle), (float)Math.Sin(leftAngle), snapColor);
                Line snap76L0 = new Line(0.0f, 0.0f, (float)Math.Cos(2.96706f), (float)Math.Sin(2.96706f), snapColor);
                _joystickDisplay.AddDrawObject(snap76R1);
                _joystickDisplay.AddDrawObject(snap76R0);
                _joystickDisplay.AddDrawObject(snap76L1);
                _joystickDisplay.AddDrawObject(snap76L0);
            }

            _joystickDisplay.ReDraw();
            Refresh();
        }

        private void timerJoystickUpdate_Tick(object sender, System.EventArgs e)
        {
            DrawJoystick();
        }

        private void JoystickAsJoystickControl_Load(object sender, System.EventArgs e)
        {
            
        }

        private void JoystickAsJoystickControl_VisibleChanged(object sender, System.EventArgs e)
        {
            if(Visible)
                timerJoystickUpdate.Start();
            else
                timerJoystickUpdate.Stop();
        }
    }
}
