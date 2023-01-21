using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GMKDriverNETUI
{
    public partial class ConfigName : Form
    {
        private string _name;
        private bool _makeDefault;
        public string ConfigurationName { get { return _name; } }
        public bool MakeDefault { get { return _makeDefault; } }
        public ConfigName()
        {
            InitializeComponent();
        }

        public void SetName(string text)
        {
            name.Text = text;
        }

        public void SetMakeDefault(bool isDefault)
        {
            makeDefault.Checked = isDefault;
        }

        public string RemoveInvalidChars(string filename)
        {
            return string.Join("", filename.Split(Path.GetInvalidFileNameChars()));
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            _name = name.Text;
            _makeDefault = makeDefault.Checked;

            if(GMKDriverNET.DeviceConfig.ConfigNameExists(_name))
            {
                DialogResult result = MessageBox.Show("There is already a configuration named: \"" + _name + "\", overwrite this configuration?", "Overwrite this configuration?", MessageBoxButtons.YesNo);   
                if(result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            name.Text = RemoveInvalidChars(name.Text);
            name.SelectionStart = name.Text.Length;
            name.SelectionLength = 0;
        }
    }
}
