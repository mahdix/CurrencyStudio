using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using CurrencyStudio.Core.Market;
using CurrencyStudio.Core.Helper;
using System.Windows.Forms;
using NDde.Client;


namespace CurrencyStudio.Core.Market.Data
{
    public class MT4DataProvider : DataProvider
    {
        public MT4DataProvider()
        {
            isOffline = false;
        }

        private DdeClient ddeClient = null;

        public override bool IsFinished
        {
            get
            {
                return false;
            }
        }

        public override void Activate()
        {
            ddeClient = new DdeClient("MT4", "QUOTE");
            ddeClient.Connect();
            //TODO: we should process all list items here
            ddeClient.StartAdvise(this.Instruments[0], 1, true, 6000);
            ddeClient.Advise += new EventHandler<DdeAdviseEventArgs>(ddeClient_Advise);
        }

        void ddeClient_Advise(object sender, DdeAdviseEventArgs e)
        {
            //item is instrument name
            //text is  2010/07/15 21:27 1.29012 1.29016

            Tick t = new Tick();
            t.Instrument = e.Item;
            string[] parts = e.Text.Split(' ');

            t.Time = DateTime.Parse(parts[0] + " " + parts[1]);
            t.Bid = double.Parse(parts[2]);
            t.Ask = double.Parse(parts[3]);

            FireTickEvent(t);

            if (MarketWatch != null)
            {
                MarketWatch.Tick(t.Instrument, t.Time, t.Bid, t.Ask);
            }
        }

        public override void Deactivate()
        {
            if (ddeClient != null && ddeClient.IsConnected)
            {
                ddeClient.Disconnect();
            }
        }

        public override void SetParameter(string key, string value)
        {
        }

        public new static void LoadParametersToGUI(DataProviderParameters parameters, TableLayoutPanel gui)
        {
            gui.Controls.Clear();
        }

        private static void InitParams(DataProviderParameters parameters)
        {
        }

        //private static void AddLabel(string text, int r, int c, TableLayoutPanel gui)
        //{
        //    Label lbl = new Label();
        //    lbl.Text = text;

        //    gui.Controls.Add(lbl, c, r);
        //}

        //private static void AddTextBox(string id, string text, int r, int c, TableLayoutPanel gui)
        //{
        //    TextBox txt = new TextBox();
        //    txt.Name = id;
        //    txt.Text = text;
        //    txt.BorderStyle = BorderStyle.FixedSingle;
        //    txt.Dock = DockStyle.Fill;

        //    gui.Controls.Add(txt, c, r);
        //}

        public new static void ReadParametersFromGUI(DataProviderParameters parameters, TableLayoutPanel gui)
        {
        }
    }
}
