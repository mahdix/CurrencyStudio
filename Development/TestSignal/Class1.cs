using System;
using System.Collections.Generic;
using System.Text;

namespace TestSignal
{
    public class Class1: FXSimulator.Core.RuntimeSystem.Interface.ISignal
    {
        #region ISignal Members

        public string SignalName
        {
            get
            {
                return "AAADSA";
            }
        }

        public FXSimulator.Core.Helper.SignalInput SignalInput
        {
            get { throw new NotImplementedException(); }
        }

        public void Activate()
        {
            throw new NotImplementedException();
        }

        public void Deactivate()
        {
            throw new NotImplementedException();
        }

        public FXSimulator.Core.Helper.SignalOutput Process(FXSimulator.Core.Helper.SignalInput si, FXSimulator.Core.Market.MarketWatch market, FXSimulator.Core.Market.Instrument instrument, FXSimulator.Core.Market.TimeFrame timeFrame, FXSimulator.Core.Market.Tick tick)
        {
            throw new NotImplementedException();
        }

        public object GetData(object input)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region ISignal Members


        public FXSimulator.Core.Helper.SignalOutput Process(FXSimulator.Core.Market.MarketWatch market, FXSimulator.Core.Market.Instrument instrument, FXSimulator.Core.Market.TimeFrame timeFrame, FXSimulator.Core.Market.Tick tick)
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
