using GMKDriverNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMKDriverNetUI
{
    public partial class Main : Form
    {
        Thread mainThread;
        bool allowClosing = false;
        int devicesConnected = 0;
        bool viGEmInstalled;

        public static void ThreadProc(object consoleOutputObject)
        {
            TextBox consoleOutput = (TextBox)consoleOutputObject;
            GMKDriver.SetConsole(consoleOutput);
            GMKDriver.Loop();
        }

        public Main()
        {
            InitializeComponent();

            bool isStartupApp = GMKDriver.IsStartupApp();

            removeFromStartupAppsToolStripMenuItem.Enabled = isStartupApp;
            setAsStartupAppToolStripMenuItem.Enabled = !isStartupApp;

            viGEmInstalled = GMKDriver.CheckViGEmInstalled();

            if (!viGEmInstalled)
            {
                consoleBox.AppendText("Could not find ViGEm Bus Driver Installed on this computer\r\n");
                consoleBox.AppendText("Please download the latest release from: https://github.com/ViGEm/ViGEmBus/releases\r\n");
            }
            else
            {
                mainThread = new Thread(new ParameterizedThreadStart(ThreadProc));
                mainThread.Start(consoleBox);
                updateDeviceListTimer.Enabled = true;
                checkApplicationTimer.Enabled = true;
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {   
                this.Hide();
                if(!allowClosing)
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
            if(viGEmInstalled)
            {
                GMKDriver.Stop();
                mainThread.Join();
            }
            allowClosing = true;
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
            if(devicesConnected != GMKDriver.Devices.Length)
            {
                deviceView.Items.Clear();
                foreach (GMKDevice device in GMKDriver.Devices)
                {
                    ListViewItem item = new ListViewItem(device.Type + " - " + device.SerialNumber, 0);
                    item.Tag = device;
                    item.ImageIndex = 0;
                    deviceView.Items.Add(item);
                }
                devicesConnected = GMKDriver.Devices.Length;
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

            if(deviceView.SelectedItems.Count > 0)
            {
                GMKDevice selectedDevice = (GMKDevice)deviceView.SelectedItems[0].Tag;
                if(selectedDevice.IsPaused)
                {
                    deviceViewContextMenu.Items["pauseDriverMenuItem"].Text = "Resume Driver";
                }
                else
                {
                    deviceViewContextMenu.Items["pauseDriverMenuItem"].Text = "Pause Driver";
                }
            }
        }

        private void pauseDriverMenuItem_Click(object sender, EventArgs e)
        {
            GMKDevice selectedDevice = (GMKDevice)deviceView.SelectedItems[0].Tag;
            if(selectedDevice.IsPaused)
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
    }
}
