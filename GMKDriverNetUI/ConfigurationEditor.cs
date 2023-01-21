using GMKDriverNET;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GMKDriverNetUI.ConfigurationControls;
using System.IO;

namespace GMKDriverNetUI
{
    public partial class configurationEditor : Form
    {
        private GMKDevice _device;
        private DeviceList _deviceList;
        private DeviceConfigAssociations _configAssociation;
        private List<DeviceConfig> _configs;
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

        public configurationEditor(GMKDevice device)
        {
            InitializeComponent();

            _device = device;

            SetConfigsView();

            LoadConfiguration(DeviceConfig.FromFile(_configAssociation.defaultConfigFile));

            LoadWidgets();
        }

        private void SetConfigsView()
        {
            _deviceList = DeviceList.Load();
            _configAssociation = _deviceList.LookupSerialNumber(_device.SerialNumber);

            _configs = new List<DeviceConfig>();

            DeviceConfig activeConfig = _device.Config;

            foreach (string configFile in _configAssociation.configFiles)
            {
                _configs.Add(DeviceConfig.FromFile(configFile));
            }

            configsView.Items.Clear();
            foreach (DeviceConfig config in _configs)
            {
                ListViewItem item = new ListViewItem(config.name);
                item.Tag = config;

                if(config.name == activeConfig.name)
                {
                    item.Font = new Font(item.Font, FontStyle.Bold);
                }

                if (config.name == _configAssociation.defaultConfigFile)
                {
                    ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem();
                    subItem.Text = "Default";
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
            CloseWidgets();
        }

        private void CloseWidgets()
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
        }

        private void LoadConfiguration(DeviceConfig config)
        {
            serialNumber.Text = _device.SerialNumber;
            deviceType.Text = _device.Type.ToString();

            currentConfigName.Text = config.name;

            gameAssociationEnabled.Checked = config.gameAssociationEnabled;
            gameAssociationName.Text = config.gameAssociation;
            gameAssociationName.Enabled = config.gameAssociationEnabled;

            _currentConfig = config;

            // Get Button Bindings
            {
                TreeNode buttonBindings = bindingsTreeView.Nodes["buttonBindings"];
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
                TreeNode joystickBindings = bindingsTreeView.Nodes["joystickBindings"];
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
                TreeNode triggerBindings = bindingsTreeView.Nodes["triggerBindings"];
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
                CloseWidgets();

                object node = bindingsTreeView.SelectedNode;
                string type = bindingsTreeView.SelectedNode.Tag.GetType().ToString();
                Console.WriteLine(node.ToString());
                switch (type)
                {
                    case "GMKDriverNET.ButtonAsButton":
                        _buttonAsButtonControl.LoadWidget((TreeNode)node);
                        return;

                    case "GMKDriverNET.ButtonAsJoystick":
                        _buttonAsJoystickControl.LoadWidget((TreeNode)node);
                        return;

                    case "GMKDriverNET.ButtonAsTrigger":
                        _buttonAsTriggerControl.LoadWidget((TreeNode)node);
                        return;

                    case "GMKDriverNET.ButtonAsKeyboard":
                        _buttonAsKeyboardControl.LoadWidget((TreeNode)node);
                        return;

                    case "GMKDriverNET.JoystickAsButton":
                        _joystickAsButtonControl.LoadWidget((TreeNode)node);
                        return;

                    case "GMKDriverNET.JoystickAsJoystick":
                        _joystickAsJoystickControl.LoadWidget((TreeNode)node);
                        return;

                    case "GMKDriverNET.JoystickAsTrigger":
                        _joystickAsTriggerControl.LoadWidget((TreeNode)node);
                        return;

                    case "GMKDriverNET.JoystickAsKeyboard":
                        _joystickAsKeyboardControl.LoadWidget((TreeNode)node);
                        return;

                    case "GMKDriverNET.TriggerAsButton":
                        _triggerAsButtonControl.LoadWidget((TreeNode)node);
                        return;

                    case "GMKDriverNET.TriggerAsJoystick":
                        _triggerAsJoystickControl.LoadWidget((TreeNode)node);
                        return;

                    case "GMKDriverNET.TriggerAsTrigger":
                        _triggerAsTriggerControl.LoadWidget((TreeNode)node);
                        return;

                    case "GMKDriverNET.TriggerAsKeyboard":
                        _triggerAsKeyboardControl.LoadWidget((TreeNode)node);
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
            ConfigName name = new ConfigName();
            name.ShowDialog();
            if(name.ConfigurationName != string.Empty)
            {
                DeviceConfig config = DeviceConfig.Default;
                config.name = name.ConfigurationName;
                _deviceList.AddConfiguration(_device.SerialNumber, config, name.MakeDefault);
                SetConfigsView();
                LoadConfiguration(config);
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
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            DeviceConfig config = (DeviceConfig)configsView.SelectedItems[0].Tag;
            LoadConfiguration(config);
        }

        private void renameMenuItem_Click(object sender, EventArgs e)
        {
            DeviceConfig config = (DeviceConfig)configsView.SelectedItems[0].Tag;

            ConfigName name = new ConfigName();
            name.SetName(config.name);
            name.SetMakeDefault(_deviceList.isConfigurationDefault(_device.SerialNumber, config));
            name.ShowDialog();
            if (name.ConfigurationName != string.Empty)
            {
                _deviceList.RenameConfiguration(_device.SerialNumber, config, name.ConfigurationName);
                if(name.MakeDefault)
                {
                    _deviceList.SetDefaultConfiguration(_device.SerialNumber, config);
                }
                SetConfigsView();
                LoadConfiguration(config);
            }
        }

        private void removeMenuItem_Click(object sender, EventArgs e)
        {
            if (configsView.Items.Count == 1)
            {
                return;
            }
            else
            {
                DeviceConfig config = (DeviceConfig)configsView.SelectedItems[0].Tag;

                DialogResult result = MessageBox.Show("Delete this from the hard drive?", "Remove Configuration", MessageBoxButtons.YesNoCancel);

                if(result == DialogResult.Cancel)
                {
                    return;
                }

                _deviceList.RemoveConfiguration(_device.SerialNumber, config, result == DialogResult.Yes);
                SetConfigsView();
            }
        }

        private void setActiveMenuItem_Click(object sender, EventArgs e)
        {
            DeviceConfig config = (DeviceConfig)configsView.SelectedItems[0].Tag;
            _device.Config = config;
            SetConfigsView();
        }

        private void fromExistingMenuItem_Click(object sender, EventArgs e)
        {
            openConfigFileDialog.InitialDirectory = Directory.GetCurrentDirectory() + "\\Configs";
            DialogResult result = openConfigFileDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                string configName = Path.GetFileNameWithoutExtension(openConfigFileDialog.FileName);
                DeviceConfig config = DeviceConfig.FromFile(configName);
                _deviceList.AddConfiguration(_device.SerialNumber, config, false);
                SetConfigsView();
            }
        }

        private void makeDefaultMenuItem_Click(object sender, EventArgs e)
        {
            DeviceConfig config = (DeviceConfig)configsView.SelectedItems[0].Tag;
            _deviceList.SetDefaultConfiguration(_device.SerialNumber, config);
            SetConfigsView();
        }

        private void buttonAsButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _currentConfig.buttons.asButtons.Add(new ButtonAsButton(ButtonIO.A, ButtonIO.A));
        }

        private void buttonAsJoystickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _currentConfig.buttons.asJoysticks.Add(new ButtonAsJoystick(ButtonIO.A, JoystickIO.Left, Axis.XPositive));
        }

        private void buttonAsTriggerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _currentConfig.buttons.asTriggers.Add(new ButtonAsTrigger(ButtonIO.A, TriggerIO.Right));
        }

        private void buttonAsKeyboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _currentConfig.buttons.asKeyboards.Add(new ButtonAsKeyboard(ButtonIO.A, 0xFF));
        }

        private void joystickAsButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _currentConfig.joysticks.asButtons.Add(new JoystickAsButton(JoystickIO.Left, Axis.XPositive, ButtonIO.A, 0.2f));
        }

        private void joystickAsJoystickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _currentConfig.joysticks.asJoysticks.Add(new JoystickAsJoystick(JoystickIO.Left, JoystickIO.Left, 0.0f, true, false));
        }

        private void joystickAsTriggerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _currentConfig.joysticks.asTriggers.Add(new JoystickAsTrigger(JoystickIO.Left, Axis.XPositive, TriggerIO.Left, 0.2f, true));
        }

        private void joystickAsKeyboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _currentConfig.joysticks.asKeyboards.Add(new JoystickAsKeyboard(JoystickIO.Left, Axis.XPositive, 0xFF, 0.2f));
        }

        private void triggerAsButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _currentConfig.triggers.asButtons.Add(new TriggerAsButton(TriggerIO.Left, ButtonIO.A, 0.2f));
        }

        private void triggerAsJoystickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _currentConfig.triggers.asJoysticks.Add(new TriggerAsJoystick(TriggerIO.Left, JoystickIO.Left, Axis.XPositive, 0.2f, true));
        }

        private void triggerAsTriggerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _currentConfig.triggers.asTriggers.Add(new TriggerAsTrigger(TriggerIO.Left, TriggerIO.Left, true));
        }

        private void triggerAsKeyboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _currentConfig.triggers.asKeyboards.Add(new TriggerAsKeyboard(TriggerIO.Left, 0xFF, 0.2f));
        }

        private void bindingEditorContextMenu_Opening(object sender, CancelEventArgs e)
        {
            removeBindingToolStripMenuItem.Enabled = bindingsTreeView.SelectedNode.Tag != null;
        }

        private void removeBindingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _currentConfig.Remove(bindingsTreeView.SelectedNode.Tag);
            bindingsTreeView.Nodes.Remove(bindingsTreeView.SelectedNode);
        }

        private void gameAssociationEnabled_CheckedChanged(object sender, EventArgs e)
        {
            _currentConfig.gameAssociationEnabled = gameAssociationEnabled.Checked;
            gameAssociationName.Enabled = gameAssociationEnabled.Checked;
        }

        private void gameAssociationName_TextChanged(object sender, EventArgs e)
        {
            _currentConfig.gameAssociation = gameAssociationName.Text;
        }
    }
}
