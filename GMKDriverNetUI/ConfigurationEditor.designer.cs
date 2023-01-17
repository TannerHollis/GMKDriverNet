namespace GMKDriverNetUI
{
    partial class configurationEditor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(configurationEditor));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Left");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Right");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Joystick Settings", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Left");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Right");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("TriggerSettings", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Button Bindings");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Joystick Bindings");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("TriggerBindings");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Bindings", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9});
            this.gridLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.serialNumber = new System.Windows.Forms.Label();
            this.serialNumberLabel = new System.Windows.Forms.Label();
            this.deviceTypeLabel = new System.Windows.Forms.Label();
            this.deviceType = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.configurationsGroupBox = new System.Windows.Forms.GroupBox();
            this.configsView = new System.Windows.Forms.ListView();
            this.configName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.defaultConfig = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.configsViewContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.setActiveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addConfigMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newConfigMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromExistingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeDefaultMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.bindingsTreeView = new System.Windows.Forms.TreeView();
            this.bindingEditorContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAsButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAsJoystickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAsTriggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAsKeyboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.joystickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.joystickAsButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.joystickAsJoystickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.joystickAsTriggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.joystickAsKeyboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triggerAsButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triggerAsJoystickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triggerAsTriggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triggerAsKeyboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeBindingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectionHelp = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.openConfigFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.activeConfig = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gridLayout.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.configurationsGroupBox.SuspendLayout();
            this.configsViewContextMenu.SuspendLayout();
            this.configurationSettingsGroupBox.SuspendLayout();
            this.bindingEditorContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridLayout
            // 
            this.gridLayout.ColumnCount = 2;
            this.gridLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.9872F));
            this.gridLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.01279F));
            this.gridLayout.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.gridLayout.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.gridLayout.Controls.Add(this.configurationSettingsGroupBox, 1, 1);
            this.gridLayout.Controls.Add(this.selectionHelp, 1, 0);
            this.gridLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridLayout.Location = new System.Drawing.Point(0, 0);
            this.gridLayout.Name = "gridLayout";
            this.gridLayout.RowCount = 2;
            this.gridLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.gridLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.gridLayout.Size = new System.Drawing.Size(1094, 691);
            this.gridLayout.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.66331F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.33669F));
            this.tableLayoutPanel2.Controls.Add(this.serialNumber, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.serialNumberLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.deviceTypeLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.deviceType, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(333, 270);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // serialNumber
            // 
            this.serialNumber.AutoSize = true;
            this.serialNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serialNumber.Location = new System.Drawing.Point(111, 245);
            this.serialNumber.Name = "serialNumber";
            this.serialNumber.Size = new System.Drawing.Size(219, 25);
            this.serialNumber.TabIndex = 3;
            this.serialNumber.Text = "Serial Number";
            this.serialNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // serialNumberLabel
            // 
            this.serialNumberLabel.AutoSize = true;
            this.serialNumberLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serialNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialNumberLabel.Location = new System.Drawing.Point(3, 245);
            this.serialNumberLabel.Name = "serialNumberLabel";
            this.serialNumberLabel.Size = new System.Drawing.Size(102, 25);
            this.serialNumberLabel.TabIndex = 2;
            this.serialNumberLabel.Text = "SN:";
            this.serialNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // deviceTypeLabel
            // 
            this.deviceTypeLabel.AutoSize = true;
            this.deviceTypeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deviceTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deviceTypeLabel.Location = new System.Drawing.Point(3, 220);
            this.deviceTypeLabel.Name = "deviceTypeLabel";
            this.deviceTypeLabel.Size = new System.Drawing.Size(102, 25);
            this.deviceTypeLabel.TabIndex = 0;
            this.deviceTypeLabel.Text = "Device:";
            this.deviceTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // deviceType
            // 
            this.deviceType.AutoSize = true;
            this.deviceType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deviceType.Location = new System.Drawing.Point(111, 220);
            this.deviceType.Name = "deviceType";
            this.deviceType.Size = new System.Drawing.Size(219, 25);
            this.deviceType.TabIndex = 1;
            this.deviceType.Text = "Device Type";
            this.deviceType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel2.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(64, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.saveButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.loadButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.configurationsGroupBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 279);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(333, 409);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveButton.Location = new System.Drawing.Point(212, 382);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loadButton.Location = new System.Drawing.Point(45, 382);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 3;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // configurationsGroupBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.configurationsGroupBox, 2);
            this.configurationsGroupBox.Controls.Add(this.configsView);
            this.configurationsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.configurationsGroupBox.Location = new System.Drawing.Point(3, 0);
            this.configurationsGroupBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.configurationsGroupBox.Name = "configurationsGroupBox";
            this.configurationsGroupBox.Size = new System.Drawing.Size(327, 376);
            this.configurationsGroupBox.TabIndex = 4;
            this.configurationsGroupBox.TabStop = false;
            this.configurationsGroupBox.Text = "Configurations";
            // 
            // configsView
            // 
            this.configsView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.configName,
            this.defaultConfig,
            this.activeConfig});
            this.configsView.ContextMenuStrip = this.configsViewContextMenu;
            this.configsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.configsView.FullRowSelect = true;
            this.configsView.HideSelection = false;
            this.configsView.Location = new System.Drawing.Point(3, 16);
            this.configsView.MultiSelect = false;
            this.configsView.Name = "configsView";
            this.configsView.Size = new System.Drawing.Size(321, 357);
            this.configsView.TabIndex = 1;
            this.configsView.UseCompatibleStateImageBehavior = false;
            this.configsView.View = System.Windows.Forms.View.Details;
            this.configsView.Click += new System.EventHandler(this.configsView_Click);
            // 
            // configName
            // 
            this.configName.Text = "Configuration Name";
            this.configName.Width = 124;
            // 
            // defaultConfig
            // 
            this.defaultConfig.Text = "Default Config";
            this.defaultConfig.Width = 87;
            // 
            // configsViewContextMenu
            // 
            this.configsViewContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setActiveMenuItem,
            this.addConfigMenuItem,
            this.renameMenuItem,
            this.removeMenuItem,
            this.makeDefaultMenuItem});
            this.configsViewContextMenu.Name = "configsViewContextMenu";
            this.configsViewContextMenu.Size = new System.Drawing.Size(174, 114);
            this.configsViewContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.configsViewContextMenu_Opening);
            // 
            // setActiveMenuItem
            // 
            this.setActiveMenuItem.Name = "setActiveMenuItem";
            this.setActiveMenuItem.Size = new System.Drawing.Size(173, 22);
            this.setActiveMenuItem.Text = "Set Active";
            this.setActiveMenuItem.Click += new System.EventHandler(this.setActiveMenuItem_Click);
            // 
            // addConfigMenuItem
            // 
            this.addConfigMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newConfigMenuItem,
            this.fromExistingMenuItem});
            this.addConfigMenuItem.Name = "addConfigMenuItem";
            this.addConfigMenuItem.Size = new System.Drawing.Size(173, 22);
            this.addConfigMenuItem.Text = "Add Configuration";
            // 
            // newConfigMenuItem
            // 
            this.newConfigMenuItem.Name = "newConfigMenuItem";
            this.newConfigMenuItem.Size = new System.Drawing.Size(155, 22);
            this.newConfigMenuItem.Text = "New...";
            this.newConfigMenuItem.Click += new System.EventHandler(this.newConfigMenuItem_Click);
            // 
            // fromExistingMenuItem
            // 
            this.fromExistingMenuItem.Name = "fromExistingMenuItem";
            this.fromExistingMenuItem.Size = new System.Drawing.Size(155, 22);
            this.fromExistingMenuItem.Text = "From Existing...";
            this.fromExistingMenuItem.Click += new System.EventHandler(this.fromExistingMenuItem_Click);
            // 
            // renameMenuItem
            // 
            this.renameMenuItem.Name = "renameMenuItem";
            this.renameMenuItem.Size = new System.Drawing.Size(173, 22);
            this.renameMenuItem.Text = "Rename...";
            this.renameMenuItem.Click += new System.EventHandler(this.renameMenuItem_Click);
            // 
            // removeMenuItem
            // 
            this.removeMenuItem.Name = "removeMenuItem";
            this.removeMenuItem.Size = new System.Drawing.Size(173, 22);
            this.removeMenuItem.Text = "Remove";
            this.removeMenuItem.Click += new System.EventHandler(this.removeMenuItem_Click);
            // 
            // makeDefaultMenuItem
            // 
            this.makeDefaultMenuItem.Name = "makeDefaultMenuItem";
            this.makeDefaultMenuItem.Size = new System.Drawing.Size(173, 22);
            this.makeDefaultMenuItem.Text = "Make Default";
            this.makeDefaultMenuItem.Click += new System.EventHandler(this.makeDefaultMenuItem_Click);
            // 
            // configurationSettingsGroupBox
            // 
            this.configurationSettingsGroupBox.Controls.Add(this.bindingsTreeView);
            this.configurationSettingsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.configurationSettingsGroupBox.Location = new System.Drawing.Point(342, 279);
            this.configurationSettingsGroupBox.Name = "configurationSettingsGroupBox";
            this.configurationSettingsGroupBox.Size = new System.Drawing.Size(749, 409);
            this.configurationSettingsGroupBox.TabIndex = 3;
            this.configurationSettingsGroupBox.TabStop = false;
            this.configurationSettingsGroupBox.Text = "Configuration Settings";
            // 
            // bindingsTreeView
            // 
            this.bindingsTreeView.ContextMenuStrip = this.bindingEditorContextMenu;
            this.bindingsTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bindingsTreeView.FullRowSelect = true;
            this.bindingsTreeView.Indent = 20;
            this.bindingsTreeView.Location = new System.Drawing.Point(3, 16);
            this.bindingsTreeView.Name = "bindingsTreeView";
            treeNode1.Name = "leftJoystick";
            treeNode1.Text = "Left";
            treeNode2.Name = "rightJoystick";
            treeNode2.Text = "Right";
            treeNode3.Name = "joystickSettings";
            treeNode3.Text = "Joystick Settings";
            treeNode4.Name = "leftTrigger";
            treeNode4.Text = "Left";
            treeNode5.Name = "rightTrigger";
            treeNode5.Text = "Right";
            treeNode6.ImageIndex = 1;
            treeNode6.Name = "triggerSettings";
            treeNode6.Text = "TriggerSettings";
            treeNode7.Name = "buttonBindings";
            treeNode7.Text = "Button Bindings";
            treeNode8.Name = "joystickBindings";
            treeNode8.Text = "Joystick Bindings";
            treeNode9.Name = "triggerBindings";
            treeNode9.Text = "TriggerBindings";
            treeNode10.ImageKey = "trigger.png";
            treeNode10.Name = "bindings";
            treeNode10.Text = "Bindings";
            this.bindingsTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode10});
            this.bindingsTreeView.Size = new System.Drawing.Size(743, 390);
            this.bindingsTreeView.TabIndex = 1;
            this.bindingsTreeView.DoubleClick += new System.EventHandler(this.bindingsTreeView_DoubleClick);
            // 
            // bindingEditorContextMenu
            // 
            this.bindingEditorContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeBindingToolStripMenuItem});
            this.bindingEditorContextMenu.Name = "bindingEditorContextMenu";
            this.bindingEditorContextMenu.Size = new System.Drawing.Size(162, 48);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonToolStripMenuItem,
            this.joystickToolStripMenuItem,
            this.triggerToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.addToolStripMenuItem.Text = "Add Binding";
            // 
            // buttonToolStripMenuItem
            // 
            this.buttonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonAsButtonToolStripMenuItem,
            this.buttonAsJoystickToolStripMenuItem,
            this.buttonAsTriggerToolStripMenuItem,
            this.buttonAsKeyboardToolStripMenuItem});
            this.buttonToolStripMenuItem.Name = "buttonToolStripMenuItem";
            this.buttonToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.buttonToolStripMenuItem.Text = "Button";
            // 
            // buttonAsButtonToolStripMenuItem
            // 
            this.buttonAsButtonToolStripMenuItem.Name = "buttonAsButtonToolStripMenuItem";
            this.buttonAsButtonToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.buttonAsButtonToolStripMenuItem.Text = "ButtonAsButton";
            // 
            // buttonAsJoystickToolStripMenuItem
            // 
            this.buttonAsJoystickToolStripMenuItem.Name = "buttonAsJoystickToolStripMenuItem";
            this.buttonAsJoystickToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.buttonAsJoystickToolStripMenuItem.Text = "ButtonAsJoystick";
            // 
            // buttonAsTriggerToolStripMenuItem
            // 
            this.buttonAsTriggerToolStripMenuItem.Name = "buttonAsTriggerToolStripMenuItem";
            this.buttonAsTriggerToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.buttonAsTriggerToolStripMenuItem.Text = "ButtonAsTrigger";
            // 
            // buttonAsKeyboardToolStripMenuItem
            // 
            this.buttonAsKeyboardToolStripMenuItem.Name = "buttonAsKeyboardToolStripMenuItem";
            this.buttonAsKeyboardToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.buttonAsKeyboardToolStripMenuItem.Text = "ButtonAsKeyboard";
            // 
            // joystickToolStripMenuItem
            // 
            this.joystickToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.joystickAsButtonToolStripMenuItem,
            this.joystickAsJoystickToolStripMenuItem,
            this.joystickAsTriggerToolStripMenuItem,
            this.joystickAsKeyboardToolStripMenuItem});
            this.joystickToolStripMenuItem.Name = "joystickToolStripMenuItem";
            this.joystickToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.joystickToolStripMenuItem.Text = "Joystick";
            // 
            // joystickAsButtonToolStripMenuItem
            // 
            this.joystickAsButtonToolStripMenuItem.Name = "joystickAsButtonToolStripMenuItem";
            this.joystickAsButtonToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.joystickAsButtonToolStripMenuItem.Text = "JoystickAsButton";
            // 
            // joystickAsJoystickToolStripMenuItem
            // 
            this.joystickAsJoystickToolStripMenuItem.Name = "joystickAsJoystickToolStripMenuItem";
            this.joystickAsJoystickToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.joystickAsJoystickToolStripMenuItem.Text = "JoystickAsJoystick";
            // 
            // joystickAsTriggerToolStripMenuItem
            // 
            this.joystickAsTriggerToolStripMenuItem.Name = "joystickAsTriggerToolStripMenuItem";
            this.joystickAsTriggerToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.joystickAsTriggerToolStripMenuItem.Text = "JoystickAsTrigger";
            // 
            // joystickAsKeyboardToolStripMenuItem
            // 
            this.joystickAsKeyboardToolStripMenuItem.Name = "joystickAsKeyboardToolStripMenuItem";
            this.joystickAsKeyboardToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.joystickAsKeyboardToolStripMenuItem.Text = "JoystickAsKeyboard";
            // 
            // triggerToolStripMenuItem
            // 
            this.triggerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.triggerAsButtonToolStripMenuItem,
            this.triggerAsJoystickToolStripMenuItem,
            this.triggerAsTriggerToolStripMenuItem,
            this.triggerAsKeyboardToolStripMenuItem});
            this.triggerToolStripMenuItem.Name = "triggerToolStripMenuItem";
            this.triggerToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.triggerToolStripMenuItem.Text = "Trigger";
            // 
            // triggerAsButtonToolStripMenuItem
            // 
            this.triggerAsButtonToolStripMenuItem.Name = "triggerAsButtonToolStripMenuItem";
            this.triggerAsButtonToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.triggerAsButtonToolStripMenuItem.Text = "TriggerAsButton";
            // 
            // triggerAsJoystickToolStripMenuItem
            // 
            this.triggerAsJoystickToolStripMenuItem.Name = "triggerAsJoystickToolStripMenuItem";
            this.triggerAsJoystickToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.triggerAsJoystickToolStripMenuItem.Text = "TriggerAsJoystick";
            // 
            // triggerAsTriggerToolStripMenuItem
            // 
            this.triggerAsTriggerToolStripMenuItem.Name = "triggerAsTriggerToolStripMenuItem";
            this.triggerAsTriggerToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.triggerAsTriggerToolStripMenuItem.Text = "TriggerAsTrigger";
            // 
            // triggerAsKeyboardToolStripMenuItem
            // 
            this.triggerAsKeyboardToolStripMenuItem.Name = "triggerAsKeyboardToolStripMenuItem";
            this.triggerAsKeyboardToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.triggerAsKeyboardToolStripMenuItem.Text = "TriggerAsKeyboard";
            // 
            // removeBindingToolStripMenuItem
            // 
            this.removeBindingToolStripMenuItem.Name = "removeBindingToolStripMenuItem";
            this.removeBindingToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.removeBindingToolStripMenuItem.Text = "Remove Binding";
            // 
            // selectionHelp
            // 
            this.selectionHelp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectionHelp.AutoSize = true;
            this.selectionHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectionHelp.Location = new System.Drawing.Point(528, 125);
            this.selectionHelp.Name = "selectionHelp";
            this.selectionHelp.Size = new System.Drawing.Size(376, 26);
            this.selectionHelp.TabIndex = 4;
            this.selectionHelp.Text = "Select a Configuration Setting to Start\r\n";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "button.png");
            this.imageList1.Images.SetKeyName(1, "joystick.png");
            this.imageList1.Images.SetKeyName(2, "trigger.png");
            // 
            // openConfigFileDialog
            // 
            this.openConfigFileDialog.FileName = "openConfigFileDialog";
            this.openConfigFileDialog.Filter = "config files (*.json)|*.json";
            this.openConfigFileDialog.InitialDirectory = "Configs";
            // 
            // activeConfig
            // 
            this.activeConfig.Text = "Active Config";
            this.activeConfig.Width = 93;
            // 
            // configurationEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 691);
            this.Controls.Add(this.gridLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "configurationEditor";
            this.Text = "Configuration Editor";
            this.gridLayout.ResumeLayout(false);
            this.gridLayout.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.configurationsGroupBox.ResumeLayout(false);
            this.configsViewContextMenu.ResumeLayout(false);
            this.configurationSettingsGroupBox.ResumeLayout(false);
            this.bindingEditorContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel gridLayout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label serialNumberLabel;
        private System.Windows.Forms.Label deviceTypeLabel;
        private System.Windows.Forms.Label deviceType;
        private System.Windows.Forms.ListView configsView;
        private System.Windows.Forms.ColumnHeader configName;
        private System.Windows.Forms.ColumnHeader defaultConfig;
        private System.Windows.Forms.Label serialNumber;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TreeView bindingsTreeView;
        private System.Windows.Forms.ContextMenuStrip bindingEditorContextMenu;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buttonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buttonAsButtonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buttonAsJoystickToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buttonAsTriggerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buttonAsKeyboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem joystickToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem joystickAsButtonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem joystickAsJoystickToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem joystickAsTriggerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem joystickAsKeyboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem triggerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem triggerAsButtonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem triggerAsJoystickToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem triggerAsTriggerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem triggerAsKeyboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeBindingToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.GroupBox configurationsGroupBox;
        private System.Windows.Forms.GroupBox configurationSettingsGroupBox;
        private System.Windows.Forms.Label selectionHelp;
        private System.Windows.Forms.ContextMenuStrip configsViewContextMenu;
        private System.Windows.Forms.ToolStripMenuItem addConfigMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newConfigMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromExistingMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeDefaultMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setActiveMenuItem;
        private System.Windows.Forms.OpenFileDialog openConfigFileDialog;
        private System.Windows.Forms.ColumnHeader activeConfig;
    }
}