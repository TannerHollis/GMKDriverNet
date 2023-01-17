namespace GMKDriverNetUI.ConfigurationControls
{
    partial class TriggerAsKeyboardControl
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
            this.thresholdLabel = new System.Windows.Forms.Label();
            this.outputKeyLabel = new System.Windows.Forms.Label();
            this.inputTriggerLabel = new System.Windows.Forms.Label();
            this.inputTrigger = new System.Windows.Forms.ComboBox();
            this.outputKey = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.thresholdSlider = new System.Windows.Forms.TrackBar();
            this.thresholdValueLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.69799F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.30201F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.outputKey, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.thresholdLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.outputKeyLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.inputTriggerLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.inputTrigger, 1, 0);
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
            // thresholdLabel
            // 
            this.thresholdLabel.AutoSize = true;
            this.thresholdLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thresholdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thresholdLabel.Location = new System.Drawing.Point(3, 188);
            this.thresholdLabel.Name = "thresholdLabel";
            this.thresholdLabel.Size = new System.Drawing.Size(171, 95);
            this.thresholdLabel.TabIndex = 14;
            this.thresholdLabel.Text = "Threshold";
            this.thresholdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // outputKeyLabel
            // 
            this.outputKeyLabel.AutoSize = true;
            this.outputKeyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputKeyLabel.Location = new System.Drawing.Point(3, 94);
            this.outputKeyLabel.Name = "outputKeyLabel";
            this.outputKeyLabel.Size = new System.Drawing.Size(171, 94);
            this.outputKeyLabel.TabIndex = 1;
            this.outputKeyLabel.Text = "Key";
            this.outputKeyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // inputTrigger
            // 
            this.inputTrigger.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.inputTrigger.FormattingEnabled = true;
            this.inputTrigger.Items.AddRange(new object[] {
            "Left",
            "Right"});
            this.inputTrigger.Location = new System.Drawing.Point(180, 36);
            this.inputTrigger.MaxDropDownItems = 20;
            this.inputTrigger.Name = "inputTrigger";
            this.inputTrigger.Size = new System.Drawing.Size(121, 21);
            this.inputTrigger.TabIndex = 2;
            this.inputTrigger.SelectedIndexChanged += new System.EventHandler(this.valueChanged);
            this.inputTrigger.SelectedValueChanged += new System.EventHandler(this.valueChanged);
            // 
            // outputKey
            // 
            this.outputKey.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.outputKey.Location = new System.Drawing.Point(180, 131);
            this.outputKey.MaxLength = 1;
            this.outputKey.Name = "outputKey";
            this.outputKey.Size = new System.Drawing.Size(121, 20);
            this.outputKey.TabIndex = 15;
            this.outputKey.TextChanged += new System.EventHandler(this.valueChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.thresholdSlider, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.thresholdValueLabel, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(180, 191);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(413, 89);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // thresholdSlider
            // 
            this.thresholdSlider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.thresholdSlider.Location = new System.Drawing.Point(3, 22);
            this.thresholdSlider.Maximum = 100;
            this.thresholdSlider.Name = "thresholdSlider";
            this.thresholdSlider.Size = new System.Drawing.Size(303, 45);
            this.thresholdSlider.TabIndex = 0;
            this.thresholdSlider.TickFrequency = 5;
            this.thresholdSlider.ValueChanged += new System.EventHandler(this.valueChanged);
            this.thresholdSlider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.thresholdSlider_MouseDown);
            this.thresholdSlider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.thresholdSlider_MouseUp);
            // 
            // thresholdValueLabel
            // 
            this.thresholdValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.thresholdValueLabel.AutoSize = true;
            this.thresholdValueLabel.Location = new System.Drawing.Point(312, 38);
            this.thresholdValueLabel.Name = "thresholdValueLabel";
            this.thresholdValueLabel.Size = new System.Drawing.Size(15, 13);
            this.thresholdValueLabel.TabIndex = 1;
            this.thresholdValueLabel.Text = "%";
            this.thresholdValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TriggerAsKeyboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TriggerAsKeyboardControl";
            this.Size = new System.Drawing.Size(596, 283);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdSlider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label outputKeyLabel;
        private System.Windows.Forms.Label inputTriggerLabel;
        private System.Windows.Forms.ComboBox inputTrigger;
        private System.Windows.Forms.Label thresholdLabel;
        private System.Windows.Forms.TextBox outputKey;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TrackBar thresholdSlider;
        private System.Windows.Forms.Label thresholdValueLabel;
    }
}
