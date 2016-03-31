using System;
using System.Collections.Generic;
using System.Text;

namespace TestExpert
{
    public class Class1: FXSimulator.Core.RuntimeSystem.Interface.IExpert
    {
        #region IExpert Members

        public string Name
        {
            get
            {
                return "WOWDX";
            }
        }

        public Class1()
        {
            int h = new Lib1.Class1().getX();
            inp.Add("TEST"+h.ToString(), "12");
        }

        private FXSimulator.Core.Helper.ExpertInput inp = new FXSimulator.Core.Helper.ExpertInput();

        public FXSimulator.Core.Helper.ExpertInput ExpertInput
        {
            get
            {
                return inp;
            }
        }

        public void Process(FXSimulator.Core.Helper.RuleOutputSet ruleOutputs, FXSimulator.Core.Helper.SignalOutputSet signalOutputs, FXSimulator.Core.Market.Instrument instrument, FXSimulator.Core.Market.MarketWatch market)
        {
            throw new NotImplementedException();
        }

        public void Activate(FXSimulator.Core.RuntimeSystem.Interface.IPortfilioManager portfolioManager)
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
