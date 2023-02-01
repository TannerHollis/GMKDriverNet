using GMKDriverNET;
using GMKDriverNET.Bindings;
using GMKDriverNETUI.ConfigurationControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GMKDriverNETUI
{
    public partial class configurationEditor : Form
    {
        private GMKDevice _device;
        private DeviceConfigCollection _configAssociation;
        private DeviceConfig _currentConfig;

        // Define Widgets
        private ButtonAsButtonControl _buttonAsButtonControl;
        private ButtonAsJoystickControl _buttonAsJoystickControl;
        private ButtonAsTriggerControl _buttonAsTriggerControl;
        private ButtonAsKeyboardControl _buttonAsKeyboardControl;
        private JoystickAsButtonControl _joystickAsButtonControl;
        private JoystickAsJoystickControl _joystickAsJoystickControl;
        private JoystickAsTriggerControl _joystickAsTriggerControl;
        private JoystickAsKeyboardControl _joystickAsKeyboardControl;
        private TriggerAsButtonControl _triggerAsButtonControl;
        private TriggerAsJoystickControl _triggerAsJoystickControl;
        private TriggerAsTriggerControl _triggerAsTriggerControl;
        private TriggerAsKeyboardControl _triggerAsKeyboardControl;

        // Define TreeNodes
        private TreeNode _buttonBindingsNode;
        private TreeNode _joystickBindingsNode;
        private TreeNode _triggerBindingsNode;

        private bool _initialized;

        public configurationEditor(GMKDevice device)
        {
            InitializeComponent();

            _device = device;
        }

        private void UpdateTextWithLanguage()
        {
            this.Text = LanguageHelper.LookupPhrase("configEditor");
            
            // Config Editor Window
            serialNumberLabel.Text = LanguageHelper.LookupPhrase("serialNumber");
            gameAssociationLabel.Text = LanguageHelper.LookupPhrase("gameAssoc");
            deviceTypeLabel.Text = LanguageHelper.LookupPhrase("deviceType");
            configurationsGroupBox.Text = LanguageHelper.LookupPhrase("configs");
            configsView.Columns[0].Text = LanguageHelper.LookupPhrase("configName");
            configsView.Columns[1].Text = LanguageHelper.LookupPhrase("defaultConfig");
            loadButton.Text = LanguageHelper.LookupPhrase("load");
            saveButton.Text = LanguageHelper.LookupPhrase("save");
            selectionHelp.Text = LanguageHelper.LookupPhrase("selectionHelp");
            configurationSettingsGroupBox.Text = LanguageHelper.LookupPhrase("configSettings");
            _joystickBindingsNode.Text = LanguageHelper.LookupPhrase("joystickBindings");
            _buttonBindingsNode.Text = LanguageHelper.LookupPhrase("buttonBindings");
            _triggerBindingsNode.Text = LanguageHelper.LookupPhrase("triggerBindings");

            // Config Context menu
            setActiveMenuItem.Text = LanguageHelper.LookupPhrase("setActive");
            addConfigMenuItem.Text = LanguageHelper.LookupPhrase("addConfig");
            newConfigMenuItem.Text = LanguageHelper.LookupPhrase("newConfig");
            fromExistingMenuItem.Text = LanguageHelper.LookupPhrase("newConfigFromExisting");
            renameMenuItem.Text = LanguageHelper.LookupPhrase("renameConfig");
            removeMenuItem.Text = LanguageHelper.LookupPhrase("removeConfig");
            makeDefaultMenuItem.Text = LanguageHelper.LookupPhrase("makeDefault");

            // Binding context menu
            addBindingToolStripMenuItem.Text = LanguageHelper.LookupPhrase("addBinding");
            removeBindingToolStripMenuItem.Text = LanguageHelper.LookupPhrase("removeBinding");
            buttonToolStripMenuItem.Text = LanguageHelper.LookupPhrase("button");
            joystickToolStripMenuItem.Text = LanguageHelper.LookupPhrase("joystick");
            triggerToolStripMenuItem.Text = LanguageHelper.LookupPhrase("trigger");
            buttonAsButtonToolStripMenuItem.Text = LanguageHelper.LookupPhrase("buttonAsButton");
            buttonAsJoystickToolStripMenuItem.Text = LanguageHelper.LookupPhrase("buttonAsJoystick");
            buttonAsTriggerToolStripMenuItem.Text = LanguageHelper.LookupPhrase("buttonAsTrigger");
            buttonAsKeyboardToolStripMenuItem.Text = LanguageHelper.LookupPhrase("buttonAsKeyboard");
            joystickAsButtonToolStripMenuItem.Text = LanguageHelper.LookupPhrase("joystickAsButton");
            joystickAsJoystickToolStripMenuItem.Text = LanguageHelper.LookupPhrase("joystickAsJoystick");
            joystickAsTriggerToolStripMenuItem.Text = LanguageHelper.LookupPhrase("joystickAsTrigger");
            joystickAsKeyboardToolStripMenuItem.Text = LanguageHelper.LookupPhrase("joystickAsKeyboard");
            triggerAsButtonToolStripMenuItem.Text = LanguageHelper.LookupPhrase("triggerAsButton");
            triggerAsJoystickToolStripMenuItem.Text = LanguageHelper.LookupPhrase("triggerAsJoystick");
            triggerAsTriggerToolStripMenuItem.Text = LanguageHelper.LookupPhrase("triggerAsTrigger");
            triggerAsKeyboardToolStripMenuItem.Text = LanguageHelper.LookupPhrase("triggerAsKeyboard");
        }

        private void SetConfigsView()
        {
            _configAssociation = GMKDriver.DeviceList.LookupSerialNumber(_device.SerialNumber);

            configsView.Items.Clear();

            foreach (DeviceConfig config in _configAssociation.Configs)
            {
                ListViewItem item = new ListViewItem(config.name);
                item.Tag = config;

                if(config.name == _device.Config.name)
                {
                    item.Font = new Font(item.Font, FontStyle.Bold);
                }

                if (config.name == _configAssociation.defaultConfigFile)
                {
                    ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem();
                    subItem.Text = LanguageHelper.LookupPhrase("default");
                    item.SubItems.Add(subItem);
                }

                configsView.Items.Add(item);
            }
        }

        private void LoadWidgets()
        {
            // Add ButtonAsButton Widget
            _buttonAsButtonControl = new ButtonAsButtonControl();
            _buttonAsButtonControl.Dock = DockStyle.Fill;
            gridLayout.Controls.Add(_buttonAsButtonControl, 1, 0);

            // Add ButtonAsJoystick Widget
            _buttonAsJoystickControl = new ButtonAsJoystickControl();
            _buttonAsJoystickControl.Dock = DockStyle.Fill;
            gridLayout.Controls.Add(_buttonAsJoystickControl, 1, 0);

            // Add ButtonAsTrigger Widget
            _buttonAsTriggerControl = new ButtonAsTriggerControl();
            _buttonAsTriggerControl.Dock = DockStyle.Fill;
            gridLayout.Controls.Add(_buttonAsTriggerControl, 1, 0);

            // Add ButtonAsKeyboard Widget
            _buttonAsKeyboardControl = new ButtonAsKeyboardControl();
            _buttonAsKeyboardControl.Dock = DockStyle.Fill;
            gridLayout.Controls.Add(_buttonAsKeyboardControl, 1, 0);

            // Add JoystickAsButton Widget
            _joystickAsButtonControl = new JoystickAsButtonControl();
            _joystickAsButtonControl.Dock = DockStyle.Fill;
            gridLayout.Controls.Add(_joystickAsButtonControl, 1, 0);

            // Add JoystickAsJoystick Widget
            _joystickAsJoystickControl = new JoystickAsJoystickControl();
            _joystickAsJoystickControl.Dock = DockStyle.Fill;
            gridLayout.Controls.Add(_joystickAsJoystickControl, 1, 0);

            // Add JoystickAsTrigger Widget
            _joystickAsTriggerControl = new JoystickAsTriggerControl();
            _joystickAsTriggerControl.Dock = DockStyle.Fill;
            gridLayout.Controls.Add(_joystickAsTriggerControl, 1, 0);

            // Add JoystickAsKeyboard Widget
            _joystickAsKeyboardControl = new JoystickAsKeyboardControl();
            _joystickAsKeyboardControl.Dock = DockStyle.Fill;
            gridLayout.Controls.Add(_joystickAsKeyboardControl, 1, 0);

            // Add TriggerAsButton Widget
            _triggerAsButtonControl = new TriggerAsButtonControl();
            _triggerAsButtonControl.Dock = DockStyle.Fill;
            gridLayout.Controls.Add(_triggerAsButtonControl, 1, 0);

            // Add TriggerAsJoystick Widget
            _triggerAsJoystickControl = new TriggerAsJoystickControl();
            _triggerAsJoystickControl.Dock = DockStyle.Fill;
            gridLayout.Controls.Add(_triggerAsJoystickControl, 1, 0);

            // Add TriggerAsTrigger Widget
            _triggerAsTriggerControl = new TriggerAsTriggerControl();
            _triggerAsTriggerControl.Dock = DockStyle.Fill;
            gridLayout.Controls.Add(_triggerAsTriggerControl, 1, 0);

            // Add TriggerAsKeyboard Widget
            _triggerAsKeyboardControl = new TriggerAsKeyboardControl();
            _triggerAsKeyboardControl.Dock = DockStyle.Fill;
            gridLayout.Controls.Add(_triggerAsKeyboardControl, 1, 0);

            // Hide all widgets
            CloseWidgets(false);
        }

        private void CloseWidgets(bool viewSelectionHelp)
        {
            _buttonAsButtonControl.Visible &= false;
            _buttonAsJoystickControl.Visible &= false;
            _buttonAsTriggerControl.Visible &= false;
            _buttonAsKeyboardControl.Visible &= false;

            _joystickAsButtonControl.Visible &= false;
            _joystickAsJoystickControl.Visible &= false;
            _joystickAsTriggerControl.Visible &= false;
            _joystickAsKeyboardControl.Visible &= false;

            _triggerAsButtonControl.Visible &= false;
            _triggerAsJoystickControl.Visible &= false;
            _triggerAsTriggerControl.Visible &= false;
            _triggerAsKeyboardControl.Visible &= false;

            selectionHelp.Visible = viewSelectionHelp;
        }

        private void LoadConfiguration(DeviceConfig config)
        {
            CloseWidgets(true);

            currentConfigName.Text = config.name;
            serialNumber.Text = _device.SerialNumber;
            deviceType.Text = _device.Type.ToString();

            gameAssociationEnabled.Checked = config.gameAssociationEnabled;
            if(config.gameAssociationEnabled)
                gameAssociationName.Text = config.gameAssociation;
            else
                gameAssociationName.Text = "";
            gameAssociationName.Enabled = config.gameAssociationEnabled;

            _currentConfig = config;

            // Clear bindings tree view
            bindingsTreeView.Nodes.Clear();

            // Declare bindings parents
            _buttonBindingsNode = new TreeNode(LanguageHelper.LookupPhrase("buttonBindings"));
            _joystickBindingsNode = new TreeNode(LanguageHelper.LookupPhrase("joystickBindings"));
            _triggerBindingsNode = new TreeNode(LanguageHelper.LookupPhrase("triggerBindings"));

            if(_currentConfig.type == GMKControllerType.Joystick)
            {
                bindingsTreeView.Nodes.Add(_buttonBindingsNode);
                bindingsTreeView.Nodes.Add(_joystickBindingsNode);
            }
            if (_currentConfig.type == GMKControllerType.Controller)
            {
                bindingsTreeView.Nodes.Add(_triggerBindingsNode);
            }

            // Get Button Bindings
            {
                TreeNode buttonBindings = _buttonBindingsNode;
                buttonBindings.Nodes.Clear();

                // Add ButtonAsButtons
                foreach (ButtonAsButton asButton in config.buttons.asButtons)
                {
                    TreeNode node = new TreeNode(asButton.ToString());
                    node.Tag = asButton;
                    buttonBindings.Nodes.Add(node);
                }

                // Add ButtonAsJoysticks
                foreach (ButtonAsJoystick asJoystick in config.buttons.asJoysticks)
                {
                    TreeNode node = new TreeNode(asJoystick.ToString());
                    node.Tag = asJoystick;
                    buttonBindings.Nodes.Add(node);
                }

                // Add ButtonAsTriggers
                foreach (ButtonAsTrigger asTrigger in config.buttons.asTriggers)
                {
                    TreeNode node = new TreeNode(asTrigger.ToString());
                    node.Tag = asTrigger;
                    buttonBindings.Nodes.Add(node);
                }

                // Add JoystickAsKeyboards
                foreach (ButtonAsKeyboard asKeyboard in config.buttons.asKeyboards)
                {
                    TreeNode node = new TreeNode(asKeyboard.ToString());
                    node.Tag = asKeyboard;
                    buttonBindings.Nodes.Add(node);
                }
            }

            // Get Joystick Bindings
            {
                TreeNode joystickBindings = _joystickBindingsNode;
                joystickBindings.Nodes.Clear();

                // Add JoystickAsButtons
                foreach (JoystickAsButton asButton in config.joysticks.asButtons)
                {
                    TreeNode node = new TreeNode(asButton.ToString());
                    node.Tag = asButton;
                    joystickBindings.Nodes.Add(node);
                }

                // Add JoystickAsJoysticks
                foreach (JoystickAsJoystick asJoystick in config.joysticks.asJoysticks)
                {
                    TreeNode node = new TreeNode(asJoystick.ToString());
                    node.Tag = asJoystick;
                    joystickBindings.Nodes.Add(node);
                }

                // Add JoystickAsTriggers
                foreach (JoystickAsTrigger asTrigger in config.joysticks.asTriggers)
                {
                    TreeNode node = new TreeNode(asTrigger.ToString());
                    node.Tag = asTrigger;
                    joystickBindings.Nodes.Add(node);
                }

                // Add JoystickAsKeyboards
                foreach (JoystickAsKeyboard asKeyboard in config.joysticks.asKeyboards)
                {
                    TreeNode node = new TreeNode(asKeyboard.ToString());
                    node.Tag = asKeyboard;
                    joystickBindings.Nodes.Add(node);
                }
            }

            // Get Trigger Bindings
            {
                TreeNode triggerBindings = _triggerBindingsNode;
                triggerBindings.Nodes.Clear();

                // Add TriggerAsButtons
                foreach (TriggerAsButton asButton in config.triggers.asButtons)
                {
                    TreeNode node = new TreeNode(asButton.ToString());
                    node.Tag = asButton;
                    triggerBindings.Nodes.Add(node);
                }

                // Add TriggerAsJoysticks
                foreach (TriggerAsJoystick asJoystick in config.triggers.asJoysticks)
                {
                    TreeNode node = new TreeNode(asJoystick.ToString());
                    node.Tag = asJoystick;
                    triggerBindings.Nodes.Add(node);
                }

                // Add TriggerAsTriggers
                foreach (TriggerAsTrigger asTrigger in config.triggers.asTriggers)
                {
                    TreeNode node = new TreeNode(asTrigger.ToString());
                    node.Tag = asTrigger;
                    triggerBindings.Nodes.Add(node);
                }

                // Add TriggerAsKeyboards
                foreach (TriggerAsKeyboard asKeyboard in config.triggers.asKeyboards)
                {
                    TreeNode node = new TreeNode(asKeyboard.ToString());
                    node.Tag = asKeyboard;
                    triggerBindings.Nodes.Add(node);
                }
            }

            bindingsTreeView.ExpandAll();
        }

        private void bindingsTreeView_DoubleClick(object sender, EventArgs e)
        {
            if (bindingsTreeView.SelectedNode == null)
                return;

            if (bindingsTreeView.SelectedNode.Tag != null)
            {
                selectionHelp.Visible &= false;
                CloseWidgets(false);

                object node = bindingsTreeView.SelectedNode;
                object type = bindingsTreeView.SelectedNode.Tag;

                switch (type)
                {
                    case ButtonAsButton binding:
                        _buttonAsButtonControl.LoadWidget((TreeNode)node, _currentConfig);
                        return;

                    case ButtonAsJoystick binding:
                        _buttonAsJoystickControl.LoadWidget((TreeNode)node, _currentConfig);
                        return;

                    case ButtonAsTrigger binding:
                        _buttonAsTriggerControl.LoadWidget((TreeNode)node, _currentConfig);
                        return;

                    case ButtonAsKeyboard binding:
                        _buttonAsKeyboardControl.LoadWidget((TreeNode)node, _currentConfig);
                        return;

                    case JoystickAsButton binding:
                        _joystickAsButtonControl.LoadWidget((TreeNode)node, _currentConfig);
                        return;

                    case JoystickAsJoystick binding:
                        _joystickAsJoystickControl.LoadWidget((TreeNode)node, _currentConfig);
                        return;

                    case JoystickAsTrigger binding:
                        _joystickAsTriggerControl.LoadWidget((TreeNode)node, _currentConfig);
                        return;

                    case JoystickAsKeyboard binding:
                        _joystickAsKeyboardControl.LoadWidget((TreeNode)node, _currentConfig);
                        return;

                    case TriggerAsButton binding:
                        _triggerAsButtonControl.LoadWidget((TreeNode)node, _currentConfig);
                        return;

                    case TriggerAsJoystick binding:
                        _triggerAsJoystickControl.LoadWidget((TreeNode)node, _currentConfig);
                        return;

                    case TriggerAsTrigger binding:
                        _triggerAsTriggerControl.LoadWidget((TreeNode)node, _currentConfig);
                        return;

                    case TriggerAsKeyboard binding:
                        _triggerAsKeyboardControl.LoadWidget((TreeNode)node, _currentConfig);
                        return;
                }

                selectionHelp.Visible = true;
            }
        }

        private void configsView_Click(object sender, EventArgs e)
        {
            if(configsView.SelectedItems.Count > 0)
            {
                DeviceConfig selectedConfig = (DeviceConfig)configsView.SelectedItems[0].Tag;
                if (selectedConfig.name == _currentConfig.name)
                {
                    loadButton.Enabled = false;
                }
                else
                {
                    loadButton.Enabled = true;
                }
            }
        }

        private void configsViewContextMenu_Opening(object sender, CancelEventArgs e)
        {
            if(configsView.SelectedItems.Count == 0)
            {
                renameMenuItem.Enabled &= false;
                removeMenuItem.Enabled &= false;
                makeDefaultMenuItem.Enabled &= false;
                setActiveMenuItem.Enabled &= false;
            }
            else
            {
                DeviceConfig config = (DeviceConfig)configsView.SelectedItems[0].Tag;

                removeMenuItem.Enabled = (config.name != _device.Config.name) && (config.name != _configAssociation.defaultConfigFile);
                makeDefaultMenuItem.Enabled = config.name != _configAssociation.defaultConfigFile;
                setActiveMenuItem.Enabled = config.name != _device.Config.name;
                renameMenuItem.Enabled = true;
            }
        }

        private void newConfigMenuItem_Click(object sender, EventArgs e)
        {
            ConfigNameWindow configNameWindow = new ConfigNameWindow();
            configNameWindow.ShowDialog();

            if(configNameWindow.ConfigurationName != string.Empty && configNameWindow.DialogResult == DialogResult.OK)
            {
                if(_device.Type == GMKControllerType.Joystick)
                {
                    DeviceConfig config = DeviceConfig.DefaultJoystick;
                    config.name = configNameWindow.ConfigurationName;
                    GMKDriver.DeviceList.AddConfiguration(_device.SerialNumber, config, configNameWindow.MakeDefault);
                    LoadConfiguration(config);
                    SetConfigsView();
                }

                if (_device.Type == GMKControllerType.Controller)
                {
                    DeviceConfig config = DeviceConfig.DefaultController;
                    config.name = configNameWindow.ConfigurationName;
                    GMKDriver.DeviceList.AddConfiguration(_device.SerialNumber, config, configNameWindow.MakeDefault);
                    LoadConfiguration(config);
                    SetConfigsView();
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to overwrite configuration?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                _currentConfig.ToFile();
                if(_currentConfig.name == _device.Config.name)
                {
                    _device.Config = _currentConfig;
                }
                SetConfigsView();
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            DeviceConfig config = (DeviceConfig)configsView.SelectedItems[0].Tag;
            LoadConfiguration(config);
        }

        private void configsView_DoubleClick(object sender, EventArgs e)
        {
            loadButton_Click(sender, e);
        }

        private void renameMenuItem_Click(object sender, EventArgs e)
        {
            DeviceConfig config = (DeviceConfig)configsView.SelectedItems[0].Tag;

            // Initialize ConfigNameWindow
            ConfigNameWindow configNameWindow = new ConfigNameWindow();
            configNameWindow.LoadWindow(config.name, GMKDriver.DeviceList.IsConfigurationDefault(_device.SerialNumber, config));

            // Show ConfigName Window
            configNameWindow.ShowDialog();
            
            // If Dialog Result is valid, rename config 
            if (configNameWindow.DialogResult == DialogResult.OK)
            {
                GMKDriver.DeviceList.RenameConfiguration(_device.SerialNumber, config, configNameWindow.ConfigurationName);
                if(configNameWindow.MakeDefault)
                {
                    GMKDriver.DeviceList.SetDefaultConfiguration(_device.SerialNumber, config);
                }
                SetConfigsView();
                LoadConfiguration(config);
            }
        }

        private void removeMenuItem_Click(object sender, EventArgs e)
        {
            // If no item is selected, return
            if (configsView.Items.Count == 1)
            {
                return;
            }
            else // Otherwise remove selected item
            {
                DeviceConfig config = (DeviceConfig)configsView.SelectedItems[0].Tag;

                DialogResult result = MessageBox.Show("Delete this from the hard drive?", "Remove Configuration", MessageBoxButtons.YesNoCancel);

                // If user selected cancel, return
                if(result == DialogResult.Cancel)
                {
                    return;
                }

                // Remove confiugration
                GMKDriver.DeviceList.RemoveConfiguration(_device.SerialNumber, config, result == DialogResult.Yes);
                
                // Reset configs view
                SetConfigsView();
            }
        }

        private void setActiveMenuItem_Click(object sender, EventArgs e)
        {
            // Set the device's current active driver configuration
            DeviceConfig config = (DeviceConfig)configsView.SelectedItems[0].Tag;
            _device.Config = config;
            SetConfigsView();
        }

        private void fromExistingMenuItem_Click(object sender, EventArgs e)
        {
            // Initialize the open folder directory to the default path
            openConfigFileDialog.InitialDirectory = DeviceConfig.GetDeviceConfigFolder();
            DialogResult result = openConfigFileDialog.ShowDialog();
            
            // If file was selected, try opening file.
            if(result == DialogResult.OK)
            {
                string configName = Path.GetFileNameWithoutExtension(openConfigFileDialog.FileName);
                DeviceConfig config = DeviceConfig.FromFile(configName, _device.Type);
                GMKDriver.DeviceList.AddConfiguration(_device.SerialNumber, config, false);
                SetConfigsView();
            }
        }

        private void makeDefaultMenuItem_Click(object sender, EventArgs e)
        {
            DeviceConfig config = (DeviceConfig)configsView.SelectedItems[0].Tag;
            GMKDriver.DeviceList.SetDefaultConfiguration(_device.SerialNumber, config);
            SetConfigsView();
        }

        private void buttonAsButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _currentConfig.buttons.asButtons.Add(new ButtonAsButton(ButtonIO.A, ButtonIO.A));
            LoadConfiguration(_currentConfig);
        }

        private void buttonAsJoystickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _currentConfig.buttons.asJoysticks.Add(new ButtonAsJoystick(ButtonIO.A, JoystickIO.LeftJoystick, Axis.XPositive));
            LoadConfiguration(_currentConfig);
        }

        private void buttonAsTriggerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _currentConfig.buttons.asTriggers.Add(new ButtonAsTrigger(ButtonIO.A, TriggerIO.RightTrigger));
            LoadConfiguration(_currentConfig);
        }

        private void buttonAsKeyboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _currentConfig.buttons.asKeyboards.Add(new ButtonAsKeyboard(ButtonIO.A, 0xFF));
            LoadConfiguration(_currentConfig);
        }

        private void joystickAsButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _currentConfig.joysticks.asButtons.Add(new JoystickAsButton(JoystickIO.LeftJoystick, Axis.XPositive, ButtonIO.A, 0.2f));
            LoadConfiguration(_currentConfig);
        }

        private void joystickAsJoystickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _currentConfig.joysticks.asJoysticks.Add(new JoystickAsJoystick(JoystickIO.LeftJoystick, JoystickIO.LeftJoystick, 0.0f, true, false, 20));
            LoadConfiguration(_currentConfig);
        }

        private void joystickAsTriggerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _currentConfig.joysticks.asTriggers.Add(new JoystickAsTrigger(JoystickIO.LeftJoystick, Axis.XPositive, TriggerIO.LeftTrigger, 0.2f, true));
            LoadConfiguration(_currentConfig);
        }

        private void joystickAsKeyboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _currentConfig.joysticks.asKeyboards.Add(new JoystickAsKeyboard(JoystickIO.LeftJoystick, Axis.XPositive, 0xFF, 0.2f));
            LoadConfiguration(_currentConfig);
        }

        private void triggerAsButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _currentConfig.triggers.asButtons.Add(new TriggerAsButton(TriggerIO.LeftTrigger, ButtonIO.A, 0.2f));
            LoadConfiguration(_currentConfig);
        }

        private void triggerAsJoystickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _currentConfig.triggers.asJoysticks.Add(new TriggerAsJoystick(TriggerIO.LeftTrigger, JoystickIO.LeftJoystick, Axis.XPositive, 0.2f, true));
            LoadConfiguration(_currentConfig);
        }

        private void triggerAsTriggerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _currentConfig.triggers.asTriggers.Add(new TriggerAsTrigger(TriggerIO.LeftTrigger, TriggerIO.LeftTrigger, true));
            LoadConfiguration(_currentConfig);
        }

        private void triggerAsKeyboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _currentConfig.triggers.asKeyboards.Add(new TriggerAsKeyboard(TriggerIO.LeftTrigger, 0xFF, 0.2f));
            LoadConfiguration(_currentConfig);
        }

        private void bindingEditorContextMenu_Opening(object sender, CancelEventArgs e)
        {
            removeBindingToolStripMenuItem.Enabled = bindingsTreeView.SelectedNode.Tag != null;
        }

        private void removeBindingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _currentConfig.RemoveBinding(bindingsTreeView.SelectedNode.Tag);
            bindingsTreeView.Nodes.Remove(bindingsTreeView.SelectedNode);
        }

        private void gameAssociationEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if(_initialized)
            {
                _currentConfig.gameAssociationEnabled = gameAssociationEnabled.Checked;
                gameAssociationName.Enabled = gameAssociationEnabled.Checked;
            }
        }

        private void gameAssociationName_TextChanged(object sender, EventArgs e)
        {
            if(_initialized)
                _currentConfig.gameAssociation = gameAssociationName.Text;
        }

        private void gameAssociationName_MouseHover(object sender, EventArgs e)
        {
            gameAssociationToolTip.SetToolTip(gameAssociationName, "Enter a basic application name to auto-switch to this configuration whenever the application is active. (e.g. \"Fortnite\" or \"Rocket League\")");
        }

        private void configurationEditor_Load(object sender, EventArgs e)
        {
            _initialized = false;

            SetConfigsView();

            LoadWidgets();

            LoadConfiguration(DeviceConfig.FromFile(_configAssociation.defaultConfigFile, _device.Type));

            UpdateTextWithLanguage();

            _initialized = true;
        }
    }
}