namespace GMKDriverNETUI.ConfigurationControls
{
    partial class JoystickAsTriggerControl
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
            this.inputAxisLabel = new System.Windows.Forms.Label();
            this.inputButtonLabel = new System.Windows.Forms.Label();
            this.outputTriggerLabel = new System.Windows.Forms.Label();
            this.thresholdLabel = new System.Windows.Forms.Label();
            this.inputJoystick = new GMKDriverNETUI.ConfigurationControls.JoystickControl();
            this.inputAxis = new GMKDriverNETUI.ConfigurationControls.AxisControl();
            this.outputTrigger = new GMKDriverNETUI.ConfigurationControls.TriggerControl();
            this.deadzone = new GMKDriverNETUI.ConfigurationControls.DeadzoneControl();
            this.linear = new GMKDriverNETUI.ConfigurationControls.BoolControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.69799F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.30201F));
            this.tableLayoutPanel1.Controls.Add(this.linearLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.inputAxisLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.inputButtonLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.outputTriggerLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.thresholdLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.inputJoystick, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.inputAxis, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.outputTrigger, 1, 2);
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
            this.linearLabel.TabIndex = 6;
            this.linearLabel.Text = "Linear";
            this.linearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inputAxisLabel
            // 
            this.inputAxisLabel.AutoSize = true;
            this.inputAxisLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputAxisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputAxisLabel.Location = new System.Drawing.Point(3, 56);
            this.inputAxisLabel.Name = "inputAxisLabel";
            this.inputAxisLabel.Size = new System.Drawing.Size(171, 56);
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
            this.inputButtonLabel.Size = new System.Drawing.Size(171, 56);
            this.inputButtonLabel.TabIndex = 0;
            this.inputButtonLabel.Text = "Input Joystick";
            this.inputButtonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // outputTriggerLabel
            // 
            this.outputTriggerLabel.AutoSize = true;
            this.outputTriggerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputTriggerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTriggerLabel.Location = new System.Drawing.Point(3, 112);
            this.outputTriggerLabel.Name = "outputTriggerLabel";
            this.outputTriggerLabel.Size = new System.Drawing.Size(171, 56);
            this.outputTriggerLabel.TabIndex = 4;
            this.outputTriggerLabel.Text = "Output Trigger";
            this.outputTriggerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // inputJoystick
            // 
            this.inputJoystick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputJoystick.Location = new System.Drawing.Point(180, 3);
            this.inputJoystick.Name = "inputJoystick";
            this.inputJoystick.Size = new System.Drawing.Size(413, 50);
            this.inputJoystick.TabIndex = 11;
            // 
            // inputAxis
            // 
            this.inputAxis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputAxis.Location = new System.Drawing.Point(180, 59);
            this.inputAxis.Name = "inputAxis";
            this.inputAxis.Size = new System.Drawing.Size(413, 50);
            this.inputAxis.TabIndex = 12;
            // 
            // outputTrigger
            // 
            this.outputTrigger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputTrigger.Location = new System.Drawing.Point(180, 115);
            this.outputTrigger.Name = "outputTrigger";
            this.outputTrigger.Size = new System.Drawing.Size(413, 50);
            this.outputTrigger.TabIndex = 13;
            // 
            // deadzone
            // 
            this.deadzone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deadzone.Location = new System.Drawing.Point(180, 171);
            this.deadzone.Name = "deadzone";
            this.deadzone.Size = new System.Drawing.Size(413, 50);
            this.deadzone.TabIndex = 14;
            // 
            // linear
            // 
            this.linear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linear.Location = new System.Drawing.Point(180, 227);
            this.linear.Name = "linear";
            this.linear.Size = new System.Drawing.Size(413, 53);
            this.linear.TabIndex = 15;
            // 
            // JoystickAsTriggerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "JoystickAsTriggerControl";
            this.Size = new System.Drawing.Size(596, 283);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label inputAxisLabel;
        private System.Windows.Forms.Label inputButtonLabel;
        private System.Windows.Forms.Label outputTriggerLabel;
        private System.Windows.Forms.Label linearLabel;
        private System.Windows.Forms.Label thresholdLabel;
        private JoystickControl inputJoystick;
        private AxisControl inputAxis;
        private TriggerControl outputTrigger;
        private DeadzoneControl deadzone;
        private BoolControl linear;
    }
}
