namespace GMKDriverNETUI
{
    partial class AboutWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutWindow));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gmkDriverLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.supportLabel = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.gmkDiscordLink = new System.Windows.Forms.LinkLabel();
            this.gmkWebsiteLabel = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.gmkDriverLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.versionLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.supportLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.version, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.gmkDiscordLink, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.gmkWebsiteLabel, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(313, 110);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gmkDriverLabel
            // 
            this.gmkDriverLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.gmkDriverLabel, 3);
            this.gmkDriverLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gmkDriverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gmkDriverLabel.Location = new System.Drawing.Point(3, 0);
            this.gmkDriverLabel.Name = "gmkDriverLabel";
            this.gmkDriverLabel.Size = new System.Drawing.Size(307, 34);
            this.gmkDriverLabel.TabIndex = 0;
            this.gmkDriverLabel.Text = "Gaming Mod Kits Joystick/Controller Driver";
            this.gmkDriverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.versionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.Location = new System.Drawing.Point(3, 34);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(98, 34);
            this.versionLabel.TabIndex = 1;
            this.versionLabel.Text = "Version:";
            this.versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // supportLabel
            // 
            this.supportLabel.AutoSize = true;
            this.supportLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supportLabel.Location = new System.Drawing.Point(3, 68);
            this.supportLabel.Name = "supportLabel";
            this.supportLabel.Size = new System.Drawing.Size(98, 42);
            this.supportLabel.TabIndex = 2;
            this.supportLabel.Text = "Support:";
            this.supportLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Dock = System.Windows.Forms.DockStyle.Fill;
            this.version.Location = new System.Drawing.Point(107, 34);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(98, 34);
            this.version.TabIndex = 3;
            this.version.Text = "v0.0.0";
            this.version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gmkDiscordLink
            // 
            this.gmkDiscordLink.AutoSize = true;
            this.gmkDiscordLink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gmkDiscordLink.Location = new System.Drawing.Point(107, 68);
            this.gmkDiscordLink.Name = "gmkDiscordLink";
            this.gmkDiscordLink.Size = new System.Drawing.Size(98, 42);
            this.gmkDiscordLink.TabIndex = 4;
            this.gmkDiscordLink.TabStop = true;
            this.gmkDiscordLink.Text = "GMK Discord";
            this.gmkDiscordLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gmkDiscordLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gmkDiscordLink_LinkClicked);
            // 
            // gmkWebsiteLabel
            // 
            this.gmkWebsiteLabel.AutoSize = true;
            this.gmkWebsiteLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gmkWebsiteLabel.Location = new System.Drawing.Point(211, 68);
            this.gmkWebsiteLabel.Name = "gmkWebsiteLabel";
            this.gmkWebsiteLabel.Size = new System.Drawing.Size(99, 42);
            this.gmkWebsiteLabel.TabIndex = 5;
            this.gmkWebsiteLabel.TabStop = true;
            this.gmkWebsiteLabel.Text = "GMK Website";
            this.gmkWebsiteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gmkWebsiteLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gmkWebsiteLabel_LinkClicked);
            // 
            // AboutWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 110);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label gmkDriverLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label supportLabel;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.LinkLabel gmkDiscordLink;
        private System.Windows.Forms.LinkLabel gmkWebsiteLabel;
    }
}