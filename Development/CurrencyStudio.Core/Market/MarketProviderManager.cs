using System;
using System.IO;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Text;
using CurrencyStudio.Core.Helper;
using CurrencyStudio.Core.Market.Data;
using CurrencyStudio.Core.Market.Descriptor;
using CurrencyStudio.Core.RuntimeSystem;

namespace CurrencyStudio.Core.Market
{
    [Serializable]
    public class MarketProviderManager
    {
        private static MarketProviderManager instance = null;

        public static MarketProviderManager GetInstance()
        {
            if (instance == null)
            {
                instance = Load();
            }

            return instance;
        }

        public List<MarketProviderDescriptor> MarketProviders = new List<MarketProviderDescriptor>();

        public string DefaultMarketProviderName = "";

        public MarketProviderDescriptor GetDefaultMarketProviderDescriptor()
        {
            return FindMarketProvider(DefaultMarketProviderName);
        }

        private static MarketProvider marketProvider = null;
        public MarketProvider DefaultMarketProvider
        {
            get
            {
                if (marketProvider == null)
                {
                    MarketProviderDescriptor mpd = GetDefaultMarketProviderDescriptor();

                    if (mpd != null)
                    {
                        marketProvider = GetDefaultMarketProviderDescriptor().Create();
                    }
                }

                return marketProvider;
            }
        }

        public MarketProviderDescriptor FindMarketProvider(string name)
        {
            foreach(MarketProviderDescriptor mpd in MarketProviders )
            {
                if ( mpd.Name == name )
                {
                    return mpd;
                }
            }

            return null;
        }

        public static MarketProviderManager Load()
        {
            string filePath = CurrencyStudio.Core.Helper.Def.MarketProviderManagerFileName;

            FileStream fs = new FileStream(filePath, FileMode.Open);
            MarketProviderManager result = Serializers.MarketProviderManagerSerializer.Deserialize(fs) as MarketProviderManager;

            fs.Close();
            marketProvider = null;

            return result;
        }

        public static void Reload()
        {
            instance = Load();
        }

        public static void Save()
        {
            string filePath = CurrencyStudio.Core.Helper.Def.MarketProviderManagerFileName;
            FileStream fs = new FileStream(filePath, FileMode.Create);

            try
            {
                Serializers.MarketProviderManagerSerializer.Serialize(fs, instance);
            }
            catch (Exception exc)
            {
                int g = 12;
            }
            fs.Close();
            marketProvider = null;
        }
    }
}
