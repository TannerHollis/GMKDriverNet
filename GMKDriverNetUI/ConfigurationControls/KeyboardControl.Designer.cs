namespace GMKDriverNETUI.ConfigurationControls
{
    partial class KeyboardControl
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
            this.key2 = new System.Windows.Forms.ComboBox();
            this.key3Label = new System.Windows.Forms.Label();
            this.key3 = new System.Windows.Forms.ComboBox();
            this.key2Label = new System.Windows.Forms.Label();
            this.key1 = new System.Windows.Forms.ComboBox();
            this.key1Label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.key2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.key3Label, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.key3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.key2Label, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.key1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.key1Label, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(572, 146);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // key2
            // 
            this.key2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.key2.FormattingEnabled = true;
            this.key2.Items.AddRange(new object[] {
            "None",
            "UP(KEYPAD)",
            "DOWN(KEYPAD)",
            "LEFT(KEYPAD)",
            "RIGHT(KEYPAD)",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12",
            "` | ~",
            "1 | !",
            "2 | @",
            "3 | #",
            "4 | $",
            "5 | %",
            "6 | ^",
            "7 | &",
            "8 | *",
            "9 | (",
            "0 | )",
            "ENTER",
            "BACKSPACE",
            "LSHIFT",
            "RSHIFT",
            "CTRL",
            "CAPS",
            "TAB",
            "WINDOWS",
            "SPACE",
            ", | <",
            ". | >",
            "/ | ?",
            "; | :",
            "\' | \\",
            "[ | {",
            "] | }",
            "- | _",
            "= | +",
            "\\ | |"});
            this.key2.Location = new System.Drawing.Point(193, 76);
            this.key2.MaxDropDownItems = 40;
            this.key2.Name = "key2";
            this.key2.Size = new System.Drawing.Size(110, 21);
            this.key2.TabIndex = 5;
            this.key2.SelectedIndexChanged += new System.EventHandler(this.key2_SelectedIndexChanged);
            // 
            // key3Label
            // 
            this.key3Label.AutoSize = true;
            this.key3Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.key3Label.Location = new System.Drawing.Point(383, 0);
            this.key3Label.Name = "key3Label";
            this.key3Label.Size = new System.Drawing.Size(186, 73);
            this.key3Label.TabIndex = 6;
            this.key3Label.Text = "Key 3";
            this.key3Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // key3
            // 
            this.key3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.key3.FormattingEnabled = true;
            this.key3.Items.AddRange(new object[] {
            "None",
            "UP(KEYPAD)",
            "DOWN(KEYPAD)",
            "LEFT(KEYPAD)",
            "RIGHT(KEYPAD)",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12",
            "` | ~",
            "1 | !",
            "2 | @",
            "3 | #",
            "4 | $",
            "5 | %",
            "6 | ^",
            "7 | &",
            "8 | *",
            "9 | (",
            "0 | )",
            "ENTER",
            "BACKSPACE",
            "LSHIFT",
            "RSHIFT",
            "CTRL",
            "CAPS",
            "TAB",
            "WINDOWS",
            "SPACE",
            ", | <",
            ". | >",
            "/ | ?",
            "; | :",
            "\' | \\",
            "[ | {",
            "] | }",
            "- | _",
            "= | +",
            "\\ | |"});
            this.key3.Location = new System.Drawing.Point(383, 76);
            this.key3.MaxDropDownItems = 40;
            this.key3.Name = "key3";
            this.key3.Size = new System.Drawing.Size(110, 21);
            this.key3.TabIndex = 3;
            this.key3.SelectedIndexChanged += new System.EventHandler(this.key3_SelectedIndexChanged);
            // 
            // key2Label
            // 
            this.key2Label.AutoSize = true;
            this.key2Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.key2Label.Location = new System.Drawing.Point(193, 0);
            this.key2Label.Name = "key2Label";
            this.key2Label.Size = new System.Drawing.Size(184, 73);
            this.key2Label.TabIndex = 4;
            this.key2Label.Text = "Key 2";
            this.key2Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // key1
            // 
            this.key1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.key1.FormattingEnabled = true;
            this.key1.Items.AddRange(new object[] {
            "None",
            "UP(KEYPAD)",
            "DOWN(KEYPAD)",
            "LEFT(KEYPAD)",
            "RIGHT(KEYPAD)",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12",
            "` | ~",
            "1 | !",
            "2 | @",
            "3 | #",
            "4 | $",
            "5 | %",
            "6 | ^",
            "7 | &",
            "8 | *",
            "9 | (",
            "0 | )",
            "ENTER",
            "BACKSPACE",
            "LSHIFT",
            "RSHIFT",
            "CTRL",
            "CAPS",
            "TAB",
            "WINDOWS",
            "SPACE",
            ", | <",
            ". | >",
            "/ | ?",
            "; | :",
            "\' | \\",
            "[ | {",
            "] | }",
            "- | _",
            "= | +",
            "\\ | |"});
            this.key1.Location = new System.Drawing.Point(3, 76);
            this.key1.MaxDropDownItems = 40;
            this.key1.Name = "key1";
            this.key1.Size = new System.Drawing.Size(110, 21);
            this.key1.TabIndex = 1;
            this.key1.SelectedIndexChanged += new System.EventHandler(this.key1_SelectedIndexChanged);
            // 
            // key1Label
            // 
            this.key1Label.AutoSize = true;
            this.key1Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.key1Label.Location = new System.Drawing.Point(3, 0);
            this.key1Label.Name = "key1Label";
            this.key1Label.Size = new System.Drawing.Size(184, 73);
            this.key1Label.TabIndex = 2;
            this.key1Label.Text = "Key 1";
            this.key1Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // KeyboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "KeyboardControl";
            this.Size = new System.Drawing.Size(572, 146);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox key1;
        private System.Windows.Forms.Label key1Label;
        private System.Windows.Forms.ComboBox key2;
        private System.Windows.Forms.Label key3Label;
        private System.Windows.Forms.ComboBox key3;
        private System.Windows.Forms.Label key2Label;
    }
}
