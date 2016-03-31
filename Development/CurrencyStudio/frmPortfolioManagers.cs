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
    public partial class frmPortfolioManagers : Form
    {
        public frmPortfolioManagers()
        {
            InitializeComponent();
        }

        private RuntimeManager runtimeManager = null;
        private bool isSaving = false;
        private PropertyBag pmBag = null;

        private void frmPortfolioManagers_Load(object sender, EventArgs e)
        {
            runtimeManager = RuntimeManager.GetInstance();

            pmBag = new PropertyBag();
            pmBag.GetValue += new PropertySpecEventHandler(pmBag_GetValue);
            pmBag.SetValue += new PropertySpecEventHandler(pmBag_SetValue);

            UpdatePMList();

            lblDefaultPortfolioManager.Text = runtimeManager.DefaultPortfolioManagerName;
        }

        private void UpdatePMList()
        {
            lstPMs.Items.Clear();

            foreach (PortfolioManager pm in runtimeManager.PortfolioManagers)
            {
                lstPMs.Items.Add(pm.InternalObject.Name);
            }
        }

        private PortfolioManager SelectedPM
        {
            get
            {
                if (lstPMs.SelectedItem == null) return null;

                return runtimeManager.PortfolioManagers[lstPMs.SelectedIndex];
            }
        }

    
        private void LoadSelectedItemIntoUI()
        {
            if (SelectedPM == null)
            {
                txtPMCode.Text = "";
                lblPMCode.Text = "Portfolio Manager Code:";
                cmdTestMM.Visible = false;
                txtPMCode.Enabled = false;
                lblPMAssemblyName.Visible = false;
            }
            else
            {
                txtPMRRR.Text = SelectedPM.RiskRewardRatio.ToString();
                UpdatePMProperties();

                if (SelectedPM.IsInline)
                {
                    txtPMCode.Text = SelectedPM.CodeParameter;
                    lblPMCode.Text = "Portfolio Manager Code:";
                    cmdTestMM.Visible = true;
                    txtPMCode.Enabled = true;
                    lblPMAssemblyName.Visible = false;
                }
                else
                {
                    txtPMCode.Text = "CANNOT EDIT PM CODE IN ASSEMBLY TYPE";
                    txtPMCode.Enabled = false;
                    lblPMCode.Text = "Portfolio Manager Assembly:";
                    cmdTestMM.Visible = false;
                    lblPMAssemblyName.Visible = true;
                    lblPMAssemblyName.Text = SelectedPM.CodeParameter;
                }
            }
        }

        private void UpdatePMProperties()
        {
            if (false == CheckItemSelected()) return;

            pmBag.Properties.Clear();

            if (SelectedPM.InternalObject.PortfolioManagerInput != null)
            {
                foreach (string param in SelectedPM.InternalObject.PortfolioManagerInput.Keys)
                {
                    pmBag.Properties.Add(new PropertySpec(param, typeof(string)));
                }

                FileUtils.SyncDictionaries(SelectedPM.InternalObject.PortfolioManagerInput, SelectedPM.PortfolioManagerInput);
            }

            PMProperties.SelectedObject = pmBag;
        }

        void pmBag_SetValue(object sender, PropertySpecEventArgs e)
        {
            if (false == CheckItemSelected()) return;

            SelectedPM.PortfolioManagerInput[e.Property.Name] = e.Value;
        }

        void pmBag_GetValue(object sender, PropertySpecEventArgs e)
        {
            if (false == CheckItemSelected()) return;

            e.Value = SelectedPM.PortfolioManagerInput[e.Property.Name];
        }

        private void cmdNewPM_Click(object sender, EventArgs e)
        {
            PortfolioManager pm = new PortfolioManager();
            pm.CodeParameter = RuntimeHelper.GetDefaultPortfolioManagerCode();
            pm.IsInline = true;
            runtimeManager.PortfolioManagers.Add(pm);

            lstPMs.Items.Add(pm.Name);
            SelectLastItem();
        }

        private void SelectLastItem()
        {
            lstPMs.SelectedIndex = lstPMs.Items.Count - 1;
        }

        private void cmdDeletePM_Click(object sender, EventArgs e)
        {
            if (!CheckItemSelected()) return;

            int oldIndex = lstPMs.SelectedIndex;

            runtimeManager.PortfolioManagers.Remove(SelectedPM);

            isSaving = true;
            lstPMs.Items.RemoveAt(oldIndex);
            isSaving = false;

            lstPMs.SelectedIndex = Math.Min(oldIndex, lstPMs.Items.Count - 1);

            if (lstPMs.SelectedIndex == -1)
            {
                //this call will empty UI
                LoadSelectedItemIntoUI();
            }
        }

        private bool CheckItemSelected()
        {
            if (lstPMs.SelectedIndex == -1)
            {
                MessageBox.Show("you have to select an item first");
                return false;
            }

            return true;
        }

        private void cmdSavePM_Click(object sender, EventArgs e)
        {
            SaveSelectedItem();

            isSaving = true;
            lstPMs.Items[lstPMs.SelectedIndex] = SelectedPM.Name;
            isSaving = false;

            
        }

        private bool SaveSelectedItem()
        {
            if (false == CheckItemSelected()) return true;

            //check for name
            if (SelectedPM.IsInline)
            {
                SelectedPM.CodeParameter = txtPMCode.Text;
            }

            foreach (PortfolioManager pm in runtimeManager.PortfolioManagers)
            {
                if (pm.Name == SelectedPM.Name && !pm.Equals(SelectedPM) )
                {
                    MessageBox.Show("name repeated");
                    return false;
                }
            }

            if (runtimeManager.DefaultPortfolioManager == null)
            {
                runtimeManager.DefaultPortfolioManagerName = "";
                lblDefaultPortfolioManager.Text = runtimeManager.DefaultPortfolioManagerName;
            }

            SelectedPM.RiskRewardRatio = double.Parse(txtPMRRR.Text);

            return true;
        }

        private void cmdSetDefaultPM_Click(object sender, EventArgs e)
        {
            if (false == CheckItemSelected()) return;

            lblDefaultPortfolioManager.Text = SelectedPM.Name;
            runtimeManager.DefaultPortfolioManagerName = SelectedPM.Name;
        }

        private void cmdTestMM_Click(object sender, EventArgs e)
        {
            if (SelectedPM == null) return;
            Assert.IsTrue(SelectedPM.IsInline);

            SelectedPM.CodeParameter = txtPMCode.Text;

            string msg;
            bool done = SelectedPM.TestCompile(out msg);

            if (false == done)
            {
                MessageBox.Show("Error: " + msg);
            }
            else
            {
                MessageBox.Show("OK!");
            }
        }

        private void cmdCloseSave_Click(object sender, EventArgs e)
        {
            //pmDesignHelper.OnSave();
            if (false == SaveSelectedItem()) return;

            RuntimeManager.Save();
            Close();
        }

        private void cmdCloseNoSave_Click(object sender, EventArgs e)
        {
            RuntimeManager.Reload();
            Close();
        }

        private void cmdNewAssembly_Click(object sender, EventArgs e)
        {
            string filePath = FileUtils.AskAssemblyFile();
            if (filePath == null) return;

            string fileName = Path.GetFileName(filePath);
            string targetPath = Path.Combine(FileUtils.PortfolioManagerLibFolder, fileName);

            if (File.Exists(targetPath))
            {
                if (MessageBox.Show("A file with the same name exists. Overwrite?", "", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }

            File.Copy(filePath, targetPath, true);

            PortfolioManager pm = new PortfolioManager();
            pm.CodeParameter = fileName;
            pm.IsInline = false;
            runtimeManager.PortfolioManagers.Add(pm);

            lstPMs.Items.Add(pm.Name);
            SelectLastItem();
        }

        private void lstPMs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isSaving) return;
            if (SelectedPM == null) return;

            LoadSelectedItemIntoUI();
        }

        private void cmdRefreshProps_Click(object sender, EventArgs e)
        {
            UpdatePMProperties();
        }
    }
}
