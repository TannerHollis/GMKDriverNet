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
    public partial class OverwriteConfigWindow : Form
    {
        public OverwriteConfigWindow()
        {
            InitializeComponent();
            UpdateTextWithLanguage();
        }

        public void UpdateTextWithLanguage()
        {
            this.Text = LanguageHelper.LookupPhrase("overwrite");
            overwriteLabel.Text = LanguageHelper.LookupPhrase("overwriteConfig");
            noButton.Text = LanguageHelper.LookupPhrase("no");
            yesButton.Text = LanguageHelper.LookupPhrase("yes");
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
    }
}
