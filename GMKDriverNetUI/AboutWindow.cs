using System.Windows.Forms;

namespace GMKDriverNETUI
{
    public partial class AboutWindow : Form
    {
        public AboutWindow()
        {
            InitializeComponent();

            UpdateTextWithLanguage();
        }

        public void UpdateTextWithLanguage()
        {
            this.Text = GMKDriverNET.LanguageHelper.LookupPhrase("about");
            this.versionLabel.Text = GMKDriverNET.LanguageHelper.LookupPhrase("version");
            this.supportLabel.Text = GMKDriverNET.LanguageHelper.LookupPhrase("version");
            this.gmkWebsiteLabel.Text = GMKDriverNET.LanguageHelper.LookupPhrase("gmkWebsite");
        }

        public void SetVersion(string text)
        {
            version.Text = text;
        }

        private void gmkDiscordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://discordapp.com/invite/Uar5Qyj");
        }

        private void gmkWebsiteLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.gamingmodkits.com/contact-us");
        }
    }
}
