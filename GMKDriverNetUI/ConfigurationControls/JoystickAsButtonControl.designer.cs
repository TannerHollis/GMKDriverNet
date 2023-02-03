namespace GMKDriverNETUI.ConfigurationControls
{
    partial class JoystickAsButtonControl
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
            this.rotateLabel = new System.Windows.Forms.Label();
            this.deadzoneLabel = new System.Windows.Forms.Label();
            this.inputAxisLabel = new System.Windows.Forms.Label();
            this.inputJoystickLabel = new System.Windows.Forms.Label();
            this.outputButtonLabel = new System.Windows.Forms.Label();
            this.inputJoystick = new GMKDriverNETUI.ConfigurationControls.JoystickControl();
            this.inputAxis = new GMKDriverNETUI.ConfigurationControls.AxisControl();
            this.outputButton = new GMKDriverNETUI.ConfigurationControls.ButtonControl();
            this.rotate = new GMKDriverNETUI.ConfigurationControls.RotateControl();
            this.deadzone = new GMKDriverNETUI.ConfigurationControls.DeadzoneControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.69799F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.30201F));
            this.tableLayoutPanel1.Controls.Add(this.rotateLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.deadzoneLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.inputAxisLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.inputJoystickLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.outputButtonLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.inputJoystick, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.inputAxis, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.outputButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.rotate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.deadzone, 1, 4);
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
            // rotateLabel
            // 
            this.rotateLabel.AutoSize = true;
            this.rotateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rotateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotateLabel.Location = new System.Drawing.Point(3, 56);
            this.rotateLabel.Name = "rotateLabel";
            this.rotateLabel.Size = new System.Drawing.Size(171, 56);
            this.rotateLabel.TabIndex = 10;
            this.rotateLabel.Text = "Input Joystick Rotation (Clockwise)";
            this.rotateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // deadzoneLabel
            // 
            this.deadzoneLabel.AutoSize = true;
            this.deadzoneLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deadzoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deadzoneLabel.Location = new System.Drawing.Point(3, 224);
            this.deadzoneLabel.Name = "deadzoneLabel";
            this.deadzoneLabel.Size = new System.Drawing.Size(171, 59);
            this.deadzoneLabel.TabIndex = 6;
            this.deadzoneLabel.Text = "Deadzone";
            this.deadzoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inputAxisLabel
            // 
            this.inputAxisLabel.AutoSize = true;
            this.inputAxisLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputAxisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputAxisLabel.Location = new System.Drawing.Point(3, 112);
            this.inputAxisLabel.Name = "inputAxisLabel";
            this.inputAxisLabel.Size = new System.Drawing.Size(171, 56);
            this.inputAxisLabel.TabIndex = 1;
            this.inputAxisLabel.Text = "Input Axis";
            this.inputAxisLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inputJoystickLabel
            // 
            this.inputJoystickLabel.AutoSize = true;
            this.inputJoystickLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputJoystickLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputJoystickLabel.Location = new System.Drawing.Point(3, 0);
            this.inputJoystickLabel.Name = "inputJoystickLabel";
            this.inputJoystickLabel.Size = new System.Drawing.Size(171, 56);
            this.inputJoystickLabel.TabIndex = 0;
            this.inputJoystickLabel.Text = "Input Joystick";
            this.inputJoystickLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // outputButtonLabel
            // 
            this.outputButtonLabel.AutoSize = true;
            this.outputButtonLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputButtonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputButtonLabel.Location = new System.Drawing.Point(3, 168);
            this.outputButtonLabel.Name = "outputButtonLabel";
            this.outputButtonLabel.Size = new System.Drawing.Size(171, 56);
            this.outputButtonLabel.TabIndex = 4;
            this.outputButtonLabel.Text = "Output Button";
            this.outputButtonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inputJoystick
            // 
            this.inputJoystick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputJoystick.Location = new System.Drawing.Point(180, 3);
            this.inputJoystick.Name = "inputJoystick";
            this.inputJoystick.Size = new System.Drawing.Size(413, 50);
            this.inputJoystick.TabIndex = 7;
            // 
            // inputAxis
            // 
            this.inputAxis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputAxis.Location = new System.Drawing.Point(180, 115);
            this.inputAxis.Name = "inputAxis";
            this.inputAxis.Size = new System.Drawing.Size(413, 50);
            this.inputAxis.TabIndex = 8;
            // 
            // outputButton
            // 
            this.outputButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputButton.Location = new System.Drawing.Point(180, 171);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(413, 50);
            this.outputButton.TabIndex = 9;
            // 
            // rotate
            // 
            this.rotate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rotate.Location = new System.Drawing.Point(180, 59);
            this.rotate.Name = "rotate";
            this.rotate.Size = new System.Drawing.Size(413, 50);
            this.rotate.TabIndex = 11;
            // 
            // deadzone
            // 
            this.deadzone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deadzone.Location = new System.Drawing.Point(180, 227);
            this.deadzone.Name = "deadzone";
            this.deadzone.Size = new System.Drawing.Size(413, 53);
            this.deadzone.TabIndex = 12;
            // 
            // JoystickAsButtonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "JoystickAsButtonControl";
            this.Size = new System.Drawing.Size(596, 283);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label inputAxisLabel;
        private System.Windows.Forms.Label inputJoystickLabel;
        private System.Windows.Forms.Label outputButtonLabel;
        private System.Windows.Forms.Label deadzoneLabel;
        private JoystickControl inputJoystick;
        private AxisControl inputAxis;
        private ButtonControl outputButton;
        private System.Windows.Forms.Label rotateLabel;
        private RotateControl rotate;
        private DeadzoneControl deadzone;
    }
}
