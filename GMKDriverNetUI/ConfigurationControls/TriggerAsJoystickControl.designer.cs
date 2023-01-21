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
            this.linearLabel = new System.Windows.Forms.Label();
            this.outputAxisLabel = new System.Windows.Forms.Label();
            this.outputJoystickLabel = new System.Windows.Forms.Label();
            this.inputTriggerLabel = new System.Windows.Forms.Label();
            this.thresholdLabel = new System.Windows.Forms.Label();
            this.inputTrigger = new GMKDriverNetUI.ConfigurationControls.TriggerControl();
            this.outputJoystick = new GMKDriverNetUI.ConfigurationControls.JoystickControl();
            this.outputAxis = new GMKDriverNetUI.ConfigurationControls.AxisControl();
            this.deadzone = new GMKDriverNetUI.ConfigurationControls.DeadzoneControl();
            this.linear = new GMKDriverNetUI.ConfigurationControls.BoolControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.69799F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.30201F));
            this.tableLayoutPanel1.Controls.Add(this.linearLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.outputAxisLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.outputJoystickLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.inputTriggerLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.thresholdLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.inputTrigger, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.outputJoystick, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.outputAxis, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.deadzone, 1, 3);
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
            // thresholdLabel
            // 
            this.thresholdLabel.AutoSize = true;
            this.thresholdLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thresholdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thresholdLabel.Location = new System.Drawing.Point(3, 168);
            this.thresholdLabel.Name = "thresholdLabel";
            this.thresholdLabel.Size = new System.Drawing.Size(171, 56);
            this.thresholdLabel.TabIndex = 10;
            this.thresholdLabel.Text = "Deadzone";
            this.thresholdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inputTrigger
            // 
            this.inputTrigger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputTrigger.Location = new System.Drawing.Point(180, 3);
            this.inputTrigger.Name = "inputTrigger";
            this.inputTrigger.Size = new System.Drawing.Size(413, 50);
            this.inputTrigger.TabIndex = 15;
            // 
            // outputJoystick
            // 
            this.outputJoystick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputJoystick.Location = new System.Drawing.Point(180, 59);
            this.outputJoystick.Name = "outputJoystick";
            this.outputJoystick.Size = new System.Drawing.Size(413, 50);
            this.outputJoystick.TabIndex = 16;
            // 
            // outputAxis
            // 
            this.outputAxis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputAxis.Location = new System.Drawing.Point(180, 115);
            this.outputAxis.Name = "outputAxis";
            this.outputAxis.Size = new System.Drawing.Size(413, 50);
            this.outputAxis.TabIndex = 17;
            // 
            // deadzone
            // 
            this.deadzone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deadzone.Location = new System.Drawing.Point(180, 171);
            this.deadzone.Name = "deadzone";
            this.deadzone.Size = new System.Drawing.Size(413, 50);
            this.deadzone.TabIndex = 18;
            // 
            // linear
            // 
            this.linear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linear.Location = new System.Drawing.Point(180, 227);
            this.linear.Name = "linear";
            this.linear.Size = new System.Drawing.Size(413, 53);
            this.linear.TabIndex = 19;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label outputJoystickLabel;
        private System.Windows.Forms.Label inputTriggerLabel;
        private System.Windows.Forms.Label thresholdLabel;
        private System.Windows.Forms.Label outputAxisLabel;
        private System.Windows.Forms.Label linearLabel;
        private TriggerControl inputTrigger;
        private JoystickControl outputJoystick;
        private AxisControl outputAxis;
        private DeadzoneControl deadzone;
        private BoolControl linear;
    }
}
