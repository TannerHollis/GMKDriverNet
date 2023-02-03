using GMKDriverNET;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace GMKDriverNETUI.ConfigurationControls
{
    public partial class KeyboardControl : UserControl
    {
        private byte[] _key;
        private Delegate _updateForm;
        private bool _isInitialized;

        public byte[] Key { get { return _key; } }

        public KeyboardControl()
        {
            InitializeComponent();
            UpdateTextWithLanguage();
        }

        private void UpdateTextWithLanguage()
        {
            key1Label.Text = LanguageHelper.LookupPhrase("key1");
            key2Label.Text = LanguageHelper.LookupPhrase("key2");
            key3Label.Text = LanguageHelper.LookupPhrase("key3");
        }

        public void LoadKey(byte[] asKey, Delegate updateForm)
        {
            _isInitialized = false;
            _key = asKey;
            key1.Text = KeypressEmulator.ScanCodeToKey((KeypressEmulator.ScanCodeShort)_key[0]);
            key2.Text = KeypressEmulator.ScanCodeToKey((KeypressEmulator.ScanCodeShort)_key[1]);
            key3.Text = KeypressEmulator.ScanCodeToKey((KeypressEmulator.ScanCodeShort)_key[2]);
            _updateForm = updateForm;
            _isInitialized = true;
        }

        private void UpdateKeys()
        {
            if (_isInitialized)
            {
                _key[0] = (byte)KeypressEmulator.KeyToScanCode(key1.Text);
                _key[1] = (byte)KeypressEmulator.KeyToScanCode(key2.Text);
                _key[2] = (byte)KeypressEmulator.KeyToScanCode(key3.Text);
                _updateForm.DynamicInvoke();
            }
        }

        private void key1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateKeys();
        }

        private void key2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateKeys();
        }

        private void key3_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateKeys();
        }
    }
}
