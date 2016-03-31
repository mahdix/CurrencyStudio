using System;
using System.Collections;
using System.Xml;
using System.Collections.Generic;
using System.Text;
using CurrencyStudio.Core.Helper;
using CurrencyStudio.Core.Market.Data;

namespace CurrencyStudio.Core.Market.Descriptor
{
    [Serializable]
    public class MarketProviderDescriptor
    {
        public string Name = "";
        public bool IsLive = false;
        public List<DataProviderDescriptor> DataProviders = new List<DataProviderDescriptor>();
        public MarketWatchDescriptor MarketWatch = new MarketWatchDescriptor();

        public DataProviderDescriptor FindDataProviderDescriptor(string name)
        {
            foreach (DataProviderDescriptor dp in DataProviders)
            {
                if (dp.Name == name)
                {
                    return dp;
                }
            }
            return null;
        }

        public MarketProvider Create()
        {
            MarketProvider result = new MarketProvider();

            result.Name = Name;
            result.IsLive = IsLive;
            result.MarketWatch = MarketWatch.Create();

            foreach (DataProviderDescriptor dpd in DataProviders)
            {
                result.DataProviders.Add(dpd.Create());
            }

            return result;
        }
    }
}
