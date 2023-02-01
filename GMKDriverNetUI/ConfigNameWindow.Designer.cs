namespace GMKDriverNETUI
{
    partial class ConfigNameWindow
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigNameWindow));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.makeDefault = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.46154F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.53846F));
            this.tableLayoutPanel1.Controls.Add(this.nameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.name, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.okButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.makeDefault, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.90909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.09091F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(347, 114);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(3, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(127, 47);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Configuration Name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // name
            // 
            this.name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.name.Location = new System.Drawing.Point(136, 13);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(181, 20);
            this.name.TabIndex = 1;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // okButton
            // 
            this.okButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.okButton, 2);
            this.okButton.Location = new System.Drawing.Point(117, 84);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(113, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Make Default";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // makeDefault
            // 
            this.makeDefault.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.makeDefault.AutoSize = true;
            this.makeDefault.Location = new System.Drawing.Point(136, 55);
            this.makeDefault.Name = "makeDefault";
            this.makeDefault.Size = new System.Drawing.Size(15, 14);
            this.makeDefault.TabIndex = 4;
            this.makeDefault.UseVisualStyleBackColor = true;
            // 
            // ConfigName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 114);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigName";
            this.Text = "Config Name";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox makeDefault;
    }
}