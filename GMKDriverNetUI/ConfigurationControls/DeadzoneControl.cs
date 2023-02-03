using GMKDriverNET;
using System;
using System.Windows.Forms;

namespace GMKDriverNETUI.ConfigurationControls
{
    public partial class DeadzoneControl : UserControl
    {
        private float _deadzone;
        private Delegate _updateForm;
        private bool _isInitialized;
        private bool _selecting;

        private float Granularity = 5.0f;

        public float Deadzone { get { return _deadzone; } }

        public DeadzoneControl()
        {
            InitializeComponent();
            UpdateTextWithLanguage();
        }

        private void UpdateTextWithLanguage()
        {
            resetToolStripMenuItem.Text = LanguageHelper.LookupPhrase("reset");
            snapToolStripMenuItem.Text = LanguageHelper.LookupPhrase("snap");
            offToolStripMenuItem.Text = LanguageHelper.LookupPhrase("off");
        }

        public void LoadDeadzone(float asDeadzone, Delegate updateForm)
        {
            _isInitialized = false;
            _deadzone = asDeadzone;
            UpdateDeadzone((int)(asDeadzone * 100.0f));
            _updateForm = updateForm;
            _isInitialized = true;
        }

        private void deadzone_ValueChanged(object sender, EventArgs e)
        {
            if (_isInitialized)
            {
                UpdateDeadzone(deadzone.Value);
                if (!_selecting)
                    _updateForm.DynamicInvoke();
            }
        }

        private void UpdateDeadzone(int value)
        {
            deadzone.Value = (int)(Math.Round((float)value / Granularity) * Granularity);
            _deadzone = (float)deadzone.Value / 100.0f;
            deadzoneValueLabel.Text = deadzone.Value.ToString() + " %";
        }

        private void deadzone_MouseDown(object sender, MouseEventArgs e)
        {
            _selecting = true;
        }

        private void deadzone_MouseUp(object sender, MouseEventArgs e)
        {
            _selecting = false;
            _updateForm.DynamicInvoke();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDeadzone(0);
        }

        private void SetGranularity(float granularity)
        {
            offToolStripMenuItem.Checked = false;
            toolStripMenuItem2.Checked = false;
            toolStripMenuItem3.Checked = false;
            toolStripMenuItem4.Checked = false;

            Granularity = (float)granularity;
            deadzone.TickFrequency = granularity == 1.0f ? 0 : (int)granularity;
        }

        private void offToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetGranularity(1);
            offToolStripMenuItem.Checked = true;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SetGranularity(2.5f);
            toolStripMenuItem3.Checked = true;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            SetGranularity(5.0f);
            toolStripMenuItem3.Checked = true;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            SetGranularity(10.0f);
            toolStripMenuItem4.Checked = true;
        }
    }
}
