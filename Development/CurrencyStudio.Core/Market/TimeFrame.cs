using System;
using System.Collections.Generic;
using System.Text;
using CurrencyStudio.Core.Helper;
using System.Runtime.Remoting.Messaging;

namespace CurrencyStudio.Core.Market
{
    public class TimeFrame
    {
        private AsyncCallback onTickFinishedCallback = null;

        //this tick event shows candle ticks - means that time of the tick parameter is in timeframe mode
        //e.g. a tick on 12:37:11 for a 5M TF will raise an event with a tick of 12:35:00 
        public event OnTickHandler OnTickEvent;
        public List<Candle> Candles = new List<Candle>();
        public int Period = 1;  //number of minutes of each candle

        //last time we have received a tick
        private DateTime latestTime = DateTime.MinValue;
        
        //stored for speedup
        private Candle latestCandle = null;

        //latest slot number of the received tick (in whole time)
        //for example for M5 10:01 and 10:02 have the same quote and 10:05 has slot of 10:02 plus one
        private int latestSlotNumber = -1;

        public TimeFrame(int period)
        {
            this.Period = period;onTickFinishedCallback = new AsyncCallback(OnTickDone);
        }

        private void OnTickDone(IAsyncResult result)
        {
            if (result.IsCompleted)
            {
                ((result as AsyncResult).AsyncDelegate as OnTickHandler).EndInvoke(result);
            }
        }

        //public UI.PriceChart PriceDiagram = null;

        /// <summary>
        /// 0 means current active candle, 1 mens previous candle and ...
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Candle this[int index]
        {
            get
            {
                return Candles[Candles.Count - 1 - index];
            }
        }

        public Candle CurrentCandle
        {
            get
            {
                return latestCandle;                
            }
        }

        //slot means timeframes of length = period
        //ticks in the same slot are aggregated in a single quote
        private int GetTimeSlotNumber(DateTime dt)
        {
            return (int)(new TimeSpan(dt.Ticks).TotalMinutes / Period);
        }


        private DateTime SlotNumberToCandleStartTime(int slotNumber)
        {
            return new DateTime(new TimeSpan(0, slotNumber * Period, 0).Ticks);
        }

        internal void FeedTick(Tick tick)
        {
            int minuteDifference = (int)latestTime.Subtract(tick.Time).TotalMinutes;

            if (minuteDifference > Period)
            {
                //some time has passed and we have not received a tick related to our timeframe
                //add some dummy candles here
                int missedPeriods = minuteDifference / Period;

                for (int i = 1; i <= missedPeriods; i++)
                {
                    Candle dummyCandle = new Candle();

                    dummyCandle.Time = latestTime.AddMinutes(Period * i);

                    Candles.Add(dummyCandle);
                }
            }

            int tickSlotNumber = GetTimeSlotNumber(tick.Time);

            //do we have to add a new candle?
            if (tickSlotNumber == latestSlotNumber)
            {
                Candle q = Candles[Candles.Count - 1];

                q.Close = tick.Bid;
                q.High = Math.Max(q.Close, q.High);
                q.Low = Math.Min(q.Close, q.Low);
            }
            else
            {
                latestSlotNumber = tickSlotNumber;
                
                //by default we store bid prices in candles
                Candle q = new Candle(tick.Bid);
                q.Time = SlotNumberToCandleStartTime(tickSlotNumber);
                latestCandle = q;
                Candles.Add(q);
            }

            latestTime = tick.Time;

            if (OnTickEvent != null)
            {
                DateTime tickTFTime = Candles[Candles.Count - 1].Time;

                Tick tfTick = new Tick(tickTFTime, tick.Bid, tick.Ask, tick.Instrument);

                OnTickEvent.BeginInvoke(tfTick,onTickFinishedCallback,null);
            }
        }
    }
}
