using GMKDriverNET;
using System;
using System.IO;
using System.Windows.Forms;

namespace GMKDriverNETUI
{
    public partial class ConfigNameWindow : Form
    {
        private string _name;
        private bool _makeDefault;
        private bool _isInitialized;
        public string ConfigurationName { get { return _name; } }
        public bool MakeDefault { get { return _makeDefault; } }
        public ConfigNameWindow()
        {
            InitializeComponent();
            UpdateTextWithLanguage();
        }

        private void UpdateTextWithLanguage()
        {
            this.Text = LanguageHelper.LookupPhrase("configName");
            nameLabel.Text = LanguageHelper.LookupPhrase("configName");
            okButton.Text = LanguageHelper.LookupPhrase("ok");
            cancelButton.Text = LanguageHelper.LookupPhrase("cancel");
            makeDefaultLabel.Text = LanguageHelper.LookupPhrase("makeDefault");
        }

        public void LoadWindow(string name, bool makeDefault)
        {
            _isInitialized = false;
            
            _name = name;
            this.name.Text = _name;
            _makeDefault = makeDefault;
            
            _isInitialized = true;
        }

        public string RemoveInvalidChars(string filename)
        {
            return string.Join("", filename.Split(Path.GetInvalidFileNameChars()));
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            _name = name.Text;
            _makeDefault = makeDefault.Checked;

            if (DeviceConfig.ConfigNameExists(_name))
            {
                string errorString = string.Format(LanguageHelper.LookupPhrase("configNameAlreadyFound"), _name);
                ErrorWindow errorWindow = new ErrorWindow(errorString);
                errorWindow.ShowDialog();
            }
            else
            {
                DialogResult = _name != string.Empty ? DialogResult.OK : DialogResult.Cancel;
                this.Close();
            }
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            if(_isInitialized)
            {
                name.Text = RemoveInvalidChars(name.Text);
                name.SelectionStart = name.Text.Length;
                name.SelectionLength = 0;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
