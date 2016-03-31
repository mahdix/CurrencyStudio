using System;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using CurrencyStudio.Core.Helper;
using CurrencyStudio.Core.UI;
using System.Runtime.Remoting.Messaging;


namespace CurrencyStudio.Core.Market
{
    public class Instrument
    {
        // private int currentTickIndex = -1;
        private List<Tick> Ticks = new List<Tick>();

        //default spread points
        public int SpreadPoints = 10;

        public string Name = "";
        public List<TimeFrame> TimeFrames = new List<TimeFrame>();
        public double Point = 0.00001;
        public int ContractSize = 100000;

        public TimeFrame this[int period]
        {
            get
            {
                foreach (TimeFrame tf in TimeFrames)
                {
                    if (tf.Period == period)
                    {
                        return tf;
                    }
                }

                return null;
            }
        }

        public TimeFrame this[TimeFrameType period]
        {
            get
            {
                return this[(int)period];
            }
        }

     
        //stored for speedup
        public DateTime CurrentTime = DateTime.MinValue;

        //stored for speedup
        public double TickAsk = 0.0;

        //stored for speedup
        public double TickBid = 0.0;

        public Tick GetTick(int relativeIndex)
        {
            return Ticks[Ticks.Count - 1 - relativeIndex];
        }

        //method is called by market watch
        //returns the newly added tick (this is also avilable via this[0]
        public Tick Tick(DateTime tickTime, double tickBid, double tickAsk)
        {
            //if tickAsk is not available add default spread
            Tick t = new Tick(tickTime,tickBid,tickAsk,this.Name);
            Ticks.Add(t);

            //store data in local vars too for speedup
            TickAsk = tickAsk;
            TickBid = tickBid;
            CurrentTime = tickTime;

            foreach (TimeFrame tf in TimeFrames)
            {
                tf.FeedTick(t);
            }

            return t;
        }

        public TimeFrame FindtimeFrame(TimeFrameType tft)
        {
            foreach (TimeFrame tf in TimeFrames)
            {
                if (tf.Period == (int)tft)
                {
                    return tf;
                }
            }

            return null;
        }



    }
}
