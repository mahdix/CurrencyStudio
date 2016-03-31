using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CurrencyStudio.Core.RuntimeSystem;

namespace CurrencyStudio
{
    public partial class frmSelectSignalDef : Form
    {
        public string SelectedSignalDefinitionName = "";
        private RuntimeManager runtimeManager = null;

        public frmSelectSignalDef()
        {
            InitializeComponent();
        }

        private void frmSelectSignalDef_Load(object sender, EventArgs e)
        {
            runtimeManager = RuntimeManager.GetInstance();

            UpdateGroupTree();
        }

        private void UpdateGroupTree()
        {
            SignalGroup sg = runtimeManager.RootSignalGroup;

            treeSignalGroups.Nodes.Clear();

            AddSignalGroup(sg, null);
        }

        private void AddSignalGroup(SignalGroup sg, TreeNode parentNode)
        {
            TreeNode newNode = null;

            if (parentNode == null)
            {
                newNode = new TreeNode(sg.GroupId);
                treeSignalGroups.Nodes.Add(newNode);
            }
            else
            {
                newNode = new TreeNode(sg.GroupId);
                parentNode.Nodes.Add(newNode);
            }

            foreach (SignalGroup childGroup in sg.Children)
            {
                AddSignalGroup(childGroup, newNode);
            }
        }

        private void treeSignalGroups_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string selectedGroup = treeSignalGroups.SelectedNode.Text;

            lstSignalDefs.Items.Clear();

            foreach (SignalDefinition sd in runtimeManager.SignalDefinitions)
            {
                if (sd.GroupId == selectedGroup)
                {
                    lstSignalDefs.Items.Add(sd.Name);
                }
            }

            lstSignalDefs.SelectedIndex = -1;
        }

        private void lstSignalDefs_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            cmdOk_Click(this, EventArgs.Empty);
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            if (lstSignalDefs.SelectedIndex != -1)
            {
                SelectedSignalDefinitionName = lstSignalDefs.SelectedItem.ToString();
            }

            Close();
        }

    }
}
