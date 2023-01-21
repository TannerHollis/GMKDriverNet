namespace GMKDriverNetUI
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.consoleBox = new System.Windows.Forms.TextBox();
            this.deviceView = new System.Windows.Forms.ListView();
            this.deviceViewContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editBindingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseDriverMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.trayContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDeviceListTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.deviceGroupBox = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setAsStartupAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeFromStartupAppsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkApplicationTimer = new System.Windows.Forms.Timer(this.components);
            this.deviceViewContextMenu.SuspendLayout();
            this.trayContextMenuStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.deviceGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trayIcon
            // 
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "GMK Driver";
            this.trayIcon.Visible = true;
            // 
            // consoleBox
            // 
            this.consoleBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.tableLayoutPanel1.SetColumnSpan(this.consoleBox, 2);
            this.consoleBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consoleBox.ForeColor = System.Drawing.SystemColors.Window;
            this.consoleBox.Location = new System.Drawing.Point(3, 194);
            this.consoleBox.Multiline = true;
            this.consoleBox.Name = "consoleBox";
            this.consoleBox.ReadOnly = true;
            this.consoleBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.consoleBox.Size = new System.Drawing.Size(630, 161);
            this.consoleBox.TabIndex = 0;
            // 
            // deviceView
            // 
            this.deviceView.ContextMenuStrip = this.deviceViewContextMenu;
            this.deviceView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deviceView.HideSelection = false;
            this.deviceView.LargeImageList = this.imageList;
            this.deviceView.Location = new System.Drawing.Point(3, 16);
            this.deviceView.MultiSelect = false;
            this.deviceView.Name = "deviceView";
            this.deviceView.Size = new System.Drawing.Size(624, 141);
            this.deviceView.TabIndex = 0;
            this.deviceView.TileSize = new System.Drawing.Size(64, 64);
            this.deviceView.UseCompatibleStateImageBehavior = false;
            // 
            // deviceViewContextMenu
            // 
            this.deviceViewContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editBindingsMenuItem,
            this.pauseDriverMenuItem});
            this.deviceViewContextMenu.Name = "deviceViewContextMenu";
            this.deviceViewContextMenu.Size = new System.Drawing.Size(153, 48);
            this.deviceViewContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.deviceViewContextMenu_Opening);
            // 
            // editBindingsMenuItem
            // 
            this.editBindingsMenuItem.Name = "editBindingsMenuItem";
            this.editBindingsMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editBindingsMenuItem.Text = "Edit Bindings...";
            this.editBindingsMenuItem.Click += new System.EventHandler(this.editBindingsToolStripMenuItem_Click);
            // 
            // pauseDriverMenuItem
            // 
            this.pauseDriverMenuItem.Name = "pauseDriverMenuItem";
            this.pauseDriverMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pauseDriverMenuItem.Text = "Pause Driver";
            this.pauseDriverMenuItem.Click += new System.EventHandler(this.pauseDriverMenuItem_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "icon.png");
            this.imageList.Images.SetKeyName(1, "GMKlogo_transparent_square.ico");
            // 
            // trayContextMenuStrip
            // 
            this.trayContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.trayContextMenuStrip.Name = "trayContextMenuStrip";
            this.trayContextMenuStrip.Size = new System.Drawing.Size(113, 48);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // updateDeviceListTimer
            // 
            this.updateDeviceListTimer.Interval = 500;
            this.updateDeviceListTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.consoleBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.deviceGroupBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(636, 358);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // deviceGroupBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.deviceGroupBox, 2);
            this.deviceGroupBox.Controls.Add(this.deviceView);
            this.deviceGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deviceGroupBox.Location = new System.Drawing.Point(3, 28);
            this.deviceGroupBox.Name = "deviceGroupBox";
            this.deviceGroupBox.Size = new System.Drawing.Size(630, 160);
            this.deviceGroupBox.TabIndex = 1;
            this.deviceGroupBox.TabStop = false;
            this.deviceGroupBox.Text = "Devices";
            // 
            // menuStrip1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.menuStrip1, 2);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(636, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setAsStartupAppToolStripMenuItem,
            this.removeFromStartupAppsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // setAsStartupAppToolStripMenuItem
            // 
            this.setAsStartupAppToolStripMenuItem.Name = "setAsStartupAppToolStripMenuItem";
            this.setAsStartupAppToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.setAsStartupAppToolStripMenuItem.Text = "Set as Startup App";
            this.setAsStartupAppToolStripMenuItem.Click += new System.EventHandler(this.setAsStartupAppToolStripMenuItem_Click);
            // 
            // removeFromStartupAppsToolStripMenuItem
            // 
            this.removeFromStartupAppsToolStripMenuItem.Name = "removeFromStartupAppsToolStripMenuItem";
            this.removeFromStartupAppsToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.removeFromStartupAppsToolStripMenuItem.Text = "Remove from Startup Apps";
            this.removeFromStartupAppsToolStripMenuItem.Click += new System.EventHandler(this.removeFromStartupAppsToolStripMenuItem_Click);
            // 
            // checkApplicationTimer
            // 
            this.checkApplicationTimer.Interval = 2500;
            this.checkApplicationTimer.Tick += new System.EventHandler(this.checkApplicationTimer_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 358);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "GMK Driver";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.deviceViewContextMenu.ResumeLayout(false);
            this.trayContextMenuStrip.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.deviceGroupBox.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.TextBox consoleBox;
        private System.Windows.Forms.ListView deviceView;
        private System.Windows.Forms.ContextMenuStrip trayContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Timer updateDeviceListTimer;
        private System.Windows.Forms.ContextMenuStrip deviceViewContextMenu;
        private System.Windows.Forms.ToolStripMenuItem editBindingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseDriverMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox deviceGroupBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setAsStartupAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeFromStartupAppsToolStripMenuItem;
        private System.Windows.Forms.Timer checkApplicationTimer;
    }
}

