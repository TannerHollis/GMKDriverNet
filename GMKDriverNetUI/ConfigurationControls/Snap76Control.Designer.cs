namespace GMKDriverNETUI.ConfigurationControls
{
    partial class Snap76Control
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
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.snap76Intensity = new System.Windows.Forms.ComboBox();
            this.snap76IntensityLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.2884F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.7116F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.Controls.Add(this.checkBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.snap76Intensity, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.snap76IntensityLabel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(572, 146);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // checkBox
            // 
            this.checkBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(3, 66);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(15, 14);
            this.checkBox.TabIndex = 0;
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.bool_SelectedIndexChanged);
            // 
            // snap76Intensity
            // 
            this.snap76Intensity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.snap76Intensity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.snap76Intensity.FormattingEnabled = true;
            this.snap76Intensity.Items.AddRange(new object[] {
            "Extremely Tight (20°)",
            "Tight (30°)",
            "Medium (40°)",
            "Loose (50°)",
            "Very Loose (60°)"});
            this.snap76Intensity.Location = new System.Drawing.Point(394, 62);
            this.snap76Intensity.Name = "snap76Intensity";
            this.snap76Intensity.Size = new System.Drawing.Size(121, 21);
            this.snap76Intensity.TabIndex = 1;
            this.snap76Intensity.SelectedIndexChanged += new System.EventHandler(this.bool_SelectedIndexChanged);
            // 
            // snap76IntensityLabel
            // 
            this.snap76IntensityLabel.AutoSize = true;
            this.snap76IntensityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.snap76IntensityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snap76IntensityLabel.Location = new System.Drawing.Point(129, 0);
            this.snap76IntensityLabel.Name = "snap76IntensityLabel";
            this.snap76IntensityLabel.Size = new System.Drawing.Size(259, 146);
            this.snap76IntensityLabel.TabIndex = 2;
            this.snap76IntensityLabel.Text = "Snap76 Intensity:";
            this.snap76IntensityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Snap76Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Snap76Control";
            this.Size = new System.Drawing.Size(572, 146);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.ComboBox snap76Intensity;
        private System.Windows.Forms.Label snap76IntensityLabel;
    }
}
