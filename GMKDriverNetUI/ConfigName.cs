﻿using System;
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

        private void okButton_Click(object sender, EventArgs e)
        {
            _name = name.Text;
            _makeDefault = makeDefault.Checked;

            if(GMKDriverNET.DeviceConfig.ConfigNameExists(_name))
            {
                DialogResult result = MessageBox.Show("There is already a configuration named: \"" + _name + "\".", "Overwrite this configuration?", MessageBoxButtons.YesNo);   
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
    }
}