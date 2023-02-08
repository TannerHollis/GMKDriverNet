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

namespace GMKDriverNetUI
{
    public partial class UpdateWindow : Form
    {
        public UpdateWindow()
        {
            InitializeComponent();
            UpdateTextWithLanguage();
        }

        public void UpdateTextWithLanguage()
        {
            this.Text = LanguageHelper.LookupPhrase("update");
            gmkUpdated.Text = LanguageHelper.LookupPhrase("gmkUpdated");
            string newVersion = string.Format(LanguageHelper.LookupPhrase("newVersion"), GMKDriver.Version);
            string oldVersion = string.Format(LanguageHelper.LookupPhrase("oldVersion"), Settings.GetLastVersionRun());
            newVersionLabel.Text = newVersion;
            oldVersionLabel.Text = oldVersion;
            offsetLink.Text = LanguageHelper.LookupPhrase("offsetLink");
            okButton.Text = LanguageHelper.LookupPhrase("ok");
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void offsetLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://offset-power.net/");
        }
    }
}
