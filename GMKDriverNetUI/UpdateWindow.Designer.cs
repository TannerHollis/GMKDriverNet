namespace GMKDriverNetUI
{
    partial class UpdateWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateWindow));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.oldVersionLabel = new System.Windows.Forms.Label();
            this.newVersionLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.offsetLink = new System.Windows.Forms.LinkLabel();
            this.gmkUpdated = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.oldVersionLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.newVersionLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.okButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.offsetLink, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.gmkUpdated, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(388, 149);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // oldVersionLabel
            // 
            this.oldVersionLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.oldVersionLabel, 2);
            this.oldVersionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oldVersionLabel.Location = new System.Drawing.Point(3, 58);
            this.oldVersionLabel.Name = "oldVersionLabel";
            this.oldVersionLabel.Size = new System.Drawing.Size(382, 29);
            this.oldVersionLabel.TabIndex = 1;
            this.oldVersionLabel.Text = "Old Version: v0.0";
            this.oldVersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newVersionLabel
            // 
            this.newVersionLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.newVersionLabel, 2);
            this.newVersionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newVersionLabel.Location = new System.Drawing.Point(3, 29);
            this.newVersionLabel.Name = "newVersionLabel";
            this.newVersionLabel.Size = new System.Drawing.Size(382, 29);
            this.newVersionLabel.TabIndex = 0;
            this.newVersionLabel.Text = "New Version: v0.1";
            this.newVersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // okButton
            // 
            this.okButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.okButton, 2);
            this.okButton.Location = new System.Drawing.Point(156, 121);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // offsetLink
            // 
            this.offsetLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.offsetLink.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.offsetLink, 2);
            this.offsetLink.Location = new System.Drawing.Point(57, 95);
            this.offsetLink.Name = "offsetLink";
            this.offsetLink.Size = new System.Drawing.Size(274, 13);
            this.offsetLink.TabIndex = 3;
            this.offsetLink.TabStop = true;
            this.offsetLink.Text = "Be sure to visit http://offset-power.net/ for update notes.";
            this.offsetLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.offsetLink_LinkClicked);
            // 
            // gmkUpdated
            // 
            this.gmkUpdated.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gmkUpdated.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.gmkUpdated, 2);
            this.gmkUpdated.Location = new System.Drawing.Point(117, 8);
            this.gmkUpdated.Name = "gmkUpdated";
            this.gmkUpdated.Size = new System.Drawing.Size(154, 13);
            this.gmkUpdated.TabIndex = 4;
            this.gmkUpdated.Text = "GMK Driver has been updated!";
            // 
            // UpdateWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 149);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label oldVersionLabel;
        private System.Windows.Forms.Label newVersionLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.LinkLabel offsetLink;
        private System.Windows.Forms.Label gmkUpdated;
    }
}