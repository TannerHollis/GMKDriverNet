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
            this.components = new System.ComponentModel.Container();
            this.rotateLabel = new System.Windows.Forms.Label();
            this.inputJoystickLabel = new System.Windows.Forms.Label();
            this.outputJoystickLabel = new System.Windows.Forms.Label();
            this.linearLabel = new System.Windows.Forms.Label();
            this.deadzoneLabel = new System.Windows.Forms.Label();
            this.snap76Label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.inputJoystick = new GMKDriverNETUI.ConfigurationControls.JoystickControl();
            this.outputJoystick = new GMKDriverNETUI.ConfigurationControls.JoystickControl();
            this.rotate = new GMKDriverNETUI.ConfigurationControls.RotateControl();
            this.deadzone = new GMKDriverNETUI.ConfigurationControls.DeadzoneControl();
            this.linear = new GMKDriverNETUI.ConfigurationControls.BoolControl();
            this.snap76 = new GMKDriverNETUI.ConfigurationControls.Snap76Control();
            this.joystickView = new System.Windows.Forms.Panel();
            this.legendGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.rawInputLabel = new System.Windows.Forms.Label();
            this.timerJoystickUpdate = new System.Windows.Forms.Timer(this.components);
            this.outputLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.legendGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rotateLabel
            // 
            this.rotateLabel.AutoSize = true;
            this.rotateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rotateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotateLabel.Location = new System.Drawing.Point(150, 94);
            this.rotateLabel.Name = "rotateLabel";
            this.rotateLabel.Size = new System.Drawing.Size(118, 47);
            this.rotateLabel.TabIndex = 4;
            this.rotateLabel.Text = "Rotate (Clockwise)";
            this.rotateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inputJoystickLabel
            // 
            this.inputJoystickLabel.AutoSize = true;
            this.inputJoystickLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputJoystickLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputJoystickLabel.Location = new System.Drawing.Point(150, 0);
            this.inputJoystickLabel.Name = "inputJoystickLabel";
            this.inputJoystickLabel.Size = new System.Drawing.Size(118, 47);
            this.inputJoystickLabel.TabIndex = 0;
            this.inputJoystickLabel.Text = "Input Joystick";
            this.inputJoystickLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // outputJoystickLabel
            // 
            this.outputJoystickLabel.AutoSize = true;
            this.outputJoystickLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputJoystickLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputJoystickLabel.Location = new System.Drawing.Point(150, 47);
            this.outputJoystickLabel.Name = "outputJoystickLabel";
            this.outputJoystickLabel.Size = new System.Drawing.Size(118, 47);
            this.outputJoystickLabel.TabIndex = 1;
            this.outputJoystickLabel.Text = "Output Joystick";
            this.outputJoystickLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // linearLabel
            // 
            this.linearLabel.AutoSize = true;
            this.linearLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linearLabel.Location = new System.Drawing.Point(150, 188);
            this.linearLabel.Name = "linearLabel";
            this.linearLabel.Size = new System.Drawing.Size(118, 47);
            this.linearLabel.TabIndex = 6;
            this.linearLabel.Text = "Linear";
            this.linearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // deadzoneLabel
            // 
            this.deadzoneLabel.AutoSize = true;
            this.deadzoneLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deadzoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deadzoneLabel.Location = new System.Drawing.Point(150, 141);
            this.deadzoneLabel.Name = "deadzoneLabel";
            this.deadzoneLabel.Size = new System.Drawing.Size(118, 47);
            this.deadzoneLabel.TabIndex = 10;
            this.deadzoneLabel.Text = "Deadzone";
            this.deadzoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // snap76Label
            // 
            this.snap76Label.AutoSize = true;
            this.snap76Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.snap76Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snap76Label.Location = new System.Drawing.Point(150, 235);
            this.snap76Label.Name = "snap76Label";
            this.snap76Label.Size = new System.Drawing.Size(118, 48);
            this.snap76Label.TabIndex = 11;
            this.snap76Label.Text = "76° Snap Mode";
            this.snap76Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.83221F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.80537F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.36242F));
            this.tableLayoutPanel1.Controls.Add(this.snap76Label, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.deadzoneLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.linearLabel, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.outputJoystickLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.inputJoystickLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.rotateLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.inputJoystick, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.outputJoystick, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.rotate, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.deadzone, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.linear, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.snap76, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.joystickView, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.legendGroupBox, 0, 0);
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
            // inputJoystick
            // 
            this.inputJoystick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputJoystick.Location = new System.Drawing.Point(274, 3);
            this.inputJoystick.Name = "inputJoystick";
            this.inputJoystick.Size = new System.Drawing.Size(319, 41);
            this.inputJoystick.TabIndex = 13;
            // 
            // outputJoystick
            // 
            this.outputJoystick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputJoystick.Location = new System.Drawing.Point(274, 50);
            this.outputJoystick.Name = "outputJoystick";
            this.outputJoystick.Size = new System.Drawing.Size(319, 41);
            this.outputJoystick.TabIndex = 14;
            // 
            // rotate
            // 
            this.rotate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rotate.Location = new System.Drawing.Point(274, 97);
            this.rotate.Name = "rotate";
            this.rotate.Size = new System.Drawing.Size(319, 41);
            this.rotate.TabIndex = 15;
            // 
            // deadzone
            // 
            this.deadzone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deadzone.Location = new System.Drawing.Point(274, 144);
            this.deadzone.Name = "deadzone";
            this.deadzone.Size = new System.Drawing.Size(319, 41);
            this.deadzone.TabIndex = 16;
            // 
            // linear
            // 
            this.linear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linear.Location = new System.Drawing.Point(274, 191);
            this.linear.Name = "linear";
            this.linear.Size = new System.Drawing.Size(319, 41);
            this.linear.TabIndex = 17;
            // 
            // snap76
            // 
            this.snap76.Dock = System.Windows.Forms.DockStyle.Fill;
            this.snap76.Location = new System.Drawing.Point(274, 238);
            this.snap76.Name = "snap76";
            this.snap76.Size = new System.Drawing.Size(319, 42);
            this.snap76.TabIndex = 18;
            // 
            // joystickView
            // 
            this.joystickView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.joystickView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.joystickView.Location = new System.Drawing.Point(5, 97);
            this.joystickView.MinimumSize = new System.Drawing.Size(128, 128);
            this.joystickView.Name = "joystickView";
            this.tableLayoutPanel1.SetRowSpan(this.joystickView, 4);
            this.joystickView.Size = new System.Drawing.Size(137, 128);
            this.joystickView.TabIndex = 19;
            // 
            // legendGroupBox
            // 
            this.legendGroupBox.Controls.Add(this.tableLayoutPanel2);
            this.legendGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.legendGroupBox.Location = new System.Drawing.Point(3, 3);
            this.legendGroupBox.Name = "legendGroupBox";
            this.tableLayoutPanel1.SetRowSpan(this.legendGroupBox, 2);
            this.legendGroupBox.Size = new System.Drawing.Size(141, 88);
            this.legendGroupBox.TabIndex = 20;
            this.legendGroupBox.TabStop = false;
            this.legendGroupBox.Text = "Legend";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.rawInputLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.outputLabel, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(132, 56);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // rawInputLabel
            // 
            this.rawInputLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rawInputLabel.AutoSize = true;
            this.rawInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rawInputLabel.ForeColor = System.Drawing.Color.Lime;
            this.rawInputLabel.Location = new System.Drawing.Point(39, 10);
            this.rawInputLabel.Name = "rawInputLabel";
            this.rawInputLabel.Size = new System.Drawing.Size(56, 13);
            this.rawInputLabel.TabIndex = 0;
            this.rawInputLabel.Text = "Raw Input";
            // 
            // timerJoystickUpdate
            // 
            this.timerJoystickUpdate.Interval = 25;
            this.timerJoystickUpdate.Tick += new System.EventHandler(this.timerJoystickUpdate_Tick);
            // 
            // outputLabel
            // 
            this.outputLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.Blue;
            this.outputLabel.Location = new System.Drawing.Point(48, 45);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(39, 13);
            this.outputLabel.TabIndex = 1;
            this.outputLabel.Text = "Output";
            this.outputLabel.Click += new System.EventHandler(this.outputLabel_Click);
            // 
            // JoystickAsJoystickControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "JoystickAsJoystickControl";
            this.Size = new System.Drawing.Size(596, 283);
            this.VisibleChanged += new System.EventHandler(this.JoystickAsJoystickControl_VisibleChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.legendGroupBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private BoolControl linear;
        private DeadzoneControl deadzone;
        private RotateControl rotate;
        private JoystickControl outputJoystick;
        private JoystickControl inputJoystick;
        private System.Windows.Forms.Label rotateLabel;
        private System.Windows.Forms.Label inputJoystickLabel;
        private System.Windows.Forms.Label outputJoystickLabel;
        private System.Windows.Forms.Label linearLabel;
        private System.Windows.Forms.Label deadzoneLabel;
        private System.Windows.Forms.Label snap76Label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Snap76Control snap76;
        private System.Windows.Forms.Panel joystickView;
        private System.Windows.Forms.Timer timerJoystickUpdate;
        private System.Windows.Forms.GroupBox legendGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label rawInputLabel;
        private System.Windows.Forms.Label outputLabel;
    }
}
