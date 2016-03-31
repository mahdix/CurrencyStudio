using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CurrencyStudio.Core.Helper;
using CurrencyStudio.Core.UI;
using CurrencyStudio.Core.Market.Data;
using CurrencyStudio.Core.Market;
using CurrencyStudio.Core.Market.Descriptor;
using CurrencyStudio.Core.RuntimeSystem;
using CurrencyStudio.Core.RuntimeSystem.Interface;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;

namespace CurrencyStudio
{
    public partial class frmSignalDebugger : Form
    {
        public frmSignalDebugger()
        {
            InitializeComponent();
        }

        private MarketProviderManager mpm = null;
        private DataProvider activeDp = null;
        private PriceChart pc = new PriceChart();
        private string selectedTmplateName = "";
        private SignalInstance activeSignal = null;
        private PriceChart priceChart = new PriceChart();
        private PriceChart signalChart = new PriceChart();
        private MarketProviderDescriptor mpd = null;
        private MarketWatch marketWatch = null;
        private int candleCounter = 0;

        private void frmSignalDebugger_Load(object sender, EventArgs e)
        {
            mpm = MarketProviderManager.GetInstance();

            foreach (MarketProviderDescriptor mp in mpm.MarketProviders)
            {
                cboMarketProvider.Items.Add(mp.Name);
            }

            if (cboMarketProvider.Items.Count > 0)
            {
                cboMarketProvider.SelectedIndex = 0;
            }

            priceChart.Setup(this, dpChart, "ChartArea1", "PriceSeries");
            signalChart.Setup(this, dpChart, "ChartArea1", "SignalSeries");
            
            priceChart.InitializeWithDefaults();
            signalChart.InitializeWithDefaults();

            signalChart.DrawColor = Color.White;
            signalChart.ZoomByMouseWheelEnabled = false;
            signalChart.ScrollByMouseWheelEnabled = false;
            signalChart.AutoZoomPricesEnabled = false;

            //pc.SelectedPointChanged += new PointInfoUpdateHandler(pc_SelectedPointChanged);*/
        }

        private DataProvider GetSelectedDataProvider()
        {
            if (cboDataProvider.SelectedIndex == -1) return null;
            if (cboMarketProvider.SelectedIndex == -1) return null;

            DataProviderDescriptor dpd = mpd.DataProviders[cboDataProvider.SelectedIndex];

            return dpd.Create();
        }

        private void cboMarketProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = cboMarketProvider.SelectedIndex;

            foreach (DataProviderDescriptor dp in mpm.MarketProviders[idx].DataProviders)
            {
                cboDataProvider.Items.Add(dp.Name);
            }

            if (cboDataProvider.Items.Count > 0)
            {
                cboDataProvider.SelectedIndex = 0;
            }
        }

        private void cmdSelectSignal_Click(object sender, EventArgs e)
        {
            frmSelectSignalDef frm = new frmSelectSignalDef();

            if (frm.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            selectedTmplateName = frm.SelectedSignalDefinitionName;
            lblSignalName.Text = selectedTmplateName;

            activeSignal = new SignalInstance();
            activeSignal.DefinitionName = selectedTmplateName;

            //create a unique name so caching will not have conflicts
            activeSignal.Name = "Temp"+DateTime.Now.Ticks.ToString();
        }

        private void cmdSetProps_Click(object sender, EventArgs e)
        {
            frmSignalProperties frm = new frmSignalProperties();
            frm.signal = activeSignal;

            frm.ShowDialog();
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            if (cboDataProvider.SelectedIndex == -1)
            {
                MessageBox.Show("Please select dp first");
                return;
            }

            if (activeSignal == null)
            {
                MessageBox.Show("Please select a signal first");
                return;
            }

            mpd = mpm.MarketProviders[cboMarketProvider.SelectedIndex];
            marketWatch = mpd.MarketWatch.Create();

            activeDp = GetSelectedDataProvider();
            activeDp.MarketWatch = marketWatch;

            if (false == Utils.IsInstrumentMatch(activeDp.Instruments, activeSignal.Instruments[0]))
            {
                MessageBox.Show("Signal and Data Provider instruments do not match");
                return; ;
            }

            activeSignal.Activate(); 
            
            if (false == activeDp.IsOffline)
            {
                string tf = activeSignal.TimeFrame;

                TimeFrame tfObj = Utils.GetTimeFrame(marketWatch.FindInstrument(activeSignal.Instruments[0]), tf);
                tfObj.OnTickEvent += new OnTickHandler(delegate(Tick tick)
                    {
                        candleCounter++;

                        this.Invoke(new MethodInvoker(delegate()
                        {
                            lblCandleCount.Text = candleCounter.ToString();
                        }));

                        //find dp instrument object in market
                        SignalOutput sigOut = activeSignal.Execute(tick, marketWatch);

                        if (sigOut != null)
                        {
                            //plot signal output for this time
                            double signalValue = (double)sigOut[Def.DefaultSignalOutputKey];

                            signalChart.AddPoint(tick.Time, signalValue);
                        }

                        //plot price and sigOut on the price chart
                        priceChart.Tick(tick.Time, tick.Bid);

                    });
            }

            activeDp.Activate();
            stopFlag = false;

            if ( activeDp.IsOffline )
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(testSignal));
            }

            cmdStop.Enabled = true;
            cmdStart.Enabled = false;

        }

        private bool stopFlag = false;
        private void testSignal(object data)
        {
            Tick tick = activeDp.GetNextTick();

            while (tick != null)
            {
                if (stopFlag) break;

                candleCounter++;

                this.Invoke(new MethodInvoker(delegate()
                {
                    lblCandleCount.Text = candleCounter.ToString();
                }));

                //find dp instrument object in market
                SignalOutput sigOut = activeSignal.Execute(tick,marketWatch);

                if (sigOut != null)
                {
                    //plot signal output for this time
                    double signalValue = (double)sigOut[Def.DefaultSignalOutputKey];

                    signalChart.AddPoint(tick.Time, signalValue);
                }

                //plot price and sigOut on the price chart
                priceChart.Tick(tick.Time, tick.Bid);

                //read next tick
                tick = activeDp.GetNextTick();
            };

            cmdStart.Enabled = true;
            activeSignal.Deactivate();
            activeDp.Deactivate();
        }

        private void cmdStop_Click(object sender, EventArgs e)
        {
            if (activeDp.IsOffline == false)
            {
                activeSignal.Deactivate();
                activeDp.Deactivate();
            }
            else
            {
                stopFlag = true;
            }

            cmdStop.Enabled = false;
        }
    }
}
