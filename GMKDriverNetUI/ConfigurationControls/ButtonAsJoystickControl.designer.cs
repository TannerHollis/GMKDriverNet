namespace GMKDriverNetUI.ConfigurationControls
{
    partial class ButtonAsJoystickControl
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
            this.outputAxisLabel = new System.Windows.Forms.Label();
            this.outputJoystickLabel = new System.Windows.Forms.Label();
            this.inputButtonLabel = new System.Windows.Forms.Label();
            this.inputButton = new GMKDriverNetUI.ConfigurationControls.ButtonControl();
            this.outputJoystick = new GMKDriverNetUI.ConfigurationControls.JoystickControl();
            this.outputAxis = new GMKDriverNetUI.ConfigurationControls.AxisControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.69799F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.30201F));
            this.tableLayoutPanel1.Controls.Add(this.outputAxisLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.outputJoystickLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.inputButtonLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.inputButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.outputJoystick, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.outputAxis, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(596, 283);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // outputAxisLabel
            // 
            this.outputAxisLabel.AutoSize = true;
            this.outputAxisLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputAxisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputAxisLabel.Location = new System.Drawing.Point(3, 189);
            this.outputAxisLabel.Name = "outputAxisLabel";
            this.outputAxisLabel.Size = new System.Drawing.Size(171, 94);
            this.outputAxisLabel.TabIndex = 4;
            this.outputAxisLabel.Text = "Output Axis";
            this.outputAxisLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // outputJoystickLabel
            // 
            this.outputJoystickLabel.AutoSize = true;
            this.outputJoystickLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputJoystickLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputJoystickLabel.Location = new System.Drawing.Point(3, 93);
            this.outputJoystickLabel.Name = "outputJoystickLabel";
            this.outputJoystickLabel.Size = new System.Drawing.Size(171, 96);
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
            this.inputButtonLabel.Size = new System.Drawing.Size(171, 93);
            this.inputButtonLabel.TabIndex = 0;
            this.inputButtonLabel.Text = "Input Button";
            this.inputButtonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inputButton
            // 
            this.inputButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputButton.Location = new System.Drawing.Point(180, 3);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(413, 87);
            this.inputButton.TabIndex = 5;
            // 
            // outputJoystick
            // 
            this.outputJoystick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputJoystick.Location = new System.Drawing.Point(180, 96);
            this.outputJoystick.Name = "outputJoystick";
            this.outputJoystick.Size = new System.Drawing.Size(413, 90);
            this.outputJoystick.TabIndex = 6;
            // 
            // outputAxis
            // 
            this.outputAxis.Location = new System.Drawing.Point(180, 192);
            this.outputAxis.Name = "outputAxis";
            this.outputAxis.Size = new System.Drawing.Size(413, 88);
            this.outputAxis.TabIndex = 7;
            // 
            // ButtonAsJoystickControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ButtonAsJoystickControl";
            this.Size = new System.Drawing.Size(596, 283);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label outputJoystickLabel;
        private System.Windows.Forms.Label inputButtonLabel;
        private System.Windows.Forms.Label outputAxisLabel;
        private ButtonControl inputButton;
        private JoystickControl outputJoystick;
        private AxisControl outputAxis;
    }
}
