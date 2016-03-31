using System;
using System.Collections.Generic;
using System.Text;
using CurrencyStudio.Core.Trade;
using CurrencyStudio.Core.Helper;
using CurrencyStudio.Core.Market;
using CurrencyStudio.Core.RuntimeSystem.Interface;

namespace CurrencyStudio.Core.Helper.RuntimeTemplates
{
    public class MyExpert: IExpert
    {

        #region IExpert Members

        public string Name
        {
            get
            {
                return "Expert";
            }
        }

        private ExpertInput ep = new ExpertInput();

        public MyExpert()
        {
            ep.Add("AA", "5");
        }


        public ExpertInput ExpertInput
        {
            get { return ep; }
        }

        public void Process(RuleOutputSet ruleOutputs, SignalOutputSet signalOutputs, Instrument instrument, MarketWatch market)
        {
            throw new NotImplementedException();
        }

        public void Activate(IPortfilioManager portfolioManager)
        {
            throw new NotImplementedException();
        }

        public void Deactivate()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IExpert Members


        public void Init()
        {
        }

        #endregion
    }
}
