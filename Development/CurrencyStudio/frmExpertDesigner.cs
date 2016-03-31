using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CurrencyStudio.Core.RuntimeSystem;
using CurrencyStudio.Core.Helper;
using CurrencyStudio.Core.UI;
using System.IO;

namespace CurrencyStudio
{
    public partial class frmExpertDesigner : Form
    {
        public frmExpertDesigner()
        {
            InitializeComponent();
        }

        public bool isSaving = false;

        private RuntimeManager runtimeManager = null;
        private PropertyBag signalInstancePropertyBag = null;
        private PropertyBag expertPropertyBag = null;

        private SignalInstance SelectedSignalInstance
        {
            get
            {
                if (SelectedExpert == null) return null;
                if (lstSignalInstances.SelectedIndex == -1) return null;

                return SelectedExpert.SignalInstances[lstSignalInstances.SelectedIndex];
            }
        }


        private Expert SelectedExpert
        {
            get
            {
                if (lstExperts.SelectedIndex == -1) return null;
                return runtimeManager.Experts[lstExperts.SelectedIndex];
            }
        }

        private ExpertPredicate SelectedExpertPredicate
        {
            get
            {
                if (lstPredicates.SelectedIndex == -1 || SelectedExpert == null) return null;

                return SelectedExpert.ExpertPredicates[lstPredicates.SelectedIndex];
            }
        }



        private void frmExpertDesigner_Load(object sender, EventArgs e)
        {
            runtimeManager = RuntimeManager.GetInstance();

            foreach (Expert ex in runtimeManager.Experts)
            {
                lstExperts.Items.Add(ex.Name);
            }

            signalInstancePropertyBag = new PropertyBag();
            signalInstancePropertyBag.GetValue += new PropertySpecEventHandler(pBag_GetValue);
            signalInstancePropertyBag.SetValue += new PropertySpecEventHandler(pBag_SetValue);

            expertPropertyBag = new PropertyBag();
            expertPropertyBag.GetValue += new PropertySpecEventHandler(expertPBag_GetValue);
            expertPropertyBag.SetValue += new PropertySpecEventHandler(expertPBag_SetValue);

            EnableTab(preds,false);
            EnableTab(signalInstances,false);
            EnableTab(expProps, false);

            lblDefaultExpertName.Text = runtimeManager.DefaultExpertName;
        }

        void UpdateExpertPredicateList()
        {
            if (SelectedExpert == null) return;

            lstPredicates.Items.Clear();

            foreach (ExpertPredicate ep in SelectedExpert.ExpertPredicates)
            {
                lstPredicates.Items.Add(ep.Name);
            }
        }

        void expertPBag_SetValue(object sender, PropertySpecEventArgs e)
        {
            if (SelectedExpert == null) return;

            SelectedExpert.ExpertInput[e.Property.Name] = e.Value;
        }

        void expertPBag_GetValue(object sender, PropertySpecEventArgs e)
        {
            if (SelectedExpert == null) return;

            if (SelectedExpert.ExpertInput.ContainsKey(e.Property.Name))
            {
                e.Value = SelectedExpert.ExpertInput[e.Property.Name];
            }
        }

        void lstExperts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isSaving) return;

            if (SelectedExpert == null)
            {
                EnableTab(preds, false);
                EnableTab(signalInstances, false);
                EnableTab(expProps, false);

                return;
            }
            else
            {
                EnableTab(preds, true);
                EnableTab(signalInstances, true);
                EnableTab(expProps, true);
            }

            LoadSelectedExpertIntoUI();

            UpdateExpertPredicatesTab();
            UpdateSignalInstancesTab();
            UpdateExpertPropertiesTab();

            ExpertNameUpdated();
        }

        private void ExpertNameUpdated()
        {
            lblSelectedExpert1.Text = SelectedExpert.Name;
            lblSelectedExpert2.Text = SelectedExpert.Name;
            lblSelectedExpert3.Text = SelectedExpert.Name;
        }

        private void UpdateExpertPredicatesTab()
        {
            lstPredicates.Items.Clear();

            foreach (ExpertPredicate ep in SelectedExpert.ExpertPredicates)
            {
                lstPredicates.Items.Add(ep.Name);
            }

        }

        private void UpdateSignalInstancesTab()
        {
            //Expert expert = expertDesignHelper.selectedExpert;
            
            lstSignalInstances.Items.Clear();
            foreach (SignalInstance si in SelectedExpert.SignalInstances)
            {
                lstSignalInstances.Items.Add(si.Name);
            }
        }

        void pBag_SetValue(object sender, PropertySpecEventArgs e)
        {
            SelectedSignalInstance.InputParametersValues[e.Property.Name] = e.Value;
        }

        void pBag_GetValue(object sender, PropertySpecEventArgs e)
        {
            if (SelectedSignalInstance.InputParametersValues.ContainsKey(e.Property.Name))
            {
                e.Value = SelectedSignalInstance.InputParametersValues[e.Property.Name];
            }
        }
 

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Expert ex = new Expert();
            ex.IsInline = true;
            ex.CodeParameter = RuntimeHelper.GetDefaultExpertCode().ToString();
            runtimeManager.Experts.Add(ex);

            lstExperts.Items.Add(ex.Name);
            SelectLastItem(lstExperts);
        }

        private void SelectLastItem(ListBox listBox)
        {
            listBox.SelectedIndex = listBox.Items.Count - 1;
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if (!CheckItemSelected(lstExperts)) return;

            int oldIndex = lstExperts.SelectedIndex;

            runtimeManager.Experts.Remove(SelectedExpert);

            isSaving = true;
            lstExperts.Items.RemoveAt(oldIndex);
            isSaving = false;

            lstExperts.SelectedIndex = Math.Min(oldIndex, lstExperts.Items.Count - 1);

            if (lstExperts.SelectedIndex == -1)
            {
                //this call will empty UI
                LoadSelectedExpertIntoUI();
            }

            //if default expert is deleted
            if (runtimeManager.FindExpert(runtimeManager.DefaultExpertName) == null)
            {
                runtimeManager.DefaultExpertName = "";
                lblDefaultExpertName.Text = "";
            }
        }

        private void LoadSelectedExpertIntoUI()
        {
            if (SelectedExpert == null)
            {
                txtExpertCode.Text = "";
                txtExpertCode.Enabled = false;
                lblExpertCode.Text = "Expert Code:";
                cmdTestExpertCode.Visible = false;
                lblExpertAssembly.Visible = false;
            }
            else
            {
                UpdateExpertPropertiesTab();

                if (SelectedExpert.IsInline)
                {
                    txtExpertCode.Text = SelectedExpert.CodeParameter;
                    txtExpertCode.Enabled = true;
                    lblExpertCode.Text = "Expert Code:";
                    cmdTestExpertCode.Visible = true;
                    lblExpertAssembly.Visible = false;
                }
                else
                {
                    txtExpertCode.Text = "CANNOT EDIT SOURCE FOR ASSEMBLY EXPERTS";
                    txtExpertCode.Enabled = false;
                    lblExpertCode.Text = "Expert Assembly:";
                    cmdTestExpertCode.Visible = false;
                    lblExpertAssembly.Visible = true;
                    lblExpertAssembly.Text = SelectedExpert.CodeParameter;
                }
            }
        }

        private bool CheckItemSelected(ListBox listBox)
        {
            if (listBox.SelectedIndex == -1)
            {
                MessageBox.Show("you have to select an item first");
                return false;
            }

            return true;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (SelectedExpert == null) return;

            ExpertPredicate ep = new ExpertPredicate();
            ep.IsInline = true;
            ep.CodeParameter = RuntimeHelper.GetDefaultExpertPredicateCode();
            SelectedExpert.ExpertPredicates.Add(ep);

            lstPredicates.Items.Add(ep.Name);
            SelectLastItem(lstPredicates);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (!CheckItemSelected(lstPredicates)) return;

            int oldIndex = lstPredicates.SelectedIndex;

            SelectedExpert.ExpertPredicates.Remove(SelectedExpertPredicate);

            isSaving = true;
            lstPredicates.Items.RemoveAt(oldIndex);
            isSaving = false;

            lstPredicates.SelectedIndex = Math.Min(oldIndex, lstPredicates.Items.Count - 1);

            if (lstPredicates.SelectedIndex == -1)
            {
                //this call will empty UI
                LoadSelectedExpertPredicateIntoUI();
            }
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            if (false == SaveSelectedExpert()) return;
            if (false == SaveSelectedExpertPredicate()) return;
            if (false == SaveSelectedSignalInstance()) return;
            
            RuntimeManager.Save();
            Close();
        }
        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            if (false == CheckItemSelected(lstPredicates)) return;

            if (false == SaveSelectedExpertPredicate()) return;

            isSaving = true;
            lstPredicates.Items[lstPredicates.SelectedIndex] = SelectedExpertPredicate.Name;
            isSaving = false;
        }

        private bool SaveSelectedExpertPredicate()
        {
            if (SelectedExpertPredicate == null) return true;

            //check for name
            if (SelectedExpertPredicate.IsInline)
            {
                SelectedExpertPredicate.CodeParameter = txtPredicateCode.Text;
            }

            SelectedExpertPredicate.TimeFrame = txtPredTFs.Text;
            Utils.DelimitedStringToList(txtPredInsts.Text, SelectedExpertPredicate.Instruments);


            foreach (ExpertPredicate ep in SelectedExpert.ExpertPredicates)
            {
                if (ep.Name == SelectedExpertPredicate.Name && !ep.Equals(SelectedExpertPredicate))
                {
                    MessageBox.Show("name repeated");
                    return false;
                }
            }

            return true;
        }

        private void UpdateSignalInstancePropertyGrid()
        {
            signalInstancePropertyBag.Properties.Clear();

            foreach (string param in SelectedSignalInstance.InternalObject.SignalInput.Keys)
            {
                signalInstancePropertyBag.Properties.Add(new PropertySpec(param, typeof(string)));
            }

            FileUtils.SyncDictionaries(SelectedSignalInstance.InternalObject.SignalInput, SelectedSignalInstance.InputParametersValues);

            signalInstanceProperties.SelectedObject = signalInstancePropertyBag;
        }

        private void lstSignalInstances_SelectedIndexChanged(object sender, EventArgs e)
        {
            //load data
            if (SelectedSignalInstance != null)
            {
                txtSignalInstanceName.Text = SelectedSignalInstance.Name;
                lblSignalDefinitionName.Text = SelectedSignalInstance.DefinitionName;

                txtSigTF.Text = SelectedSignalInstance.TimeFrame;
                txtSigInst.Text = Utils.ListToDelimitedString(SelectedSignalInstance.Instruments);
                UpdateSignalInstancePropertyGrid();
            }
        }

        private bool SaveSelectedSignalInstance()
        {
            if (SelectedSignalInstance == null) return true;

            if (SelectedSignalInstance.Name != txtSignalInstanceName.Text && 
                    SelectedExpert.FindSignalInstance(txtSignalInstanceName.Text) != null)
            {
                MessageBox.Show("Repeated sig instance name - cannot save");
                return false;
            }
            else
            {
                SelectedSignalInstance.Name = txtSignalInstanceName.Text;
                SelectedSignalInstance.TimeFrame = txtSigTF.Text;
                Utils.DelimitedStringToList(txtSigInst.Text, SelectedSignalInstance.Instruments);

                isSaving = true;
                lstSignalInstances.Items[lstSignalInstances.SelectedIndex] = txtSignalInstanceName.Text;
                isSaving = false;
            }

            return true;
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            if (lstSignalInstances.SelectedIndex != -1)
            {
                int oldIdx = lstSignalInstances.SelectedIndex;

                string name = lstSignalInstances.SelectedItem.ToString();

                SelectedExpert.SignalInstances.Remove(SelectedSignalInstance);

                UpdateSignalInstancesTab();
                                
                lstSignalInstances.SelectedIndex = Math.Min(oldIdx, lstSignalInstances.Items.Count - 1);
            }
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            SaveSelectedSignalInstance();
        }

        public static void EnableTab(TabPage page, bool enable)
        {
            EnableControls(page.Controls, enable);
        }
        private static void EnableControls(Control.ControlCollection ctls, bool enable)
        {
            foreach (Control ctl in ctls)
            {
                ctl.Enabled = enable;
                EnableControls(ctl.Controls, enable);
            }
        }


        private void frmExpertDesigner_Resize(object sender, EventArgs e)
        {
            lblSeperator.Height = Height - 50;
        }

        private void toolStripButton15_Click(object sender, EventArgs e)
        {
            RuntimeManager.Reload();
            Close();
        }

        private void toolStripButton13_Click_1(object sender, EventArgs e)
        {
            if (lstExperts.SelectedItem != null)
            {
                runtimeManager.DefaultExpertName = lstExperts.SelectedItem.ToString();
                lblDefaultExpertName.Text = runtimeManager.DefaultExpertName;
                //parentForm.UpdateDefaults();
            }

        }

        private void cmdTestExpertCode_Click(object sender, EventArgs e)
        {
            if (SelectedExpert == null) return;
            Assert.IsTrue(SelectedExpert.IsInline);

            SelectedExpert.CodeParameter = txtExpertCode.Text;

            string msg = "";
            bool ok = SelectedExpert.TestCompile(out msg);

            if (ok)
            {
                MessageBox.Show("OK!");
            }
            else
            {
                MessageBox.Show("Error: " + msg);
            }

        }

        private void cmdTestExpertPredicate_Click(object sender, EventArgs e)
        {
            if (SelectedExpertPredicate == null) return;
            Assert.IsTrue(SelectedExpertPredicate.IsInline);

            SelectedExpertPredicate.CodeParameter = txtPredicateCode.Text;

            string msg = "";
            bool ok = SelectedExpertPredicate.TestCompile(out msg);

            if (ok)
            {
                MessageBox.Show("OK!");
            }
            else
            {
                MessageBox.Show("Error: " + msg);
            }
        }

        private void UpdateExpertPropertiesTab()
        {
            txtExpertComments.Text = SelectedExpert.Comments;

            expertPropertyBag.Properties.Clear();

            //maybe signaldefinition is deleted
            if (SelectedExpert == null) return;

            foreach (string param in SelectedExpert.InternalObject.ExpertInput.Keys)
            {
                expertPropertyBag.Properties.Add(new PropertySpec(param, typeof(string)));
            }

            FileUtils.SyncDictionaries(SelectedExpert.InternalObject.ExpertInput, SelectedExpert.ExpertInput);
            expertProperties.SelectedObject = expertPropertyBag;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmSelectSignalDef frm = new frmSelectSignalDef();

            if (frm.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string selectedTmplateName = frm.SelectedSignalDefinitionName;

            SignalInstance si = new SignalInstance();
            si.DefinitionName = selectedTmplateName;
            si.Name = Utils.FindUniqueName(SelectedExpert.FindSignalInstance, selectedTmplateName + "Instance");
            SelectedExpert.SignalInstances.Add(si);

            lstSignalInstances.Items.Add(si.Name);

            SelectLastItem(lstSignalInstances);
        }

        private void cmdNewAssembly_Click(object sender, EventArgs e)
        {
            string filePath = FileUtils.AskAssemblyFile();
            if (filePath == null) return;

            string fileName = Path.GetFileName(filePath);
            string targetPath = Path.Combine(FileUtils.ExpertLibFolder, fileName);

            if (File.Exists(targetPath))
            {
                if (MessageBox.Show("A file with the same name exists. Overwrite?", "", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }

            File.Copy(filePath, targetPath, true);

            Expert ex = new Expert();
            ex.IsInline = false;
            ex.CodeParameter = fileName;
            runtimeManager.Experts.Add(ex);

            lstExperts.Items.Add(ex.Name);
            SelectLastItem(lstExperts);
        }

        private void cmdSaveExpert_Click(object sender, EventArgs e)
        {
            if (false == CheckItemSelected(lstExperts)) return;

            SaveSelectedExpert();

            isSaving = true;
            lstExperts.Items[lstExperts.SelectedIndex] = SelectedExpert.Name;
            isSaving = false;
        }

        private bool SaveSelectedExpert()
        {
            if (false == CheckItemSelected(lstExperts)) return true;

            //check for name
            if (SelectedExpert.IsInline)
            {
                SelectedExpert.CodeParameter = txtExpertCode.Text;
            }

            ExpertNameUpdated();

            if (runtimeManager.DefaultExpert == null)
            {
                runtimeManager.DefaultExpertName = "";
                lblDefaultExpertName.Text = "";
            }

            SelectedExpert.Comments = txtExpertComments.Text;

            foreach (Expert ex in runtimeManager.Experts)
            {
                if (ex.Name == SelectedExpert.Name && !ex.Equals(SelectedExpert) )
                {
                    MessageBox.Show("name repeated");
                    return false;
                }
            }

            return true;
        }

        private void lstPredicates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isSaving) return;

            LoadSelectedExpertPredicateIntoUI();
        }

        private void LoadSelectedExpertPredicateIntoUI()
        {
            if (SelectedExpertPredicate == null)
            {
                txtPredicateCode.Text = "";
                txtPredicateCode.Enabled = false;
                txtPredInsts.Text = "";
                txtPredInsts.Enabled = false;
                txtPredTFs.Text = "";
                txtPredTFs.Enabled = false;
                lblPredCode.Text = "Predicate Code:";
                cmdTestExpertPredicate.Visible = false;
                lblPredicateAssembly.Visible = false;
            }
            else
            {
                if (SelectedExpertPredicate.IsInline)
                {
                    txtPredicateCode.Text = SelectedExpertPredicate.CodeParameter;
                    txtPredicateCode.Enabled = true;
                    lblPredCode.Text = "Predicate Code:";
                    cmdTestExpertPredicate.Visible = true;
                    lblPredicateAssembly.Visible = false;
                }
                else
                {
                    txtPredicateCode.Text = "CANNOT EDIT SOURCE FOR ASSEMBLY EXPERTS";
                    txtPredicateCode.Enabled = false;
                    lblPredCode.Text = "Predicate Assembly:";
                    cmdTestExpertPredicate.Visible = false;
                    lblPredicateAssembly.Visible = true;
                    lblPredicateAssembly.Text = SelectedExpertPredicate.CodeParameter;
                }

                txtPredInsts.Text = Utils.ListToDelimitedString(SelectedExpertPredicate.Instruments);
                txtPredInsts.Enabled = true;
                txtPredTFs.Text = SelectedExpertPredicate.TimeFrame;
                txtPredTFs.Enabled = true;
            }
        }

        private void cmdNewAssemblyPred_Click(object sender, EventArgs e)
        {
            string filePath = FileUtils.AskAssemblyFile();
            if (filePath == null) return;

            string fileName = Path.GetFileName(filePath);
            string targetPath = Path.Combine(FileUtils.ExpertPredicateLibFolder, fileName);

            if (File.Exists(targetPath))
            {
                if (MessageBox.Show("A file with the same name exists. Overwrite?", "", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }

            File.Copy(filePath, targetPath, true);

            ExpertPredicate ep = new ExpertPredicate();
            ep.IsInline = false;
            ep.CodeParameter = fileName;
            SelectedExpert.ExpertPredicates.Add(ep);

            lstPredicates.Items.Add(ep.Name);
            SelectLastItem(lstPredicates);
        }

        private void cmdsaveExpertProps_Click(object sender, EventArgs e)
        {
            if (false == CheckItemSelected(lstExperts)) return;

            SelectedExpert.Comments = txtExpertComments.Text;
        }

    }
}
