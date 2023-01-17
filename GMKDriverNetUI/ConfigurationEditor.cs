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
        }

        private void LoadConfiguration(DeviceConfig config)
        {
            _currentConfig = config;

            serialNumber.Text = _device.SerialNumber;
            deviceType.Text = _device.Type.ToString();

            this.Text = config.name;
            _currentConfig = config;

            bindingsTreeView.Nodes["joystickSettings"].Nodes["leftJoystick"].Tag = config.joystickLeft;
            bindingsTreeView.Nodes["joystickSettings"].Nodes["rightJoystick"].Tag = config.joystickRight;

            bindingsTreeView.Nodes["triggerSettings"].Nodes["leftTrigger"].Tag = config.triggerLeft;
            bindingsTreeView.Nodes["triggerSettings"].Nodes["rightTrigger"].Tag = config.triggerRight;

            // Get Button Bindings
            {
                TreeNode buttonBindings = bindingsTreeView.Nodes["bindings"].Nodes["buttonBindings"];
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
                TreeNode joystickBindings = bindingsTreeView.Nodes["bindings"].Nodes["joystickBindings"];
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
                TreeNode triggerBindings = bindingsTreeView.Nodes["bindings"].Nodes["triggerBindings"];
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

                removeMenuItem.Enabled |= config.name != _device.Config.name;
                makeDefaultMenuItem.Enabled |= config.name != _configAssociation.defaultConfigFile;
                setActiveMenuItem.Enabled |= config.name != _device.Config.name;
                renameMenuItem.Enabled |= true;
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
            openConfigFileDialog.ShowDialog();
            string configName = Path.GetFileNameWithoutExtension(openConfigFileDialog.FileName);
            DeviceConfig config = DeviceConfig.FromFile(configName);
            _deviceList.AddConfiguration(_device.SerialNumber, config, false);
            SetConfigsView();
        }
    }
}
