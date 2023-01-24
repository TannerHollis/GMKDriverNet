namespace GMKDriverNETUI.ConfigurationControls
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
            this.linear = new GMKDriverNETUI.ConfigurationControls.BoolControl();
            this.deadzone = new GMKDriverNETUI.ConfigurationControls.DeadzoneControl();
            this.rotate = new GMKDriverNETUI.ConfigurationControls.RotateControl();
            this.outputJoystick = new GMKDriverNETUI.ConfigurationControls.JoystickControl();
            this.inputJoystick = new GMKDriverNETUI.ConfigurationControls.JoystickControl();
            this.rotateLabel = new System.Windows.Forms.Label();
            this.inputButtonLabel = new System.Windows.Forms.Label();
            this.outputJoystickLabel = new System.Windows.Forms.Label();
            this.linearLabel = new System.Windows.Forms.Label();
            this.deadzoneLabel = new System.Windows.Forms.Label();
            this.snap76Label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.snap76 = new GMKDriverNETUI.ConfigurationControls.Snap76Control();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linear
            // 
            this.linear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linear.Location = new System.Drawing.Point(180, 191);
            this.linear.Name = "linear";
            this.linear.Size = new System.Drawing.Size(413, 41);
            this.linear.TabIndex = 17;
            // 
            // deadzone
            // 
            this.deadzone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deadzone.Location = new System.Drawing.Point(180, 144);
            this.deadzone.Name = "deadzone";
            this.deadzone.Size = new System.Drawing.Size(413, 41);
            this.deadzone.TabIndex = 16;
            // 
            // rotate
            // 
            this.rotate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rotate.Location = new System.Drawing.Point(180, 97);
            this.rotate.Name = "rotate";
            this.rotate.Size = new System.Drawing.Size(413, 41);
            this.rotate.TabIndex = 15;
            // 
            // outputJoystick
            // 
            this.outputJoystick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputJoystick.Location = new System.Drawing.Point(180, 50);
            this.outputJoystick.Name = "outputJoystick";
            this.outputJoystick.Size = new System.Drawing.Size(413, 41);
            this.outputJoystick.TabIndex = 14;
            // 
            // inputJoystick
            // 
            this.inputJoystick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputJoystick.Location = new System.Drawing.Point(180, 3);
            this.inputJoystick.Name = "inputJoystick";
            this.inputJoystick.Size = new System.Drawing.Size(413, 41);
            this.inputJoystick.TabIndex = 13;
            // 
            // rotateLabel
            // 
            this.rotateLabel.AutoSize = true;
            this.rotateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rotateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotateLabel.Location = new System.Drawing.Point(3, 94);
            this.rotateLabel.Name = "rotateLabel";
            this.rotateLabel.Size = new System.Drawing.Size(171, 47);
            this.rotateLabel.TabIndex = 4;
            this.rotateLabel.Text = "Rotate (Clockwise)";
            this.rotateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // deadzoneLabel
            // 
            this.deadzoneLabel.AutoSize = true;
            this.deadzoneLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deadzoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deadzoneLabel.Location = new System.Drawing.Point(3, 141);
            this.deadzoneLabel.Name = "deadzoneLabel";
            this.deadzoneLabel.Size = new System.Drawing.Size(171, 47);
            this.deadzoneLabel.TabIndex = 10;
            this.deadzoneLabel.Text = "Deadzone";
            this.deadzoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // snap76Label
            // 
            this.snap76Label.AutoSize = true;
            this.snap76Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.snap76Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snap76Label.Location = new System.Drawing.Point(3, 235);
            this.snap76Label.Name = "snap76Label";
            this.snap76Label.Size = new System.Drawing.Size(171, 48);
            this.snap76Label.TabIndex = 11;
            this.snap76Label.Text = "76° Snap Mode";
            this.snap76Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.69799F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.30201F));
            this.tableLayoutPanel1.Controls.Add(this.snap76Label, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.deadzoneLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.linearLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.outputJoystickLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.inputButtonLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rotateLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.inputJoystick, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.outputJoystick, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.rotate, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.deadzone, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.linear, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.snap76, 1, 5);
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
            // snap76
            // 
            this.snap76.Dock = System.Windows.Forms.DockStyle.Fill;
            this.snap76.Location = new System.Drawing.Point(180, 238);
            this.snap76.Name = "snap76";
            this.snap76.Size = new System.Drawing.Size(413, 42);
            this.snap76.TabIndex = 18;
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
            this.ResumeLayout(false);

        }

        #endregion
        private BoolControl linear;
        private DeadzoneControl deadzone;
        private RotateControl rotate;
        private JoystickControl outputJoystick;
        private JoystickControl inputJoystick;
        private System.Windows.Forms.Label rotateLabel;
        private System.Windows.Forms.Label inputButtonLabel;
        private System.Windows.Forms.Label outputJoystickLabel;
        private System.Windows.Forms.Label linearLabel;
        private System.Windows.Forms.Label deadzoneLabel;
        private System.Windows.Forms.Label snap76Label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Snap76Control snap76;
    }
}
