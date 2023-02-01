namespace GMKDriverNETUI
{
    partial class DeleteConfigWindow
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.noButton = new System.Windows.Forms.Button();
            this.yesButton = new System.Windows.Forms.Button();
            this.deleteConfigLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.cancelButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.deleteConfigLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.yesButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.noButton, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.45872F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.54128F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(296, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // noButton
            // 
            this.noButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.noButton.Location = new System.Drawing.Point(109, 63);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(75, 23);
            this.noButton.TabIndex = 0;
            this.noButton.Text = "No";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // yesButton
            // 
            this.yesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yesButton.Location = new System.Drawing.Point(208, 63);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(75, 23);
            this.yesButton.TabIndex = 1;
            this.yesButton.Text = "Yes";
            this.yesButton.UseVisualStyleBackColor = true;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // deleteConfigLabel
            // 
            this.deleteConfigLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteConfigLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.deleteConfigLabel, 3);
            this.deleteConfigLabel.Location = new System.Drawing.Point(48, 18);
            this.deleteConfigLabel.Name = "deleteConfigLabel";
            this.deleteConfigLabel.Size = new System.Drawing.Size(200, 13);
            this.deleteConfigLabel.TabIndex = 2;
            this.deleteConfigLabel.Text = "Delete this configuration from hard drive?";
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelButton.Location = new System.Drawing.Point(11, 63);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // DeleteConfigWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 100);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DeleteConfigWindow";
            this.Text = "Delete";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Label deleteConfigLabel;
        private System.Windows.Forms.Button cancelButton;
    }
}