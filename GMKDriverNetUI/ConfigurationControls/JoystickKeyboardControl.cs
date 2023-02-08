using GMKDriverNET;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace GMKDriverNETUI.ConfigurationControls
{
    public partial class JoystickKeyboardControl : UserControl
    {
        private byte[] _key;
        private Delegate _updateForm;
        private bool _isInitialized;

        public byte[] Key { get { return _key; } }

        public JoystickKeyboardControl()
        {
            InitializeComponent();
            UpdateTextWithLanguage();
        }

        private void UpdateTextWithLanguage()
        {
            leftKeyLabel.Text = LanguageHelper.LookupPhrase("left");
            upKeyLabel.Text = LanguageHelper.LookupPhrase("up");
            rightKeyLabel.Text = LanguageHelper.LookupPhrase("right");
            downKeyLabel.Text = LanguageHelper.LookupPhrase("down");
        }

        public void LoadKey(byte[] asKey, Delegate updateForm)
        {
            _isInitialized = false;
            _key = asKey;
            leftKey.Text = KeypressEmulator.ScanCodeToKey((KeypressEmulator.ScanCodeShort)_key[0]);
            upKey.Text = KeypressEmulator.ScanCodeToKey((KeypressEmulator.ScanCodeShort)_key[1]);
            rightKey.Text = KeypressEmulator.ScanCodeToKey((KeypressEmulator.ScanCodeShort)_key[2]);
            downKey.Text = KeypressEmulator.ScanCodeToKey((KeypressEmulator.ScanCodeShort)_key[3]);
            _updateForm = updateForm;
            _isInitialized = true;
        }

        private void UpdateKeys()
        {
            if (_isInitialized)
            {
                _key[0] = (byte)KeypressEmulator.KeyToScanCode(leftKey.Text);
                _key[1] = (byte)KeypressEmulator.KeyToScanCode(upKey.Text);
                _key[2] = (byte)KeypressEmulator.KeyToScanCode(rightKey.Text);
                _key[3] = (byte)KeypressEmulator.KeyToScanCode(downKey.Text);
                _updateForm.DynamicInvoke();
            }
        }

        private void KeyChanged(object sender, EventArgs e)
        {
            UpdateKeys();
        }
    }
}
