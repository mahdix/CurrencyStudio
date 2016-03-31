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
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;

namespace CurrencyStudio
{
    public partial class frmDataProviderInspector : Form
    {
        public frmDataProviderInspector()
        {
            InitializeComponent();
        }

        private MarketProviderManager mpm = null;
        private DataProvider activeDp = null;
        private PriceChart pc = new PriceChart();
        private MarketWatch activeMarketWatch = null;
        int candleCounter = 0;

        private void CreateParameters()
        {
            if (cboDataProvider.SelectedIndex == -1) return;
            if (cboMarketProvider.SelectedIndex == -1) return;

            MarketProviderDescriptor mpd = mpm.MarketProviders[cboMarketProvider.SelectedIndex];
            DataProviderDescriptor dpd = mpd.DataProviders[cboDataProvider.SelectedIndex];

            activeDp = dpd.Create();
            activeMarketWatch = mpd.MarketWatch.Create();

            activeDp.MarketWatch = activeMarketWatch;
        }


        private void frmDataProviderInspector_Load(object sender, EventArgs e)
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

            if (cboTimeFrame.Items.Count == 0)
            {
                cboTimeFrame.Items.Add("Data Provider Tick");
                //populate list
                foreach (string name in Enum.GetNames(typeof(TimeFrameType)))
                {
                    cboTimeFrame.Items.Add(name);
                }
            }

            pc.Setup(this,dpChart, "ChartArea1", "Series1");
            pc.InitializeWithDefaults();
            pc.SelectedPointChanged += new PointInfoUpdateHandler(pc_SelectedPointChanged);
        }

        //private TimeFrameType ComboBoxIndexToTimeFrame(int idx)
        //{
        //    int i = 0;
        //    foreach (int tfVal in Enum.GetValues(typeof(TimeFrameType)))
        //    {
        //        if (i == idx)
        //        {
        //            return (TimeFrameType) tfVal;
        //        }

        //        i++;
        //    }

        //    return TimeFrameType.M1;

        //}
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

        private void cmdStart_Click(object sender, EventArgs e)
        {
            if (false == ValidateInputs())
            {
                return;
            }

            if (cboTimeFrame.SelectedIndex == 0)
            {
                activeDp.OnTickEvent += new OnTickHandler(delegate(Tick tick)
                    {
                        candleCounter++;

                        pc.Tick(tick.Time, tick.Bid);

                        this.Invoke(new MethodInvoker(delegate()
                        {
                            lblCandleCount.Text = candleCounter.ToString();
                        }));
                    });
            }
            else
            {
                //TimeFrameType tfType = ComboBoxIndexToTimeFrame(cboTimeFrame.SelectedIndex);
                //string instrument = txtInstruments.Text;
                TimeFrame tf = Utils.GetTimeFrame(activeMarketWatch.FindInstrument(txtInstruments.Text), cboTimeFrame.SelectedItem.ToString());

                if (tf == null)
                {
                    MessageBox.Show("Error creating tf");
                    return;
                }

                tf.OnTickEvent += new OnTickHandler(delegate(Tick tick)
                    {
                        candleCounter++;

                        pc.Tick(tick.Time, tick.Bid);

                        this.Invoke(new MethodInvoker(delegate()
                        {
                            lblCandleCount.Text = candleCounter.ToString();
                        }));
                    });
            }

            candleCounter = 0;
            activeDp.Activate();

            if (activeDp.IsOffline == true)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(readCandles));
            }

            cmdStart.Enabled = false;
            cmdStop.Enabled = true;
            
        }

        private bool ValidateInputs()
        {
            if (cboDataProvider.SelectedIndex == -1)
            {
                MessageBox.Show("Please select dp first");
                return false;
            }

            //create activeDP and marketwatch
            CreateParameters();

            if (activeDp == null || activeMarketWatch == null)
            {
                MessageBox.Show("Error creating params");
                return false;
            }

            if (false == Utils.IsInstrumentMatch(activeDp.Instruments, txtInstruments.Text))
            {
                MessageBox.Show("instruments must be supported by selected tf");
                return false;
            }

            if (activeMarketWatch.FindInstrument(txtInstruments.Text) == null)
            {
                MessageBox.Show("Selected market provider does not support selected instrument");
                return false;
            }

            return true;
        }

        void pc_SelectedPointChanged(DataPoint point)
        {
            string msg = Utils.DateString(DateTime.FromOADate(point.XValue));
            string msg2 = string.Format("O:{0} | H:{1} | L:{2} | C:{3}",
                point.YValues[2], point.YValues[0], point.YValues[1], point.YValues[3]);

            lblStatus.Text = msg + " | " + msg2;
        }

        private void readCandles(object data)
        {
          
            while (activeDp.IsFinished == false)
            {
                candleCounter++;
                Candle c = activeDp.GetNextCandle();
                pc.AddPoint(c.Time, c.High, c.Low, c.Open, c.Close);

                this.Invoke(new MethodInvoker(delegate()
                    {
                        lblCandleCount.Text = candleCounter.ToString();
                    }));
            }
        }

        private void frmDataProviderInspector_FormClosing(object sender, FormClosingEventArgs e)
        {
            activeDp.Deactivate();
        }

        private void cmdStop_Click(object sender, EventArgs e)
        {
            activeDp.Deactivate();

            cmdStop.Enabled = false;
            cmdStart.Enabled = true;
        }

    
    }
}
