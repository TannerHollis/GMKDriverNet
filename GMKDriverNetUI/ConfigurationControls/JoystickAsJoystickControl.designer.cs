namespace GMKDriverNetUI.ConfigurationControls
{
    partial class JoystickAsJoystickControl
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.thresholdValueLabel = new System.Windows.Forms.Label();
            this.thresholdSlider = new System.Windows.Forms.TrackBar();
            this.linearLabel = new System.Windows.Forms.Label();
            this.outputJoystick = new System.Windows.Forms.ComboBox();
            this.outputJoystickLabel = new System.Windows.Forms.Label();
            this.inputButtonLabel = new System.Windows.Forms.Label();
            this.inputJoystick = new System.Windows.Forms.ComboBox();
            this.rotate = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.rotateValueLabel = new System.Windows.Forms.Label();
            this.rotateSlider = new System.Windows.Forms.TrackBar();
            this.linear = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.snapMode76 = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdSlider)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotateSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.69799F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.30201F));
            this.tableLayoutPanel1.Controls.Add(this.snapMode76, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.thresholdLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.linearLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.outputJoystick, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.outputJoystickLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.inputButtonLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.inputJoystick, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.rotate, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.linear, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(596, 283);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // thresholdLabel
            // 
            this.thresholdLabel.AutoSize = true;
            this.thresholdLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thresholdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thresholdLabel.Location = new System.Drawing.Point(3, 141);
            this.thresholdLabel.Name = "thresholdLabel";
            this.thresholdLabel.Size = new System.Drawing.Size(171, 47);
            this.thresholdLabel.TabIndex = 10;
            this.thresholdLabel.Text = "Deadzone";
            this.thresholdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.thresholdValueLabel, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.thresholdSlider, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(180, 144);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(413, 41);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // thresholdValueLabel
            // 
            this.thresholdValueLabel.AutoSize = true;
            this.thresholdValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thresholdValueLabel.Location = new System.Drawing.Point(312, 0);
            this.thresholdValueLabel.Name = "thresholdValueLabel";
            this.thresholdValueLabel.Size = new System.Drawing.Size(98, 41);
            this.thresholdValueLabel.TabIndex = 1;
            this.thresholdValueLabel.Text = "%";
            this.thresholdValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // thresholdSlider
            // 
            this.thresholdSlider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.thresholdSlider.Location = new System.Drawing.Point(3, 3);
            this.thresholdSlider.Maximum = 100;
            this.thresholdSlider.Name = "thresholdSlider";
            this.thresholdSlider.Size = new System.Drawing.Size(303, 35);
            this.thresholdSlider.TabIndex = 0;
            this.thresholdSlider.TickFrequency = 5;
            this.thresholdSlider.ValueChanged += new System.EventHandler(this.valueChanged);
            this.thresholdSlider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.thresholdSlider_MouseDown);
            this.thresholdSlider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.thresholdSlider_MouseUp);
            // 
            // linearLabel
            // 
            this.linearLabel.AutoSize = true;
            this.linearLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linearLabel.Location = new System.Drawing.Point(3, 188);
            this.linearLabel.Name = "linearLabel";
            this.linearLabel.Size = new System.Drawing.Size(171, 47);
            this.linearLabel.TabIndex = 6;
            this.linearLabel.Text = "Linear";
            this.linearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // outputJoystick
            // 
            this.outputJoystick.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.outputJoystick.FormattingEnabled = true;
            this.outputJoystick.Items.AddRange(new object[] {
            "Left",
            "Right"});
            this.outputJoystick.Location = new System.Drawing.Point(180, 60);
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
            this.outputJoystickLabel.Location = new System.Drawing.Point(3, 47);
            this.outputJoystickLabel.Name = "outputJoystickLabel";
            this.outputJoystickLabel.Size = new System.Drawing.Size(171, 47);
            this.outputJoystickLabel.TabIndex = 1;
            this.outputJoystickLabel.Text = "Output Joystick";
            this.outputJoystickLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inputButtonLabel
            // 
            this.inputButtonLabel.AutoSize = true;
            this.inputButtonLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputButtonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputButtonLabel.Location = new System.Drawing.Point(3, 0);
            this.inputButtonLabel.Name = "inputButtonLabel";
            this.inputButtonLabel.Size = new System.Drawing.Size(171, 47);
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
            this.inputJoystick.Location = new System.Drawing.Point(180, 13);
            this.inputJoystick.MaxDropDownItems = 20;
            this.inputJoystick.Name = "inputJoystick";
            this.inputJoystick.Size = new System.Drawing.Size(121, 21);
            this.inputJoystick.TabIndex = 2;
            this.inputJoystick.SelectedIndexChanged += new System.EventHandler(this.valueChanged);
            this.inputJoystick.SelectedValueChanged += new System.EventHandler(this.valueChanged);
            // 
            // rotate
            // 
            this.rotate.AutoSize = true;
            this.rotate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rotate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotate.Location = new System.Drawing.Point(3, 94);
            this.rotate.Name = "rotate";
            this.rotate.Size = new System.Drawing.Size(171, 47);
            this.rotate.TabIndex = 4;
            this.rotate.Text = "Rotate (Clockwise)";
            this.rotate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.rotateValueLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.rotateSlider, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(180, 97);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(413, 41);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // rotateValueLabel
            // 
            this.rotateValueLabel.AutoSize = true;
            this.rotateValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rotateValueLabel.Location = new System.Drawing.Point(312, 0);
            this.rotateValueLabel.Name = "rotateValueLabel";
            this.rotateValueLabel.Size = new System.Drawing.Size(98, 41);
            this.rotateValueLabel.TabIndex = 1;
            this.rotateValueLabel.Text = "°";
            this.rotateValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rotateSlider
            // 
            this.rotateSlider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rotateSlider.Location = new System.Drawing.Point(3, 3);
            this.rotateSlider.Maximum = 180;
            this.rotateSlider.Minimum = -180;
            this.rotateSlider.Name = "rotateSlider";
            this.rotateSlider.Size = new System.Drawing.Size(303, 35);
            this.rotateSlider.TabIndex = 0;
            this.rotateSlider.TickFrequency = 5;
            this.rotateSlider.ValueChanged += new System.EventHandler(this.valueChanged);
            this.rotateSlider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.thresholdSlider_MouseDown);
            this.rotateSlider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.thresholdSlider_MouseUp);
            // 
            // linear
            // 
            this.linear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.linear.AutoSize = true;
            this.linear.Location = new System.Drawing.Point(180, 204);
            this.linear.Name = "linear";
            this.linear.Size = new System.Drawing.Size(15, 14);
            this.linear.TabIndex = 8;
            this.linear.UseVisualStyleBackColor = true;
            this.linear.CheckStateChanged += new System.EventHandler(this.valueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 48);
            this.label1.TabIndex = 11;
            this.label1.Text = "76° Snap Mode";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // snapMode76
            // 
            this.snapMode76.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.snapMode76.AutoSize = true;
            this.snapMode76.Location = new System.Drawing.Point(180, 252);
            this.snapMode76.Name = "snapMode76";
            this.snapMode76.Size = new System.Drawing.Size(15, 14);
            this.snapMode76.TabIndex = 12;
            this.snapMode76.UseVisualStyleBackColor = true;
            this.snapMode76.CheckStateChanged += new System.EventHandler(this.valueChanged);
            // 
            // JoystickAsJoystickControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "JoystickAsJoystickControl";
            this.Size = new System.Drawing.Size(596, 283);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdSlider)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotateSlider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label outputJoystickLabel;
        private System.Windows.Forms.Label inputButtonLabel;
        private System.Windows.Forms.ComboBox outputJoystick;
        private System.Windows.Forms.ComboBox inputJoystick;
        private System.Windows.Forms.Label rotate;
        private System.Windows.Forms.Label linearLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TrackBar rotateSlider;
        private System.Windows.Forms.Label rotateValueLabel;
        private System.Windows.Forms.CheckBox linear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label thresholdValueLabel;
        private System.Windows.Forms.TrackBar thresholdSlider;
        private System.Windows.Forms.Label thresholdLabel;
        private System.Windows.Forms.CheckBox snapMode76;
        private System.Windows.Forms.Label label1;
    }
}
