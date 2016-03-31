using System;
using System.Collections.Generic;
using System.Text;

namespace TestExpPred
{
    public class Class1: FXSimulator.Core.RuntimeSystem.Interface.IExpertPredicate
    {
        #region IExpertPredicate Members

        public string Name
        {
            get { return "pred12"; }
        }

        public void Activate()
        {
            throw new NotImplementedException();
        }

        public void Deactivate()
        {
            throw new NotImplementedException();
        }

        public FXSimulator.Core.Helper.PositionType Process(FXSimulator.Core.Helper.SignalOutputSet signalOutputs, FXSimulator.Core.Helper.ExpertInput expertInput, FXSimulator.Core.Market.MarketWatch market, FXSimulator.Core.Market.Instrument instrument, FXSimulator.Core.Market.TimeFrame timeFrame)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IExpertPredicate Members


        public void Init()
        {
        }

        #endregion
    }
}
