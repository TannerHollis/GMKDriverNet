using GMKDriverNET;
using System;
using System.Windows.Forms;

namespace GMKDriverNETUI
{
    public partial class ErrorWindow : Form
    {
        public ErrorWindow(string errorMessage)
        {
            InitializeComponent();
            UpdateTextWithLanguage(errorMessage);
        }

        public void UpdateTextWithLanguage(string message)
        {
            this.Text = LanguageHelper.LookupPhrase("error");
            errorLabel.Text = message;
            okButton.Text = LanguageHelper.LookupPhrase("ok");
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
