namespace GMKDriverNetUI.ConfigurationControls
{
    partial class TriggerAsJoystickControl
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
            this.outputJoystick = new System.Windows.Forms.ComboBox();
            this.outputJoystickLabel = new System.Windows.Forms.Label();
            this.inputTriggerLabel = new System.Windows.Forms.Label();
            this.inputTrigger = new System.Windows.Forms.ComboBox();
            this.thresholdLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.thresholdSlider = new System.Windows.Forms.TrackBar();
            this.thresholdValueLabel = new System.Windows.Forms.Label();
            this.outputAxisLabel = new System.Windows.Forms.Label();
            this.outputAxis = new System.Windows.Forms.ComboBox();
            this.linearLabel = new System.Windows.Forms.Label();
            this.linear = new System.Windows.Forms.CheckBox();
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
            this.tableLayoutPanel1.Controls.Add(this.linearLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.outputAxis, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.outputAxisLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.outputJoystick, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.outputJoystickLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.inputTriggerLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.inputTrigger, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.thresholdLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.linear, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(596, 283);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // outputJoystick
            // 
            this.outputJoystick.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.outputJoystick.FormattingEnabled = true;
            this.outputJoystick.Items.AddRange(new object[] {
            "Left",
            "Right"});
            this.outputJoystick.Location = new System.Drawing.Point(180, 73);
            this.outputJoystick.MaxDropDownItems = 20;
            this.outputJoystick.Name = "outputJoystick";
            this.outputJoystick.Size = new System.Drawing.Size(121, 21);
            this.outputJoystick.TabIndex = 3;
            this.outputJoystick.SelectedIndexChanged += new System.EventHandler(this.valueChanged);
            this.outputJoystick.SelectedValueChanged += new System.EventHandler(this.valueChanged);
            // 
            // outputJoystickLabel
            // 
            this.outputJoystickLabel.AutoSize = true;
            this.outputJoystickLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputJoystickLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputJoystickLabel.Location = new System.Drawing.Point(3, 56);
            this.outputJoystickLabel.Name = "outputJoystickLabel";
            this.outputJoystickLabel.Size = new System.Drawing.Size(171, 56);
            this.outputJoystickLabel.TabIndex = 1;
            this.outputJoystickLabel.Text = "Output Joystick";
            this.outputJoystickLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inputTriggerLabel
            // 
            this.inputTriggerLabel.AutoSize = true;
            this.inputTriggerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputTriggerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTriggerLabel.Location = new System.Drawing.Point(3, 0);
            this.inputTriggerLabel.Name = "inputTriggerLabel";
            this.inputTriggerLabel.Size = new System.Drawing.Size(171, 56);
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
            this.inputTrigger.Location = new System.Drawing.Point(180, 17);
            this.inputTrigger.MaxDropDownItems = 20;
            this.inputTrigger.Name = "inputTrigger";
            this.inputTrigger.Size = new System.Drawing.Size(121, 21);
            this.inputTrigger.TabIndex = 2;
            this.inputTrigger.SelectedIndexChanged += new System.EventHandler(this.valueChanged);
            this.inputTrigger.SelectedValueChanged += new System.EventHandler(this.valueChanged);
            // 
            // thresholdLabel
            // 
            this.thresholdLabel.AutoSize = true;
            this.thresholdLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thresholdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thresholdLabel.Location = new System.Drawing.Point(3, 168);
            this.thresholdLabel.Name = "thresholdLabel";
            this.thresholdLabel.Size = new System.Drawing.Size(171, 56);
            this.thresholdLabel.TabIndex = 10;
            this.thresholdLabel.Text = "Threshold";
            this.thresholdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.thresholdSlider, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.thresholdValueLabel, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(180, 171);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(413, 50);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // thresholdSlider
            // 
            this.thresholdSlider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.thresholdSlider.Location = new System.Drawing.Point(3, 3);
            this.thresholdSlider.Maximum = 100;
            this.thresholdSlider.Name = "thresholdSlider";
            this.thresholdSlider.Size = new System.Drawing.Size(303, 44);
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
            this.thresholdValueLabel.Location = new System.Drawing.Point(312, 18);
            this.thresholdValueLabel.Name = "thresholdValueLabel";
            this.thresholdValueLabel.Size = new System.Drawing.Size(15, 13);
            this.thresholdValueLabel.TabIndex = 1;
            this.thresholdValueLabel.Text = "%";
            this.thresholdValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // outputAxisLabel
            // 
            this.outputAxisLabel.AutoSize = true;
            this.outputAxisLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputAxisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputAxisLabel.Location = new System.Drawing.Point(3, 112);
            this.outputAxisLabel.Name = "outputAxisLabel";
            this.outputAxisLabel.Size = new System.Drawing.Size(171, 56);
            this.outputAxisLabel.TabIndex = 12;
            this.outputAxisLabel.Text = "Output Axis";
            this.outputAxisLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // outputAxis
            // 
            this.outputAxis.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.outputAxis.FormattingEnabled = true;
            this.outputAxis.Items.AddRange(new object[] {
            "X+",
            "X-",
            "Y+",
            "Y-"});
            this.outputAxis.Location = new System.Drawing.Point(180, 129);
            this.outputAxis.MaxDropDownItems = 20;
            this.outputAxis.Name = "outputAxis";
            this.outputAxis.Size = new System.Drawing.Size(121, 21);
            this.outputAxis.TabIndex = 13;
            this.outputAxis.SelectedIndexChanged += new System.EventHandler(this.valueChanged);
            // 
            // linearLabel
            // 
            this.linearLabel.AutoSize = true;
            this.linearLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linearLabel.Location = new System.Drawing.Point(3, 224);
            this.linearLabel.Name = "linearLabel";
            this.linearLabel.Size = new System.Drawing.Size(171, 59);
            this.linearLabel.TabIndex = 14;
            this.linearLabel.Text = "Linear";
            this.linearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // linear
            // 
            this.linear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.linear.AutoSize = true;
            this.linear.Location = new System.Drawing.Point(180, 246);
            this.linear.Name = "linear";
            this.linear.Size = new System.Drawing.Size(15, 14);
            this.linear.TabIndex = 15;
            this.linear.UseVisualStyleBackColor = true;
            this.linear.CheckStateChanged += new System.EventHandler(this.valueChanged);
            // 
            // TriggerAsJoystickControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TriggerAsJoystickControl";
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
        private System.Windows.Forms.Label outputJoystickLabel;
        private System.Windows.Forms.Label inputTriggerLabel;
        private System.Windows.Forms.ComboBox outputJoystick;
        private System.Windows.Forms.ComboBox inputTrigger;
        private System.Windows.Forms.Label thresholdLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TrackBar thresholdSlider;
        private System.Windows.Forms.Label thresholdValueLabel;
        private System.Windows.Forms.ComboBox outputAxis;
        private System.Windows.Forms.Label outputAxisLabel;
        private System.Windows.Forms.Label linearLabel;
        private System.Windows.Forms.CheckBox linear;
    }
}
