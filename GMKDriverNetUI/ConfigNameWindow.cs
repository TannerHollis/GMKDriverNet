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
    public partial class ConfigNameWindow : Form
    {
        private string _name;
        private bool _makeDefault;
        public string ConfigurationName { get { return _name; } }
        public bool MakeDefault { get { return _makeDefault; } }
        public ConfigNameWindow()
        {
            InitializeComponent();
        }

        public void LoadWindow(string name, bool makeDefault)
        {
            _name = name;
            _makeDefault = makeDefault;
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
                DialogResult = _name != string.Empty ? DialogResult.OK : DialogResult.Cancel;
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
