﻿using GMKDriverNET;
using GMKDriverNetUI;
using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace GMKDriverNETUI
{
    public partial class Main : Form
    {
        // DEBUG warning
        public bool _isDebugging = false;

        Thread _mainThread;
        bool _allowClosing = false;
        int _devicesConnected = 0;
        bool _viGEmInstalled;

        public static void ThreadProc(object consoleOutputObject)
        {
            TextBox consoleOutput = (TextBox)consoleOutputObject;
            GMKDriver.SetConsole(consoleOutput);
            GMKDriver.Loop();
        }

        public Main()
        {
            InitializeComponent();

            UpdateTextWithLanguage();

            if(GMKDriver.CanChangeRegistry())
            {
                bool isStartupApp = GMKDriver.IsStartupApp();

                removeFromStartupAppsToolStripMenuItem.Enabled = isStartupApp;
                setAsStartupAppToolStripMenuItem.Enabled = !isStartupApp;
            }
            else
            {
                removeFromStartupAppsToolStripMenuItem.Enabled = false;
                setAsStartupAppToolStripMenuItem.Enabled = false;
            }

            _viGEmInstalled = GMKDriver.CheckViGEmInstalled();

            CheckNewUpdate();

            if (!_viGEmInstalled && !_isDebugging)
            {
                consoleBox.AppendText(LanguageHelper.LookupPhrase("viGEmNotInstalled1") + "\r\n");
                consoleBox.AppendText(LanguageHelper.LookupPhrase("viGEmNotInstalled2") + "\r\n");
            }
            else
            {
                _mainThread = new Thread(new ParameterizedThreadStart(ThreadProc));
                _mainThread.Start(consoleBox);
                updateDeviceListTimer.Enabled = true;
                checkApplicationTimer.Enabled = true;
            }
        }

        private void CheckNewUpdate()
        {
            if(Settings.GetLastVersionRun() != GMKDriver.Version)
            {
                UpdateWindow updateWindow = new UpdateWindow();
                updateWindow.ShowDialog();
                Settings.SetLastVersionRun(GMKDriver.Version);
            }
        }

        private void ChangeLanguage(object sender, EventArgs e)
        {
            string newLanguage = (string)((ToolStripMenuItem)sender).Tag;
            UncheckLanguages();
            Settings.SetLanguage(newLanguage);
            UpdateTextWithLanguage();
        }

        private void UpdateTextWithLanguage()
        {
            this.Text = LanguageHelper.LookupPhrase("gmkDriver");
            settingsToolStripMenuItem.Text = LanguageHelper.LookupPhrase("settings");
            aboutToolStripMenuItem.Text = LanguageHelper.LookupPhrase("about");
            setAsStartupAppToolStripMenuItem.Text = LanguageHelper.LookupPhrase("setAsStartupApp");
            setAsStartupAppToolStripMenuItem.Text = LanguageHelper.LookupPhrase("removeFromStartupApps");
            languageToolStripMenuItem.Text = LanguageHelper.LookupPhrase("language");
            deviceGroupBox.Text = LanguageHelper.LookupPhrase("devices");
            editBindingsMenuItem.Text = LanguageHelper.LookupPhrase("editBindings");
            CheckLanguage(Settings.GetLanguage());
        }

        private void UncheckLanguages()
        {
            eNToolStripMenuItem.Checked = false;
            eSToolStripMenuItem.Checked = false;
            fRToolStripMenuItem.Checked = false;
            aRToolStripMenuItem.Checked = false;
            rUToolStripMenuItem.Checked = false;
            pTToolStripMenuItem.Checked = false;
            iDToolStripMenuItem.Checked = false;
            zHToolStripMenuItem.Checked = false;
            dEToolStripMenuItem.Checked = false;
            jAToolStripMenuItem.Checked = false;
            hIToolStripMenuItem.Checked = false;
            nLToolStripMenuItem.Checked = false;
        }

        private void CheckLanguage(string language)
        {
            switch (language)
            {
                case "EN":
                    eNToolStripMenuItem.Checked = true;
                    return;

                case "ES":
                    eSToolStripMenuItem.Checked = true;
                    return;

                case "FR":
                    fRToolStripMenuItem.Checked = true;
                    return;

                case "AR":
                    aRToolStripMenuItem.Checked = true;
                    return;

                case "RU":
                    rUToolStripMenuItem.Checked = true;
                    return;

                case "PT":
                    pTToolStripMenuItem.Checked = true;
                    return;

                case "ID":
                    iDToolStripMenuItem.Checked = true;
                    return;

                case "ZH":
                    zHToolStripMenuItem.Checked = true;
                    return;

                case "DE":
                    dEToolStripMenuItem.Checked = true;
                    return;

                case "JA":
                    jAToolStripMenuItem.Checked = true;
                    return;

                case "HI":
                    hIToolStripMenuItem.Checked = true;
                    return;

                case "NL":
                    nLToolStripMenuItem.Checked = true;
                    return;

                default:
                    return;
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.Hide();
                if (!_allowClosing)
                {
                    trayIcon.Visible = true;
                    e.Cancel = true;
                    trayIcon.ContextMenuStrip = trayContextMenuStrip;
                }
                else
                {
                    e.Cancel = false;
                    trayIcon.Visible = false;
                }
            }
        }

        private void Main_Exit(object sender, EventArgs e)
        {
            if (_viGEmInstalled)
            {
                checkApplicationTimer.Enabled = false;
                updateDeviceListTimer.Enabled = false;
                GMKDriver.Stop();
                _mainThread.Join();
            }
            _allowClosing = true;
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            trayIcon.Visible = false;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main_Exit(sender, e);
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            if (_devicesConnected != GMKDriver.GMKDevices.Length)
            {
                deviceView.Items.Clear();
                foreach (GMKDevice device in GMKDriver.GMKDevices)
                {
                    ListViewItem item = new ListViewItem(device.Type + " - " + device.SerialNumber, 0);
                    item.Tag = device;
                    item.ImageIndex = 0;
                    deviceView.Items.Add(item);
                }
                _devicesConnected = GMKDriver.GMKDevices.Length;
            }
        }

        private void editBindingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GMKDevice selectedDevice = (GMKDevice)deviceView.SelectedItems[0].Tag;
            configurationEditor editor = new configurationEditor(selectedDevice);
            editor.ShowDialog();
        }

        private void deviceViewContextMenu_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = deviceView.SelectedItems.Count == 0;

            if (deviceView.SelectedItems.Count > 0)
            {
                GMKDevice selectedDevice = (GMKDevice)deviceView.SelectedItems[0].Tag;
                if (selectedDevice.IsPaused)
                {
                    deviceViewContextMenu.Items["pauseDriverMenuItem"].Text = LanguageHelper.LookupPhrase("resumeDriver");
                }
                else
                {
                    deviceViewContextMenu.Items["pauseDriverMenuItem"].Text = LanguageHelper.LookupPhrase("pauseDriver");
                }
            }
        }

        private void pauseDriverMenuItem_Click(object sender, EventArgs e)
        {
            GMKDevice selectedDevice = (GMKDevice)deviceView.SelectedItems[0].Tag;
            if (selectedDevice.IsPaused)
            {
                selectedDevice.Resume();
            }
            else
            {
                selectedDevice.Pause();
            }
        }

        private void setAsStartupAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GMKDriver.MakeStartupApp();
            setAsStartupAppToolStripMenuItem.Enabled = false;
            removeFromStartupAppsToolStripMenuItem.Enabled = true;
        }

        private void removeFromStartupAppsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GMKDriver.RemoveStartupApp();
            removeFromStartupAppsToolStripMenuItem.Enabled = false;
            setAsStartupAppToolStripMenuItem.Enabled = true;
        }

        private void checkApplicationTimer_Tick(object sender, EventArgs e)
        {
            GMKDriver.CheckActiveWindowAndChangeConfiguration();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutWindow about = new AboutWindow();
            about.SetVersion(GMKDriver.Version);
            about.ShowDialog();
        }

        private void deviceView_DoubleClick(object sender, EventArgs e)
        {
            if (deviceView.SelectedItems.Count > 0)
            {
                GMKDevice selectedDevice = (GMKDevice)deviceView.SelectedItems[0].Tag;
                configurationEditor editor = new configurationEditor(selectedDevice);
                editor.ShowDialog();
            }
        }
    }
}
