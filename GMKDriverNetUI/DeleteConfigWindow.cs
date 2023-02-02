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

namespace GMKDriverNETUI
{
    public partial class DeleteConfigWindow : Form
    {
        public DeleteConfigWindow()
        {
            InitializeComponent();
            UpdateTextWithLanguage();
        }

        public void UpdateTextWithLanguage()
        {
            this.Text = LanguageHelper.LookupPhrase("delete");
            deleteConfigLabel.Text = LanguageHelper.LookupPhrase("deleteConfig");
            noButton.Text = LanguageHelper.LookupPhrase("no");
            yesButton.Text = LanguageHelper.LookupPhrase("yes");
            cancelButton.Text = LanguageHelper.LookupPhrase("cancel");
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
