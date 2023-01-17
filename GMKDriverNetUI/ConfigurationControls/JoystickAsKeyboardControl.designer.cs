namespace GMKDriverNetUI.ConfigurationControls
{
    partial class JoystickAsKeyboardControl
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
            this.outputKey = new System.Windows.Forms.TextBox();
            this.inputAxis = new System.Windows.Forms.ComboBox();
            this.inputAxisLabel = new System.Windows.Forms.Label();
            this.inputButtonLabel = new System.Windows.Forms.Label();
            this.inputJoystick = new System.Windows.Forms.ComboBox();
            this.keyLabel = new System.Windows.Forms.Label();
            this.thresholdLabel = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel1.Controls.Add(this.outputKey, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.inputAxis, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.inputAxisLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.inputButtonLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.inputJoystick, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.keyLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.thresholdLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(596, 283);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // outputKey
            // 
            this.outputKey.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.outputKey.Location = new System.Drawing.Point(180, 165);
            this.outputKey.MaxLength = 1;
            this.outputKey.Name = "outputKey";
            this.outputKey.Size = new System.Drawing.Size(121, 20);
            this.outputKey.TabIndex = 12;
            this.outputKey.TextChanged += new System.EventHandler(this.valueChanged);
            // 
            // inputAxis
            // 
            this.inputAxis.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.inputAxis.FormattingEnabled = true;
            this.inputAxis.Items.AddRange(new object[] {
            "X+",
            "X-",
            "Y+",
            "Y-"});
            this.inputAxis.Location = new System.Drawing.Point(180, 94);
            this.inputAxis.MaxDropDownItems = 20;
            this.inputAxis.Name = "inputAxis";
            this.inputAxis.Size = new System.Drawing.Size(121, 21);
            this.inputAxis.TabIndex = 3;
            this.inputAxis.SelectedIndexChanged += new System.EventHandler(this.valueChanged);
            this.inputAxis.SelectedValueChanged += new System.EventHandler(this.valueChanged);
            // 
            // inputAxisLabel
            // 
            this.inputAxisLabel.AutoSize = true;
            this.inputAxisLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputAxisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputAxisLabel.Location = new System.Drawing.Point(3, 70);
            this.inputAxisLabel.Name = "inputAxisLabel";
            this.inputAxisLabel.Size = new System.Drawing.Size(171, 70);
            this.inputAxisLabel.TabIndex = 1;
            this.inputAxisLabel.Text = "Input Axis";
            this.inputAxisLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inputButtonLabel
            // 
            this.inputButtonLabel.AutoSize = true;
            this.inputButtonLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputButtonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputButtonLabel.Location = new System.Drawing.Point(3, 0);
            this.inputButtonLabel.Name = "inputButtonLabel";
            this.inputButtonLabel.Size = new System.Drawing.Size(171, 70);
            this.inputButtonLabel.TabIndex = 0;
            this.inputButtonLabel.Text = "Input Joystick";
            this.inputButtonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inputJoystick
            // 
            this.inputJoystick.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.inputJoystick.FormattingEnabled = true;
            this.inputJoystick.Items.AddRange(new object[] {
            "Left",
            "Right"});
            this.inputJoystick.Location = new System.Drawing.Point(180, 24);
            this.inputJoystick.MaxDropDownItems = 20;
            this.inputJoystick.Name = "inputJoystick";
            this.inputJoystick.Size = new System.Drawing.Size(121, 21);
            this.inputJoystick.TabIndex = 2;
            this.inputJoystick.SelectedIndexChanged += new System.EventHandler(this.valueChanged);
            this.inputJoystick.SelectedValueChanged += new System.EventHandler(this.valueChanged);
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyLabel.Location = new System.Drawing.Point(3, 140);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(171, 70);
            this.keyLabel.TabIndex = 4;
            this.keyLabel.Text = "Output Key";
            this.keyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // thresholdLabel
            // 
            this.thresholdLabel.AutoSize = true;
            this.thresholdLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thresholdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thresholdLabel.Location = new System.Drawing.Point(3, 210);
            this.thresholdLabel.Name = "thresholdLabel";
            this.thresholdLabel.Size = new System.Drawing.Size(171, 73);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(180, 213);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(413, 67);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // thresholdSlider
            // 
            this.thresholdSlider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.thresholdSlider.Location = new System.Drawing.Point(3, 11);
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
            this.thresholdValueLabel.Location = new System.Drawing.Point(312, 27);
            this.thresholdValueLabel.Name = "thresholdValueLabel";
            this.thresholdValueLabel.Size = new System.Drawing.Size(15, 13);
            this.thresholdValueLabel.TabIndex = 1;
            this.thresholdValueLabel.Text = "%";
            this.thresholdValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // JoystickAsKeyboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "JoystickAsKeyboardControl";
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
        private System.Windows.Forms.Label inputAxisLabel;
        private System.Windows.Forms.Label inputButtonLabel;
        private System.Windows.Forms.ComboBox inputAxis;
        private System.Windows.Forms.ComboBox inputJoystick;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.Label thresholdLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TrackBar thresholdSlider;
        private System.Windows.Forms.Label thresholdValueLabel;
        private System.Windows.Forms.TextBox outputKey;
    }
}
