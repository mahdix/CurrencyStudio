using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyStudio.Core.Market
{
    public class Tick
    {
        public DateTime Time = DateTime.MinValue;
        public double Ask = 0.0;
        public double Bid = 0.0;
        public string Instrument = null;

        public Tick()
        {
        }

        public Tick(DateTime t, double bid, double ask,string inst)
        {
            Time = t;
            Bid = bid;
            Ask = ask;
            Instrument = inst;
        }
    }
}
