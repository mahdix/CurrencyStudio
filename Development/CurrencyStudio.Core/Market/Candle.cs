using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyStudio.Core.Market
{
    public class Candle
    {
        //zero means we have no information (no deal is done)
        public double Open = 0.0;
        public double Close = 0.0;
        public double Low = 0.0;
        public double High = 0.0;
        public DateTime Time;
        public int Volume = 0;

        public Candle()
        {
        }

        public Candle(double price)
        {
            Open = Close = Low = High = price;
        }
    }
}
