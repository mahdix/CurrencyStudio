using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CurrencyStudio.Core.RuntimeSystem;
using CurrencyStudio.Core.Helper;
using CurrencyStudio.Core.UI;
using System;
using System.IO;

namespace CurrencyStudio
{
    public partial class frmSignals : Form
    {
        private RuntimeManager runtimeManager = null;
        private bool isSaving = false;

        public frmSignals()
        {
            InitializeComponent();
        }


        private void frmSignals_Load(object sender, EventArgs e)
        {
            runtimeManager = RuntimeManager.GetInstance();

            UpdateGroupTree();
            signalGroupsTree.SelectedNode = signalGroupsTree.Nodes[0];
            UpdateSignalsList();
        }

        private void UpdateGroupTree()
        {
            SignalGroup sg = runtimeManager.RootSignalGroup;

            signalGroupsTree.Nodes.Clear();

            AddSignalGroup(sg,null);
        }

        private void AddSignalGroup(SignalGroup sg,TreeNode parentNode)
        {
            TreeNode newNode = null;

            if (parentNode == null)
            {
                newNode = new TreeNode(sg.GroupId);
                signalGroupsTree.Nodes.Add(newNode);
            }
            else
            {
                newNode = new TreeNode(sg.GroupId);
                parentNode.Nodes.Add(newNode);
            }

            foreach (SignalGroup childGroup  in sg.Children)
            {
                AddSignalGroup(childGroup, newNode);
            }
        }

        private void cmdTestSignalDefinition_Click(object sender, EventArgs e)
        {
            if (SelectedSignalDefinition == null) return;
            Assert.IsTrue(SelectedSignalDefinition.IsInline);

            SelectedSignalDefinition.CodeParameter = txtSignalDefCode.Text;

            string msg = "";
            bool ok = SelectedSignalDefinition.TestCompile(out msg);

            if (ok)
            {
                MessageBox.Show("OK!");
            }
            else
            {
                MessageBox.Show("Error: " + msg);
            }
        }

        private SignalDefinition SelectedSignalDefinition
        {
            get
            {
                if (lstSignalDefinitions.SelectedItem == null) return null;

                return runtimeManager.SignalDefinitions[lstSignalDefinitions.SelectedIndex];
            }
        }

        private void LoadSelectedItemIntoUI()
        {
            if (SelectedSignalDefinition == null)
            {
                txtSignalDefCode.Text = "";
                txtSignalDefCode.Enabled = false;
                lblSignalAssemblyName.Visible = false;
                lblSignalAssemblyName.Text = "";
                lblSignalCode.Text = "Signal Code:";
                cmdTestSignalDefinition.Visible = false;
            }
            else
            {
                if (SelectedSignalDefinition.IsInline)
                {
                    txtSignalDefCode.Text = SelectedSignalDefinition.CodeParameter;
                    lblSignalAssemblyName.Visible = false;
                    lblSignalCode.Text = "Signal Code:";
                    cmdTestSignalDefinition.Visible = true;
                }
                else
                {
                    txtSignalDefCode.Text = "CANNOT VIEW SOURCE FOR ASSEMBLY SIGNALS";
                    txtSignalDefCode.Enabled = false;
                    lblSignalAssemblyName.Visible = true;
                    lblSignalAssemblyName.Text = SelectedSignalDefinition.CodeParameter;
                    lblSignalCode.Text = "Signal Assembly:";
                    cmdTestSignalDefinition.Visible = false;
                }
            }
        }

        private bool SaveSelectedItem()
        {
            if (SelectedSignalDefinition == null) return true;
            //check for name
            if (SelectedSignalDefinition.IsInline)
            {
                SelectedSignalDefinition.CodeParameter = txtSignalDefCode.Text;
            }

            foreach (SignalDefinition sd in runtimeManager.SignalDefinitions)
            {
                if (sd.Name == SelectedSignalDefinition.Name && !sd.Equals(SelectedSignalDefinition))
                {
                    MessageBox.Show("name repeated");
                    return false;
                }
            }

            return true;
        }

        private void cmdNewGroup_Click(object sender, EventArgs e)
        {
            if ( signalGroupsTree.SelectedNode == null )
            {
                return;
            }

            frmInput frm = new frmInput();

            frm.msg = "Please enter group name:";
            frm.ShowDialog();

            if (frm.result == null) return;
            if (runtimeManager.RootSignalGroup.FindChild(frm.result) != null)
            {
                MessageBox.Show("Group name is repeated");
                return;
            }

            SignalGroup parent = runtimeManager.RootSignalGroup.FindChild(signalGroupsTree.SelectedNode.Text);

            TreeNode tn = new TreeNode(frm.result);
            signalGroupsTree.SelectedNode.Nodes.Add(tn);
            signalGroupsTree.SelectedNode = tn;

            parent.Children.Add(new SignalGroup(frm.result));

            UpdateSignalsList();
        }

        private void UpdateSignalsList()
        {
            lstSignalDefinitions.Items.Clear();

            foreach (SignalDefinition st in runtimeManager.SignalDefinitions)
            {
                if (st.GroupId == CurrentGroupId)
                {
                    lstSignalDefinitions.Items.Add(st.Name);
                }
            }
        }

        private string CurrentGroupId
        {
            get
            {
                return signalGroupsTree.SelectedNode.Text;
            }
        }

        private void cmdUpdateGroup_Click(object sender, EventArgs e)
        {
            if (signalGroupsTree.SelectedNode == null)
            {
                return;
            }

            if (signalGroupsTree.SelectedNode.Text == Def.RootSignalGroupId)
            {
                return;
            }

            frmInput frm = new frmInput();

            frm.msg = "Please enter new group name:";
            frm.defaultInput = signalGroupsTree.SelectedNode.Text;
            frm.ShowDialog();

            if (frm.result == null) return;

            if (runtimeManager.RootSignalGroup.FindChild(frm.result) != null)
            {
                MessageBox.Show("Group name is repeated");
                return;
            }

            string oldName = signalGroupsTree.SelectedNode.Text;
            string newName = frm.result;

            signalGroupsTree.SelectedNode.Text = newName;

            runtimeManager.RootSignalGroup.FindChild(oldName).GroupId = newName;

            foreach (SignalDefinition sd in runtimeManager.SignalDefinitions)
            {
                if (sd.GroupId == oldName) sd.GroupId = newName;
            }
        }

        private void cmdDeleteGroup_Click(object sender, EventArgs e)
        {
            if (signalGroupsTree.SelectedNode == null)
            {
                return;
            }

            if (signalGroupsTree.SelectedNode.Text == Def.RootSignalGroupId)
            {
                return;
            }

            if (signalGroupsTree.SelectedNode.Nodes.Count > 0 )
            {
                return;
            }

            if (MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            string oldName = signalGroupsTree.SelectedNode.Text;

            signalGroupsTree.SelectedNode.Remove();
            signalGroupsTree.SelectedNode = signalGroupsTree.Nodes[0];

            foreach (SignalDefinition sd in runtimeManager.SignalDefinitions)
            {
                if (sd.GroupId == oldName) sd.GroupId = Def.RootSignalGroupId;
            }
        }

        private void signalsTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            UpdateSignalsList(); 
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (false == SaveSelectedItem())
            {
                return;
            }

            RuntimeManager.Save();
            Close();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            RuntimeManager.Reload();
            Close();
        }

        private void cmdMoveUp_Click(object sender, EventArgs e)
        {
            TreeNode tn = signalGroupsTree.SelectedNode;

            if (tn == null)
            {
                return;
            }

            if (tn.Parent == null)
            {
                return;
            }

            int activeNodeIndex = tn.Parent.Nodes.IndexOf(tn);
            int activeNodeParentChildCount = tn.Parent.Nodes.Count;

            if (activeNodeIndex == 0 )
            {
                return;
            }

            TreeNode parent = tn.Parent;
            parent.Nodes.Remove(tn);
            parent.Nodes.Insert(activeNodeIndex - 1, tn);

            signalGroupsTree.SelectedNode = tn;

            //now move tn in data
            SignalGroup tnGroup = runtimeManager.RootSignalGroup.FindChild(tn.Text);
            SignalGroup tnParent = runtimeManager.RootSignalGroup.FindChildParent(tn.Text);

            int tnGroupIndex = tnParent.Children.IndexOf(tnGroup);
            tnParent.Children.RemoveAt(tnGroupIndex);
            tnParent.Children.Insert(tnGroupIndex - 1, tnGroup);
        }

        private void cmdMoveDown_Click(object sender, EventArgs e)
        {
            TreeNode tn = signalGroupsTree.SelectedNode;

            if (tn == null)
            {
                return;
            }

            if (tn.Parent == null)
            {
                return;
            }

            int activeNodeIndex = tn.Parent.Nodes.IndexOf(tn);
            int activeNodeParentChildCount = tn.Parent.Nodes.Count;

            if (activeNodeIndex == activeNodeParentChildCount-1)
            {
                return;
            }

            TreeNode parent = tn.Parent;
            parent.Nodes.Remove(tn);
            parent.Nodes.Insert(activeNodeIndex + 1, tn);

            signalGroupsTree.SelectedNode = tn;

            //now move tn in data
            SignalGroup tnGroup = runtimeManager.RootSignalGroup.FindChild(tn.Text);
            SignalGroup tnParent = runtimeManager.RootSignalGroup.FindChildParent(tn.Text);

            int tnGroupIndex = tnParent.Children.IndexOf(tnGroup);
            tnParent.Children.RemoveAt(tnGroupIndex);
            tnParent.Children.Insert(tnGroupIndex + 1, tnGroup);
        }

        private void cmdNewInline_Click(object sender, EventArgs e)
        {
            if (signalGroupsTree.SelectedNode == null)
            {
                MessageBox.Show("No group is selected");
                return;
            }

            SignalDefinition st = new SignalDefinition();
            st.CodeParameter = RuntimeHelper.GetDefaultSignalDefinitionCode().ToString();
            st.GroupId = CurrentGroupId;
            st.IsInline = true;
            runtimeManager.SignalDefinitions.Add(st);

            lstSignalDefinitions.Items.Add(st.Name);
            SelectLastSignal();
        }

        private void SelectLastSignal()
        {
            lstSignalDefinitions.SelectedIndex = lstSignalDefinitions.Items.Count - 1;
        }

        private bool CheckItemSelected()
        {
            if (lstSignalDefinitions.SelectedIndex == -1)
            {
                MessageBox.Show("You must first select a signal");
                return false;
            }

            return true;
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (!CheckItemSelected()) return;

            int oldIndex = lstSignalDefinitions.SelectedIndex;

            string currentName = SelectedSignalDefinition.Name;

            SignalInstance si = runtimeManager.FindSignalInstance(currentName);
            if (null != si)
            {
                MessageBox.Show("The " + currentName + " is used in " + si.Name + " instance and cannot be deleted");
                return;
            }

            runtimeManager.SignalDefinitions.Remove(SelectedSignalDefinition);

            isSaving = true;
            lstSignalDefinitions.Items.RemoveAt(oldIndex);
            isSaving = false;
            
            lstSignalDefinitions.SelectedIndex = Math.Min(oldIndex, lstSignalDefinitions.Items.Count - 1);

            if (lstSignalDefinitions.SelectedIndex == -1)
            {
                //this call will empty UI
                LoadSelectedItemIntoUI();
            }
        }

        private void cmdSave_Click(object sender, System.EventArgs e)
        {
            SaveSelectedItem();
            
            isSaving = true;
            lstSignalDefinitions.Items[lstSignalDefinitions.SelectedIndex] = SelectedSignalDefinition.Name;
            isSaving = false;
        }

        private void lstSignalDefinitions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isSaving) return;
            LoadSelectedItemIntoUI();
        }

        private void cmdNewAssembly_Click(object sender, EventArgs e)
        {
            if (signalGroupsTree.SelectedNode == null)
            {
                MessageBox.Show("No group is selected");
                return;
            }

            string filePath = FileUtils.AskAssemblyFile();
            if (filePath == null) return;

            string fileName = Path.GetFileName(filePath);
            string targetPath = Path.Combine(FileUtils.SignalLibFolder, fileName);

            if (File.Exists(targetPath))
            {
                if (MessageBox.Show("A file with the same name exists. Overwrite?", "", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }

            File.Copy(filePath, targetPath,true);

            SignalDefinition st = new SignalDefinition();
            st.CodeParameter = fileName;
            st.GroupId = CurrentGroupId;
            st.IsInline = false;

            runtimeManager.SignalDefinitions.Add(st);

            lstSignalDefinitions.Items.Add(st.Name);
            SelectLastSignal();
        }
    }
}
