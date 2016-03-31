using System;
using System.Xml.Serialization;
using System.Xml;
using System.Collections.Generic;
using System.Text;
using CurrencyStudio.Core.Market;
using CurrencyStudio.Core.Trade;

namespace CurrencyStudio.Core.RuntimeSystem
{
    public static class Serializers
    {
        public static void Init()
        {
            RuntimeManagerSerializer = new XmlSerializer(typeof(RuntimeManager));
            MarketProviderManagerSerializer = new XmlSerializer(typeof(MarketProviderManager));
            AccountManagerSerializer = new XmlSerializer(typeof(AccountManager));
        }

        public static XmlSerializer RuntimeManagerSerializer = null;
        public static XmlSerializer MarketProviderManagerSerializer = null;
        public static XmlSerializer AccountManagerSerializer = null;

    }
}
