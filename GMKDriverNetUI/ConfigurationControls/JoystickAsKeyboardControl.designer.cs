﻿namespace GMKDriverNETUI.ConfigurationControls
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
            this.inputAxisLabel = new System.Windows.Forms.Label();
            this.inputJoystickLabel = new System.Windows.Forms.Label();
            this.keyLabel = new System.Windows.Forms.Label();
            this.deadzoneLabel = new System.Windows.Forms.Label();
            this.inputJoystick = new GMKDriverNETUI.ConfigurationControls.JoystickControl();
            this.inputAxis = new GMKDriverNETUI.ConfigurationControls.AxisControl();
            this.key = new GMKDriverNETUI.ConfigurationControls.KeyboardControl();
            this.deadzone = new GMKDriverNETUI.ConfigurationControls.DeadzoneControl();
            this.rotateLabel = new System.Windows.Forms.Label();
            this.rotate = new GMKDriverNETUI.ConfigurationControls.RotateControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.69799F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.30201F));
            this.tableLayoutPanel1.Controls.Add(this.rotateLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.inputAxisLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.inputJoystickLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.keyLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.deadzoneLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.inputJoystick, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.inputAxis, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.key, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.deadzone, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.rotate, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(596, 283);
            this.tableLayoutPanel1.TabIndex = 0;
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
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyLabel.Location = new System.Drawing.Point(3, 112);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(171, 56);
            this.keyLabel.TabIndex = 4;
            this.keyLabel.Text = "Output Key";
            this.keyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // deadzoneLabel
            // 
            this.deadzoneLabel.AutoSize = true;
            this.deadzoneLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deadzoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deadzoneLabel.Location = new System.Drawing.Point(3, 224);
            this.deadzoneLabel.Name = "deadzoneLabel";
            this.deadzoneLabel.Size = new System.Drawing.Size(171, 59);
            this.deadzoneLabel.TabIndex = 10;
            this.deadzoneLabel.Text = "Deadzone";
            this.deadzoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // key
            // 
            this.key.Dock = System.Windows.Forms.DockStyle.Fill;
            this.key.Location = new System.Drawing.Point(180, 115);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(413, 50);
            this.key.TabIndex = 13;
            // 
            // deadzone
            // 
            this.deadzone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deadzone.Location = new System.Drawing.Point(180, 227);
            this.deadzone.Name = "deadzone";
            this.deadzone.Size = new System.Drawing.Size(413, 53);
            this.deadzone.TabIndex = 14;
            // 
            // rotateLabel
            // 
            this.rotateLabel.AutoSize = true;
            this.rotateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rotateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotateLabel.Location = new System.Drawing.Point(3, 168);
            this.rotateLabel.Name = "rotateLabel";
            this.rotateLabel.Size = new System.Drawing.Size(171, 56);
            this.rotateLabel.TabIndex = 15;
            this.rotateLabel.Text = "Input Joystick Rotation (Clockwise)";
            this.rotateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rotate
            // 
            this.rotate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rotate.Location = new System.Drawing.Point(180, 171);
            this.rotate.Name = "rotate";
            this.rotate.Size = new System.Drawing.Size(413, 50);
            this.rotate.TabIndex = 16;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label inputAxisLabel;
        private System.Windows.Forms.Label inputJoystickLabel;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.Label deadzoneLabel;
        private JoystickControl inputJoystick;
        private AxisControl inputAxis;
        private KeyboardControl key;
        private DeadzoneControl deadzone;
        private System.Windows.Forms.Label rotateLabel;
        private RotateControl rotate;
    }
}
