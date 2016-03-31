using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CurrencyStudio.Core.Helper;
using CurrencyStudio.Core.Market.Data;
using CurrencyStudio.Core.Market;
using CurrencyStudio.Core.Market.Descriptor;

namespace CurrencyStudio
{
    public partial class frmMarketProviderDesigner : Form
    {
        public frmMarketProviderDesigner()
        {
            InitializeComponent();
        }

        private MarketProviderManager mpm = null;
        private MarketProviderDescriptor selectedMP = null;
        private DataProviderDescriptor selectedDP = null;
        private InstrumentDescriptor selectedInst = null;

        private bool isSavingInstrument = false;
        private bool isSavingDP = false;
        private bool isSavingMP = false;

        private void frmMarketProviderDesigner_Load(object sender, EventArgs e)
        {
            mpm = MarketProviderManager.GetInstance();

            foreach (MarketProviderDescriptor mpd in mpm.MarketProviders)
            {
                lstMarketProviders.Items.Add(mpd.Name);
            }

            if (chkInstTimeFrames.Items.Count == 0)
            {
                //populate list
                foreach (string name in Enum.GetNames(typeof(TimeFrameType)))
                {
                    chkInstTimeFrames.Items.Add(name);
                }
            }

            if (cboDPType.Items.Count == 0)
            {
                foreach (string name in Enum.GetNames(typeof(DataProviderType)))
                {
                    cboDPType.Items.Add(name);
                }
                
            }

            lblDefaultMP.Text = mpm.DefaultMarketProviderName;
        }

        private void lstMarketProviders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isSavingMP) return;

            if (lstMarketProviders.SelectedIndex == -1)
            {
                EnableControls(false, tabControl1);
            }
            else
            {
                EnableControls(true, tabControl1);
            }

            SaveSelectedMarketProvider();

            selectedMP = mpm.MarketProviders[lstMarketProviders.SelectedIndex];
            txtMPName.Text = selectedMP.Name;
            chkIsLive.Checked = selectedMP.IsLive;

            lstDataProviders.Items.Clear();

            foreach (DataProviderDescriptor dpd in selectedMP.DataProviders)
            {
                lstDataProviders.Items.Add(dpd.Name);
            }

            lstDataProviders.SelectedIndex = -1;
            selectedDP = null;

            lstInstruments.Items.Clear();
            foreach (InstrumentDescriptor id in selectedMP.MarketWatch.Instruments)
            {
                lstInstruments.Items.Add(id.Name);
            }

            selectedInst = null;

            //re-enable or disable inst controls
            RefreshDataProviderEnableStatus();
            RefreshInstrumentEnableStatus();
        }

        private void lstInstruments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( isSavingInstrument ) return;

            RefreshInstrumentEnableStatus();

            if (lstInstruments.SelectedIndex == -1) return;
            SaveSelectedInstrumentData();

            selectedInst = selectedMP.MarketWatch.Instruments[lstInstruments.SelectedIndex];

            txtInstrumentName.Text = selectedInst.Name;
            txtInstPointSize.Text = selectedInst.Point.ToString();
            txtInstSpread.Text = selectedInst.DefaultSpreadPoints.ToString();
            txtInstContractSize.Text = selectedInst.ContractSize.ToString();

            for (int i = 0; i < chkInstTimeFrames.Items.Count; i++)
            {
                chkInstTimeFrames.SetItemChecked(i, false);
            }

            foreach (int tf in selectedInst.TimeFrames)
            {
                int chkIdx = TimeFrameToCheckBoxListIndex(tf);
                chkInstTimeFrames.SetItemChecked(chkIdx, true);
            }
        }

        private void RefreshInstrumentEnableStatus()
        {
            if (lstInstruments.SelectedIndex == -1)
            {
                EnableControls(false, txtInstContractSize, txtInstPointSize, txtInstrumentName, txtInstSpread, txtInstContractSize, chkInstTimeFrames);
            }
            else
            {
                EnableControls(true, txtInstContractSize, txtInstPointSize, txtInstrumentName, txtInstSpread, txtInstContractSize, chkInstTimeFrames);
            }
        }

        private void EnableControls(bool enable, params Control[] ctls)
        {
            foreach (Control ctl in ctls)
            {
                ctl.Enabled = enable;
            }
        }

        private void SaveSelectedInstrumentData()
        {
            if (selectedInst == null) return;

            if (selectedInst.Name != txtInstrumentName.Text)
            {
                if (selectedMP.MarketWatch.FindInstrument(txtInstrumentName.Text) != null)
                {
                    MessageBox.Show("Instrument Name is Repeated");
                    return;
                }
            }

            selectedInst.Name = txtInstrumentName.Text;

            selectedInst.Point = double.Parse(txtInstPointSize.Text);
            selectedInst.DefaultSpreadPoints = int.Parse(txtInstSpread.Text);
            selectedInst.ContractSize = int.Parse(txtInstContractSize.Text);

            List<int> tfs = new List<int>();
            foreach (int chkIdx in chkInstTimeFrames.CheckedIndices)
            {
                int tfVal = CheckBoxListIndexToTimeFrame(chkIdx);
                tfs.Add(tfVal);
            }

            selectedInst.TimeFrames = tfs;

            isSavingInstrument = true;
            //update UI listbox
            lstInstruments.Items[selectedMP.MarketWatch.Instruments.IndexOf(selectedInst)] = selectedInst.Name;
            isSavingInstrument = false;
        }

        private int TimeFrameToCheckBoxListIndex(int val)
        {
            int i = 0;
            foreach (int tfVal in Enum.GetValues(typeof(TimeFrameType)))
            {
                if (tfVal == val)
                {
                    return i;
                }

                i++;
            }

            return -1;

        }

        private int CheckBoxListIndexToTimeFrame(int idx)
        {
            int i = 0;
            foreach (int tfVal in Enum.GetValues(typeof(TimeFrameType)))
            {
                if (i == idx)
                {
                    return tfVal;
                }

                i++;
            }

            return -1;

        }


        private void SaveSelectedMarketProvider()
        {
            if (selectedMP == null) return;

            SaveSelectedInstrumentData();

            if ( false == SaveSelectedDP() )
            {
                return;
            }

            if (selectedMP.Name != txtMPName.Text)
            {
                if (mpm.FindMarketProvider(txtMPName.Text) != null)
                {
                    MessageBox.Show("MP is repeated");
                    return;
                }
            }

            selectedMP.Name = txtMPName.Text;
            selectedMP.IsLive = chkIsLive.Checked;
            isSavingMP = true;
            lstMarketProviders.Items[mpm.MarketProviders.IndexOf(selectedMP)] = selectedMP.Name;
            isSavingMP = false;

            return;
        }

        private void lstDataProviders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isSavingDP) return;
            RefreshDataProviderEnableStatus();

            if (lstDataProviders.SelectedIndex == -1) return;

            SaveSelectedDP();

            selectedDP = selectedMP.DataProviders[lstDataProviders.SelectedIndex];

            txtDPName.Text = selectedDP.Name;
            txtInstruments.Text = Utils.ListToDelimitedString(selectedDP.Instruments);
            int oldCboIndex = cboDPType.SelectedIndex;

            cboDPType.SelectedIndex = (int)selectedDP.Type;

            //if they are equal, seleindexchanged event is not fired
            //we fire it manually here
            if (oldCboIndex == (int)selectedDP.Type)
            {
                cboDPType_SelectedIndexChanged(this, EventArgs.Empty);
            }
        }

        private void RefreshDataProviderEnableStatus()
        {
            if (lstDataProviders.SelectedIndex == -1)
            {
                EnableControls(false, txtDPName, cboDPType, pnlDPProps);
            }
            else
            {
                EnableControls(true, txtDPName, cboDPType, pnlDPProps);
            }
        }

        private bool SaveSelectedDP()
        {
            if (selectedDP == null) return true;

            if (selectedDP.Name != txtDPName.Text)
            {
                if (selectedMP.FindDataProviderDescriptor(txtDPName.Text) != null)
                {
                    MessageBox.Show("DP repeated");
                    return false;
                }
            }

            selectedDP.Name = txtDPName.Text;
            selectedDP.Type = (DataProviderType)cboDPType.SelectedIndex;
            Utils.DelimitedStringToList(txtInstruments.Text, selectedDP.Instruments);
            SaveDPPanel(selectedDP);

            isSavingDP = true;
            //update UI lsitbox
            lstDataProviders.Items[selectedMP.DataProviders.IndexOf(selectedDP)] = selectedDP.Name;
            isSavingDP = false;

            return true;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            //new mp
            string name= "default";
            int counter = 0;


            while (mpm.FindMarketProvider(name + counter.ToString()) != null) counter++;

            MarketProviderDescriptor mpd = new MarketProviderDescriptor();
            mpd.Name = name + counter.ToString();
            mpm.MarketProviders.Add(mpd);

            lstMarketProviders.Items.Add(mpd.Name);
            lstMarketProviders.SelectedIndex = lstMarketProviders.Items.Count - 1;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            SaveSelectedMarketProvider();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (selectedMP == null) return;

            //new data provider
            DataProviderDescriptor dpdes = new DataProviderDescriptor();
            dpdes.Name = Utils.FindUniqueName(selectedMP.FindDataProviderDescriptor, "DefaultDP");
            selectedMP.DataProviders.Add(dpdes);

            lstDataProviders.Items.Add(dpdes.Name);
            lstDataProviders.SelectedIndex = lstDataProviders.Items.Count - 1;

            selectedDP = dpdes;
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            //delete mp
            int idx = lstMarketProviders.SelectedIndex;
            if (idx == -1) return;

            mpm.MarketProviders.RemoveAt(idx);

            lstMarketProviders.Items.RemoveAt(idx);

            if (idx < lstMarketProviders.Items.Count)
            {
                lstMarketProviders.SelectedIndex = idx;
            }
            else
            {
                lstMarketProviders.SelectedIndex = lstMarketProviders.Items.Count-1;
            }
        }

        private void cmdSaveMP_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            //delete dp
            //delete mp
            int idx = lstDataProviders.SelectedIndex;

            if (idx == -1) return;

            selectedMP.DataProviders.RemoveAt(idx);

            lstDataProviders.Items.RemoveAt(idx);

            if (idx < lstDataProviders.Items.Count)
            {
                lstDataProviders.SelectedIndex = idx;
            }
            else
            {
                lstDataProviders.SelectedIndex = lstDataProviders.Items.Count - 1;
            }

        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            //new instrument
            //new data provider
            string name = "defaultins";
            int counter = 0;

            if (selectedMP == null) return;

            while (selectedMP.MarketWatch.FindInstrument(name + counter.ToString()) != null) counter++;

            InstrumentDescriptor id = new InstrumentDescriptor();
            id.Name = name + counter.ToString();
            
            selectedMP.MarketWatch.Instruments.Add(id);

            lstInstruments.Items.Add(id.Name);
            lstInstruments.SelectedIndex = lstInstruments.Items.Count - 1;
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            SaveSelectedInstrumentData();
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            //delete inst
            int idx = lstInstruments.SelectedIndex;

            if (idx == -1) return;

            selectedMP.MarketWatch.Instruments.RemoveAt(idx);

            lstInstruments.Items.RemoveAt(idx);

            selectedInst = null;

            if (idx < lstInstruments.Items.Count)
            {
                lstInstruments.SelectedIndex = idx;
            }
            else
            {
                lstInstruments.SelectedIndex = lstDataProviders.Items.Count - 1;
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            mpm.DefaultMarketProviderName = lstMarketProviders.Items[lstMarketProviders.SelectedIndex].ToString();
            lblDefaultMP.Text = mpm.DefaultMarketProviderName;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            MarketProviderManager.Reload();
            Hide();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SaveSelectedMarketProvider();

            MarketProviderManager.Save();
            Hide();
        }

        private void cboDPType_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDPPanel((DataProviderType)cboDPType.SelectedIndex);
        }

        private void RefreshDPPanel(DataProviderType type)
        {
            selectedDP.Parameters.Clear();

            DataProvider.LoadParametersToGUI(type, selectedDP.Parameters, tblDPProps);
        }

        private void SaveDPPanel(DataProviderDescriptor selectedDP)
        {
            DataProvider.ReadParametersFromGUI(selectedDP.Type, selectedDP.Parameters, tblDPProps);
        }

    }

}
