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
    public class DataProviderDescriptor
    {
        public DataProviderType Type = DataProviderType.File;
        public DataProviderParameters Parameters = new DataProviderParameters();
        public string Name = "";
        public List<string> Instruments = new List<string>();

        public DataProvider Create()
        {
            DataProvider result = null;

            switch ( Type )
            {
                case DataProviderType.File:
                    {
                        result = new FileDataProvider();
                        result.Instruments = Instruments;
                        foreach (string key in Parameters.Keys)
                        {
                            result.SetParameter(key, Parameters[key].ToString());
                        }

                        return result;
                    }
                case DataProviderType.MT4:
                    {
                        result = new MT4DataProvider();
                        result.Instruments = Instruments;
                        foreach (string key in Parameters.Keys)
                        {
                            result.SetParameter(key, Parameters[key].ToString());
                        }

                        return result;
                    }
            }

            return null;
        }
    }
}
