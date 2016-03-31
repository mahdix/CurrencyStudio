using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CurrencyStudio.Core;
using CurrencyStudio.Core.Market;
using CurrencyStudio.Core.Trade;
using CurrencyStudio.Core.Helper;
using ZedGraph;
using CurrencyStudio.Core.UI;
using CurrencyStudio.Core.RuntimeSystem;

namespace CurrencyStudio
{
    public partial class frmMain2 : Form
    {
        private SimEngine simEngine = null;
        private frmExpertDesigner frmExpertDesigner = new frmExpertDesigner();
        private frmMarketProviderDesigner frmMPDesigner = new frmMarketProviderDesigner();
        private frmAccountDesigner frmAccDesigner = new frmAccountDesigner();

        public frmMain2()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Instrument i = QuoteReaderEngine.ReadQuotesFromCSV(path, 1, "EURUSD");
            Logger.GetInstance().statForm = this;
            Logger.GetInstance().LogListBox = listBox1;
            Logger.GetInstance().PositionList = listView1;

            simEngine = new SimEngine();
            simEngine.Initialize();
            
            UpdateDefaults();
        }

        private void testhcart()
        {
            ZGraphPriceChart pc = new ZGraphPriceChart();
            pc.Initialize("TITLE", zedGraphControl1);
            pc.AddTick(DateTime.Now, 1.20);
            pc.AddTick(DateTime.Now, 1.12);
            pc.AddTick(DateTime.Now, 1.30);
            pc.AddTick(DateTime.Now, 1.27);
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < int.Parse(txtStep.Text); i++)
            {
                simEngine.Tick();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmExpertDesigner.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmMPDesigner.Show();
        }



        internal void UpdateDefaults()
        {
            lblDefaultExpert.Text = RuntimeManager.GetInstance().DefaultExpertName;
            lblDefaultMP.Text = MarketProviderManager.GetInstance().DefaultMarketProviderName;
            lblDefaultAccount.Text = AccountManager.GetInstance().DefaultAccountName;
            lblDefaultPM.Text = RuntimeManager.GetInstance().DefaultPortfolioManagerName;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmAccDesigner.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmPortfolioManagers f = new frmPortfolioManagers();
            f.ShowDialog();

            UpdateDefaults();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new frmSignals().ShowDialog();

            UpdateDefaults();
        }

        private void cmdCommonLibs_Click(object sender, EventArgs e)
        {
            frmCommonLib frm = new frmCommonLib();

            frm.ShowDialog();
        }
    }
}
