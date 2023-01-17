namespace GMKDriverNetUI.ConfigurationControls
{
    partial class TriggerAsTriggerControl
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
            this.outputTrigger = new System.Windows.Forms.ComboBox();
            this.outputTriggerLabel = new System.Windows.Forms.Label();
            this.inputTriggerLabel = new System.Windows.Forms.Label();
            this.inputTrigger = new System.Windows.Forms.ComboBox();
            this.linear = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.69799F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.30201F));
            this.tableLayoutPanel1.Controls.Add(this.linearLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.outputTrigger, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.outputTriggerLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.inputTriggerLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.inputTrigger, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.linear, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(596, 283);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // linearLabel
            // 
            this.linearLabel.AutoSize = true;
            this.linearLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linearLabel.Location = new System.Drawing.Point(3, 188);
            this.linearLabel.Name = "linearLabel";
            this.linearLabel.Size = new System.Drawing.Size(171, 95);
            this.linearLabel.TabIndex = 14;
            this.linearLabel.Text = "Linear";
            this.linearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // outputTrigger
            // 
            this.outputTrigger.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.outputTrigger.FormattingEnabled = true;
            this.outputTrigger.Items.AddRange(new object[] {
            "Left",
            "Right"});
            this.outputTrigger.Location = new System.Drawing.Point(180, 130);
            this.outputTrigger.MaxDropDownItems = 20;
            this.outputTrigger.Name = "outputTrigger";
            this.outputTrigger.Size = new System.Drawing.Size(121, 21);
            this.outputTrigger.TabIndex = 3;
            this.outputTrigger.SelectedIndexChanged += new System.EventHandler(this.valueChanged);
            this.outputTrigger.SelectedValueChanged += new System.EventHandler(this.valueChanged);
            // 
            // outputTriggerLabel
            // 
            this.outputTriggerLabel.AutoSize = true;
            this.outputTriggerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputTriggerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTriggerLabel.Location = new System.Drawing.Point(3, 94);
            this.outputTriggerLabel.Name = "outputTriggerLabel";
            this.outputTriggerLabel.Size = new System.Drawing.Size(171, 94);
            this.outputTriggerLabel.TabIndex = 1;
            this.outputTriggerLabel.Text = "Output Trigger";
            this.outputTriggerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inputTriggerLabel
            // 
            this.inputTriggerLabel.AutoSize = true;
            this.inputTriggerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputTriggerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTriggerLabel.Location = new System.Drawing.Point(3, 0);
            this.inputTriggerLabel.Name = "inputTriggerLabel";
            this.inputTriggerLabel.Size = new System.Drawing.Size(171, 94);
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
            this.inputTrigger.Location = new System.Drawing.Point(180, 36);
            this.inputTrigger.MaxDropDownItems = 20;
            this.inputTrigger.Name = "inputTrigger";
            this.inputTrigger.Size = new System.Drawing.Size(121, 21);
            this.inputTrigger.TabIndex = 2;
            this.inputTrigger.SelectedIndexChanged += new System.EventHandler(this.valueChanged);
            this.inputTrigger.SelectedValueChanged += new System.EventHandler(this.valueChanged);
            // 
            // linear
            // 
            this.linear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.linear.AutoSize = true;
            this.linear.Location = new System.Drawing.Point(180, 228);
            this.linear.Name = "linear";
            this.linear.Size = new System.Drawing.Size(15, 14);
            this.linear.TabIndex = 15;
            this.linear.UseVisualStyleBackColor = true;
            this.linear.CheckStateChanged += new System.EventHandler(this.valueChanged);
            // 
            // TriggerAsTriggerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TriggerAsTriggerControl";
            this.Size = new System.Drawing.Size(596, 283);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label outputTriggerLabel;
        private System.Windows.Forms.Label inputTriggerLabel;
        private System.Windows.Forms.ComboBox outputTrigger;
        private System.Windows.Forms.ComboBox inputTrigger;
        private System.Windows.Forms.Label linearLabel;
        private System.Windows.Forms.CheckBox linear;
    }
}
