namespace GMKDriverNETUI.ConfigurationControls
{
    partial class TriggerAsButtonControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.outputButtonLabel = new System.Windows.Forms.Label();
            this.inputTriggerLabel = new System.Windows.Forms.Label();
            this.thresholdLabel = new System.Windows.Forms.Label();
            this.inputTrigger = new GMKDriverNETUI.ConfigurationControls.TriggerControl();
            this.outputButton = new GMKDriverNETUI.ConfigurationControls.ButtonControl();
            this.deadzone = new GMKDriverNETUI.ConfigurationControls.DeadzoneControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.69799F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.30201F));
            this.tableLayoutPanel1.Controls.Add(this.outputButtonLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.inputTriggerLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.thresholdLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.inputTrigger, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.outputButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.deadzone, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(596, 283);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // outputButtonLabel
            // 
            this.outputButtonLabel.AutoSize = true;
            this.outputButtonLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputButtonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputButtonLabel.Location = new System.Drawing.Point(3, 94);
            this.outputButtonLabel.Name = "outputButtonLabel";
            this.outputButtonLabel.Size = new System.Drawing.Size(171, 94);
            this.outputButtonLabel.TabIndex = 1;
            this.outputButtonLabel.Text = "Output Button";
            this.outputButtonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inputTriggerLabel
            // 
            this.inputTriggerLabel.AutoSize = true;
            this.inputTriggerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputTriggerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTriggerLabel.Location = new System.Drawing.Point(3, 0);
            this.inputTriggerLabel.Name = "inputTriggerLabel";
            this.inputTriggerLabel.Size = new System.Drawing.Size(171, 94);
            this.inputTriggerLabel.TabIndex = 0;
            this.inputTriggerLabel.Text = "Input Trigger";
            this.inputTriggerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // thresholdLabel
            // 
            this.thresholdLabel.AutoSize = true;
            this.thresholdLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thresholdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thresholdLabel.Location = new System.Drawing.Point(3, 188);
            this.thresholdLabel.Name = "thresholdLabel";
            this.thresholdLabel.Size = new System.Drawing.Size(171, 95);
            this.thresholdLabel.TabIndex = 10;
            this.thresholdLabel.Text = "Deadzone";
            this.thresholdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inputTrigger
            // 
            this.inputTrigger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputTrigger.Location = new System.Drawing.Point(180, 3);
            this.inputTrigger.Name = "inputTrigger";
            this.inputTrigger.Size = new System.Drawing.Size(413, 88);
            this.inputTrigger.TabIndex = 11;
            // 
            // outputButton
            // 
            this.outputButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputButton.Location = new System.Drawing.Point(180, 97);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(413, 88);
            this.outputButton.TabIndex = 12;
            // 
            // deadzone
            // 
            this.deadzone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deadzone.Location = new System.Drawing.Point(180, 191);
            this.deadzone.Name = "deadzone";
            this.deadzone.Size = new System.Drawing.Size(413, 89);
            this.deadzone.TabIndex = 13;
            // 
            // TriggerAsButtonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TriggerAsButtonControl";
            this.Size = new System.Drawing.Size(596, 283);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label outputButtonLabel;
        private System.Windows.Forms.Label inputTriggerLabel;
        private System.Windows.Forms.Label thresholdLabel;
        private TriggerControl inputTrigger;
        private ButtonControl outputButton;
        private DeadzoneControl deadzone;
    }
}
