using System;
using System.Collections;
using System.Xml;
using System.Collections.Generic;
using System.Text;
using CurrencyStudio.Core.Helper;

namespace CurrencyStudio.Core.Market.Descriptor
{
    [Serializable]
    public class MarketWatchDescriptor
    {
        //public string Name = "";
        public List<InstrumentDescriptor> Instruments = new List<InstrumentDescriptor>();

        public InstrumentDescriptor FindInstrument(string name)
        {
            foreach (InstrumentDescriptor id in Instruments)
            {
                if (id.Name == name)
                {
                    return id;
                }
            }

            return null;
        }

        public MarketWatch Create()
        {
            MarketWatch result = new MarketWatch();

            foreach (InstrumentDescriptor id in Instruments)
            {
                result.Instruments.Add(id.Create());
            }

            return result;
        }
    }
}
