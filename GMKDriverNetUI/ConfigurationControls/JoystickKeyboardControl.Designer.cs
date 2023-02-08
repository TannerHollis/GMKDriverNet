namespace GMKDriverNETUI.ConfigurationControls
{
    partial class JoystickKeyboardControl
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
            this.downKey = new System.Windows.Forms.ComboBox();
            this.downKeyLabel = new System.Windows.Forms.Label();
            this.upKey = new System.Windows.Forms.ComboBox();
            this.rightKeyLabel = new System.Windows.Forms.Label();
            this.rightKey = new System.Windows.Forms.ComboBox();
            this.upKeyLabel = new System.Windows.Forms.Label();
            this.leftKey = new System.Windows.Forms.ComboBox();
            this.leftKeyLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.downKey, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.downKeyLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.upKey, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.rightKeyLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.rightKey, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.upKeyLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.leftKey, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.leftKeyLabel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(572, 146);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // downKey
            // 
            this.downKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.downKey.FormattingEnabled = true;
            this.downKey.Items.AddRange(new object[] {
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
            this.downKey.Location = new System.Drawing.Point(193, 90);
            this.downKey.MaxDropDownItems = 40;
            this.downKey.Name = "downKey";
            this.downKey.Size = new System.Drawing.Size(110, 21);
            this.downKey.TabIndex = 8;
            this.downKey.SelectedIndexChanged += new System.EventHandler(this.KeyChanged);
            // 
            // downKeyLabel
            // 
            this.downKeyLabel.AutoSize = true;
            this.downKeyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.downKeyLabel.Location = new System.Drawing.Point(193, 58);
            this.downKeyLabel.Name = "downKeyLabel";
            this.downKeyLabel.Size = new System.Drawing.Size(184, 29);
            this.downKeyLabel.TabIndex = 7;
            this.downKeyLabel.Text = "Down";
            this.downKeyLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // upKey
            // 
            this.upKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.upKey.FormattingEnabled = true;
            this.upKey.Items.AddRange(new object[] {
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
            this.upKey.Location = new System.Drawing.Point(193, 32);
            this.upKey.MaxDropDownItems = 40;
            this.upKey.Name = "upKey";
            this.upKey.Size = new System.Drawing.Size(110, 21);
            this.upKey.TabIndex = 5;
            this.upKey.SelectedIndexChanged += new System.EventHandler(this.KeyChanged);
            // 
            // rightKeyLabel
            // 
            this.rightKeyLabel.AutoSize = true;
            this.rightKeyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightKeyLabel.Location = new System.Drawing.Point(383, 29);
            this.rightKeyLabel.Name = "rightKeyLabel";
            this.rightKeyLabel.Size = new System.Drawing.Size(186, 29);
            this.rightKeyLabel.TabIndex = 6;
            this.rightKeyLabel.Text = "Right";
            this.rightKeyLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // rightKey
            // 
            this.rightKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rightKey.FormattingEnabled = true;
            this.rightKey.Items.AddRange(new object[] {
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
            this.rightKey.Location = new System.Drawing.Point(383, 61);
            this.rightKey.MaxDropDownItems = 40;
            this.rightKey.Name = "rightKey";
            this.rightKey.Size = new System.Drawing.Size(110, 21);
            this.rightKey.TabIndex = 3;
            this.rightKey.SelectedIndexChanged += new System.EventHandler(this.KeyChanged);
            // 
            // upKeyLabel
            // 
            this.upKeyLabel.AutoSize = true;
            this.upKeyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upKeyLabel.Location = new System.Drawing.Point(193, 0);
            this.upKeyLabel.Name = "upKeyLabel";
            this.upKeyLabel.Size = new System.Drawing.Size(184, 29);
            this.upKeyLabel.TabIndex = 4;
            this.upKeyLabel.Text = "Up";
            this.upKeyLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // leftKey
            // 
            this.leftKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.leftKey.FormattingEnabled = true;
            this.leftKey.Items.AddRange(new object[] {
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
            this.leftKey.Location = new System.Drawing.Point(3, 61);
            this.leftKey.MaxDropDownItems = 40;
            this.leftKey.Name = "leftKey";
            this.leftKey.Size = new System.Drawing.Size(110, 21);
            this.leftKey.TabIndex = 1;
            this.leftKey.SelectedIndexChanged += new System.EventHandler(this.KeyChanged);
            // 
            // leftKeyLabel
            // 
            this.leftKeyLabel.AutoSize = true;
            this.leftKeyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftKeyLabel.Location = new System.Drawing.Point(3, 29);
            this.leftKeyLabel.Name = "leftKeyLabel";
            this.leftKeyLabel.Size = new System.Drawing.Size(184, 29);
            this.leftKeyLabel.TabIndex = 2;
            this.leftKeyLabel.Text = "Left";
            this.leftKeyLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // JoystickKeyboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "JoystickKeyboardControl";
            this.Size = new System.Drawing.Size(572, 146);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox leftKey;
        private System.Windows.Forms.Label leftKeyLabel;
        private System.Windows.Forms.ComboBox upKey;
        private System.Windows.Forms.Label rightKeyLabel;
        private System.Windows.Forms.ComboBox rightKey;
        private System.Windows.Forms.Label upKeyLabel;
        private System.Windows.Forms.ComboBox downKey;
        private System.Windows.Forms.Label downKeyLabel;
    }
}
