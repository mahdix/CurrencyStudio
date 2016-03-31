using System;
using System.Collections.Generic;
using System.Text;
using CurrencyStudio.Core.Trade;
using CurrencyStudio.Core.Helper;
using CurrencyStudio.Core.Market;
using CurrencyStudio.Core.RuntimeSystem.Interface;

namespace CurrencyStudio.Core.Helper.RuntimeTemplates
{
    public class MyExpertPredicate: IExpertPredicate
    {
        #region IExpertPredicate Members

        public string Name
        {
            get { return "Epred"; }
        }

        public void Activate()
        {
            throw new NotImplementedException();
        }

        public void Deactivate()
        {
            throw new NotImplementedException();
        }

        public PositionType Process(SignalOutputSet signalOutputs, ExpertInput expertInput, MarketWatch market, Instrument instrument, TimeFrame timeFrame)
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
