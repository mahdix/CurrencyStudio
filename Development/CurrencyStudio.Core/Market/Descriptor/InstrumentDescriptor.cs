using System;
using System.Collections;
using System.Xml;
using System.Collections.Generic;
using System.Text;
using CurrencyStudio.Core.Helper;

namespace CurrencyStudio.Core.Market.Descriptor
{
    [Serializable]
    public class InstrumentDescriptor
    {
        public string Name = "";
        public double Point = 0.0001;
        public int ContractSize = 100000;
        public int DefaultSpreadPoints = 10;
        public List<int> TimeFrames = new List<int>();

        public Instrument Create()
        {
            Instrument result = new Instrument();

            result.Name = Name;
            result.Point = Point;
            result.ContractSize = ContractSize;
            result.SpreadPoints = DefaultSpreadPoints;
            foreach (int tf in TimeFrames)
            {
                result.TimeFrames.Add(new TimeFrame(tf));
            }

            return result;
        }
    }
}
