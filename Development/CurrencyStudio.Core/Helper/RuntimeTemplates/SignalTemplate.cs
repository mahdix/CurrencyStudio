using System;
using System.Collections.Generic;
using System.Text;
using CurrencyStudio.Core.Trade;
using CurrencyStudio.Core.Helper;
using CurrencyStudio.Core.Market;
using CurrencyStudio.Core.RuntimeSystem.Interface;

namespace CurrencyStudio.Core.Helper.RuntimeTemplates
{
    public class MySignal: ISignal
    {
        public string SignalName
        {
            get
            {
                return "Signal";
            }
        }



        #region ISignal Members


        public SignalInput SignalInput
        {
            get { return new SignalInput(); }
        }

        public void Activate()
        {
            throw new NotImplementedException();
        }

        public void Deactivate()
        {
            throw new NotImplementedException();
        }

        public SignalOutput Process(MarketWatch market, Instrument instrument, TimeFrame timeFrame, Tick tick)
        {
            throw new NotImplementedException();
        }

        public object GetData(object input)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region ISignal Members


        public void Init()
        {
        }

        #endregion
    }
}
