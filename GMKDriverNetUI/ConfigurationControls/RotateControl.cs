using GMKDriverNET;
using System;
using System.Windows.Forms;

namespace GMKDriverNETUI.ConfigurationControls
{
    public partial class RotateControl : UserControl
    {
        private float _rotate;
        private Delegate _updateForm;
        private bool _isInitialized;
        private bool _selecting;

        private float Granularity = 10.0f;

        public float Rotate { get { return _rotate; } }

        public RotateControl()
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
        public void LoadRotate(float asRotate, Delegate updateForm)
        {
            _isInitialized = false;
            _rotate = asRotate;
            UpdateRotate((int)asRotate);
            _updateForm = updateForm;
            _isInitialized = true;
        }

        private void UpdateRotate(int value)
        {
            rotate.Value = (int)(Math.Round((float)value / Granularity) * Granularity);
            _rotate = (float)rotate.Value;
            deadzoneValueLabel.Text = rotate.Value.ToString() + "°";
        }

        private void rotate_MouseDown(object sender, MouseEventArgs e)
        {
            _selecting = true;
        }

        private void rotate_MouseUp(object sender, MouseEventArgs e)
        {
            _selecting = false;
            _updateForm.DynamicInvoke();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateRotate(0);
        }


        private void rotate_ValueChanged(object sender, EventArgs e)
        {
            if (_isInitialized)
            {
                UpdateRotate(rotate.Value);
                if (!_selecting)
                    _updateForm.DynamicInvoke();
            }
        }

        private void SetGranularity(int granularity)
        {
            offToolStripMenuItem.Checked = false;
            toolStripMenuItem2.Checked = false;
            toolStripMenuItem3.Checked = false;
            toolStripMenuItem4.Checked = false;
            toolStripMenuItem6.Checked = false;

            Granularity = (float)granularity;
            rotate.TickFrequency = granularity == 1 ? 0 : (int)granularity;
        }

        private void offToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetGranularity(1);
            offToolStripMenuItem.Checked = true;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SetGranularity(5);
            toolStripMenuItem3.Checked = true;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            SetGranularity(10);
            toolStripMenuItem3.Checked = true;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            SetGranularity(15);
            toolStripMenuItem4.Checked = true;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            SetGranularity(30);
            toolStripMenuItem5.Checked = true;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            SetGranularity(90);
            toolStripMenuItem6.Checked = true;
        }
    }
}
