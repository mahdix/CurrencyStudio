using System;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using CurrencyStudio.Core.Helper;
using System.Runtime.Remoting.Messaging;


namespace CurrencyStudio.Core.Market
{
    public class MarketWatch
    {
        public MarketWatch()
        {
            onTickFinishedCallback = new AsyncCallback(OnTickDone);
        }

        public List<Instrument> Instruments = new List<Instrument>();
        
        //this is a real tick-by-tick event which is called with time of each tick
        public event OnTickHandler OnTick;

        public DateTime CurrentTime = DateTime.MinValue;

        private AsyncCallback onTickFinishedCallback = null;

        private void OnTickDone(IAsyncResult result)
        {
            if (result.IsCompleted)
            {
                ((result as AsyncResult).AsyncDelegate as OnTickHandler).EndInvoke(result);
            }
        }


        public Instrument this[string name]
        {
            get
            {
                foreach(Instrument inst in Instruments )
                {
                    if (inst.Name == name) return inst;

                }

                return null;
            }
        }

        /// <summary>
        /// this method is called by a data provider that has read a price data
        /// </summary>
        /// <param name="instrument"></param>
        /// <param name="tickTime"></param>
        /// <param name="tickBid"></param>
        /// <param name="tickAsk"></param>
        internal void Tick(string instrument, DateTime tickTime, double tickBid, double tickAsk)
        {
            //with a marketprovider of 3 data providers, this will be called 3 times

            Instrument inst = this[instrument];

            //market does not support this instrument
            if (inst == null) return;

            CurrentTime = tickTime;

            Tick ticj = this[instrument].Tick(tickTime, tickBid, tickAsk);

            if (OnTick != null)
            {
                //running this event handler may take a long time
                OnTick.BeginInvoke(ticj, onTickFinishedCallback,null);
            }
        }

        public Instrument FindInstrument(string name)
        {
            foreach (Instrument inst in Instruments)
            {
                if (inst.Name == name )
                {
                    return inst;
                }
            }

            return null;
        }
    }
}
