namespace GMKDriverNETUI.ConfigurationControls
{
    partial class ButtonAsButtonControl
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
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.outputButtonLabel = new System.Windows.Forms.Label();
            this.inputButtonLabel = new System.Windows.Forms.Label();
            this.outputButton = new GMKDriverNETUI.ConfigurationControls.ButtonControl();
            this.inputButton = new GMKDriverNETUI.ConfigurationControls.ButtonControl();
            this.tableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayout
            // 
            this.tableLayout.ColumnCount = 2;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.69799F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.30201F));
            this.tableLayout.Controls.Add(this.outputButtonLabel, 0, 1);
            this.tableLayout.Controls.Add(this.inputButtonLabel, 0, 0);
            this.tableLayout.Controls.Add(this.outputButton, 1, 1);
            this.tableLayout.Controls.Add(this.inputButton, 1, 0);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.Location = new System.Drawing.Point(0, 0);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 2;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.Size = new System.Drawing.Size(596, 283);
            this.tableLayout.TabIndex = 0;
            // 
            // outputButtonLabel
            // 
            this.outputButtonLabel.AutoSize = true;
            this.outputButtonLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputButtonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputButtonLabel.Location = new System.Drawing.Point(3, 141);
            this.outputButtonLabel.Name = "outputButtonLabel";
            this.outputButtonLabel.Size = new System.Drawing.Size(171, 142);
            this.outputButtonLabel.TabIndex = 1;
            this.outputButtonLabel.Text = "Output Button";
            this.outputButtonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inputButtonLabel
            // 
            this.inputButtonLabel.AutoSize = true;
            this.inputButtonLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputButtonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputButtonLabel.Location = new System.Drawing.Point(3, 0);
            this.inputButtonLabel.Name = "inputButtonLabel";
            this.inputButtonLabel.Size = new System.Drawing.Size(171, 141);
            this.inputButtonLabel.TabIndex = 0;
            this.inputButtonLabel.Text = "Input Button";
            this.inputButtonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // outputButton
            // 
            this.outputButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputButton.Location = new System.Drawing.Point(180, 144);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(413, 136);
            this.outputButton.TabIndex = 3;
            // 
            // inputButton
            // 
            this.inputButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputButton.Location = new System.Drawing.Point(180, 3);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(413, 135);
            this.inputButton.TabIndex = 4;
            // 
            // ButtonAsButtonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayout);
            this.Name = "ButtonAsButtonControl";
            this.Size = new System.Drawing.Size(596, 283);
            this.tableLayout.ResumeLayout(false);
            this.tableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.Label outputButtonLabel;
        private System.Windows.Forms.Label inputButtonLabel;
        private ButtonControl outputButton;
        private ButtonControl inputButton;
    }
}
