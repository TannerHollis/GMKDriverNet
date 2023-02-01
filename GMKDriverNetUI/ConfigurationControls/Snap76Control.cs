using GMKDriverNET;
using System;
using System.Windows.Forms;

namespace GMKDriverNETUI.ConfigurationControls
{
    public partial class Snap76Control : UserControl
    {
        private bool _bool;
        private int _intensity;
        private Delegate _updateForm;
        private bool _isInitialized;

        public bool Bool { get { return _bool; } }
        public int Intensity { get { return _intensity; } }

        public Snap76Control()
        {
            InitializeComponent();
            UpdateTextWithLanguage();
        }

        private void UpdateTextWithLanguage()
        {
            snap76IntensityLabel.Text = LanguageHelper.LookupPhrase("snapIntensity");

            snap76Intensity.Items.Clear();
            snap76Intensity.Items.Add(LanguageHelper.LookupPhrase("extremeTight"));
            snap76Intensity.Items.Add(LanguageHelper.LookupPhrase("tight"));
            snap76Intensity.Items.Add(LanguageHelper.LookupPhrase("medium"));
            snap76Intensity.Items.Add(LanguageHelper.LookupPhrase("loose"));
            snap76Intensity.Items.Add(LanguageHelper.LookupPhrase("veryLoose"));
        }

        public void LoadSnap76(bool asBool, int intensity, Delegate updateForm)
        {
            _isInitialized = false;

            _bool = asBool;
            
            checkBox.Checked = asBool;
            snap76Intensity.SelectedIndex = GetIntensity(intensity);
            snap76Intensity.Enabled = _bool;
            _updateForm = updateForm;
            
            _isInitialized = true;
        }

        public int GetIntensity(int intensity)
        {
            switch(intensity)
            {
                case 20:
                    return 0;

                case 30:
                    return 1;

                case 40:
                    return 2;

                case 50:
                    return 3;

                case 60:
                    return 4;

                default:
                    return 0;
            }
        }

        public int SetIntensity(int intensity)
        {
            switch (intensity)
            {
                case 0:
                    return 20;

                case 1:
                    return 30;

                case 2:
                    return 40;

                case 3:
                    return 50;

                case 4:
                    return 60;

                default:
                    return 0;
            }
        }

        private void bool_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(_isInitialized)
            {
                _bool = checkBox.Checked;
                snap76Intensity.Enabled = _bool;
                _intensity = SetIntensity(snap76Intensity.SelectedIndex);
                _updateForm.DynamicInvoke();
            }
        }
    }
}
