using System;
using System.Collections.Generic;
using System.Text;
using CurrencyStudio.Core.Helper;
using CurrencyStudio.Core.Market.Data;


namespace CurrencyStudio.Core.Market
{
    public class MarketProvider
    {
        public string Name = "";
        public bool IsLive = false;
        public List<DataProvider> DataProviders = new List<DataProvider>();

        //generate ticks from offline store and inform market
        public void SimulateTicks(int steps)
        {
            if (IsLive)
            {
                throw new Exception("Cannot simulate ticks in a live market");
            }

            foreach (DataProvider dp in DataProviders)
            {
                if (!dp.IsOffline)
                {
                    throw new Exception("Cannot simulate ticks within a live data market");
                }

                dp.SimulateTicks(steps);
            }
        }

        public void Activate()
        {
            foreach (DataProvider dp in DataProviders)
            {
                dp.MarketWatch = this.marketWatch;
                dp.Activate();
            }
        }

        public void Deactivate()
        {
            foreach (DataProvider dp in DataProviders)
            {
                dp.Deactivate();
            }
        }


        private MarketWatch marketWatch = null;
        public MarketWatch MarketWatch
        {
            get
            {
                return marketWatch;
            }
            set
            {
                marketWatch = value;
            }
        }
    }
}
