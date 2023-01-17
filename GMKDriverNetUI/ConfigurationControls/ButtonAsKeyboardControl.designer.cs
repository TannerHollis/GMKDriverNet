namespace GMKDriverNetUI.ConfigurationControls
{
    partial class ButtonAsKeyboardControl
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
            this.outputKeyLabel = new System.Windows.Forms.Label();
            this.inputButtonLabel = new System.Windows.Forms.Label();
            this.inputButton = new System.Windows.Forms.ComboBox();
            this.outputKey = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.69799F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.30201F));
            this.tableLayoutPanel1.Controls.Add(this.outputKeyLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.inputButtonLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.inputButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.outputKey, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.25373F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.74627F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(596, 283);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // outputKeyLabel
            // 
            this.outputKeyLabel.AutoSize = true;
            this.outputKeyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputKeyLabel.Location = new System.Drawing.Point(3, 139);
            this.outputKeyLabel.Name = "outputKeyLabel";
            this.outputKeyLabel.Size = new System.Drawing.Size(171, 144);
            this.outputKeyLabel.TabIndex = 1;
            this.outputKeyLabel.Text = "Output Key";
            this.outputKeyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inputButtonLabel
            // 
            this.inputButtonLabel.AutoSize = true;
            this.inputButtonLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputButtonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputButtonLabel.Location = new System.Drawing.Point(3, 0);
            this.inputButtonLabel.Name = "inputButtonLabel";
            this.inputButtonLabel.Size = new System.Drawing.Size(171, 139);
            this.inputButtonLabel.TabIndex = 0;
            this.inputButtonLabel.Text = "Input Button";
            this.inputButtonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inputButton
            // 
            this.inputButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.inputButton.FormattingEnabled = true;
            this.inputButton.Items.AddRange(new object[] {
            "A",
            "B",
            "X",
            "Y",
            "Start",
            "Back",
            "Xbox",
            "LeftThumb",
            "RightThumb",
            "LeftBumper",
            "RightBumper",
            "Up",
            "Down",
            "Left",
            "Right"});
            this.inputButton.Location = new System.Drawing.Point(180, 59);
            this.inputButton.MaxDropDownItems = 20;
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(121, 21);
            this.inputButton.TabIndex = 2;
            this.inputButton.SelectedValueChanged += new System.EventHandler(this.valueChanged);
            // 
            // outputKey
            // 
            this.outputKey.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.outputKey.Location = new System.Drawing.Point(180, 201);
            this.outputKey.MaxLength = 1;
            this.outputKey.Name = "outputKey";
            this.outputKey.Size = new System.Drawing.Size(121, 20);
            this.outputKey.TabIndex = 3;
            // 
            // ButtonAsKeyboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ButtonAsKeyboardControl";
            this.Size = new System.Drawing.Size(596, 283);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label outputKeyLabel;
        private System.Windows.Forms.Label inputButtonLabel;
        private System.Windows.Forms.ComboBox inputButton;
        private System.Windows.Forms.TextBox outputKey;
    }
}
