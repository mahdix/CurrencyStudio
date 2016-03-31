using System;
using System.Collections.Generic;
using System.Text;
using FXSimulator.Core.Helper;

namespace TestPM
{
    public class Class1: FXSimulator.Core.RuntimeSystem.Interface.IPortfilioManager
    {
        #region IPortfilioManager Members

        public string Name
        {
            get { return "AAA"; }
        }

        public Class1()
        {
            inp.Add("TERST", "1");
        }

        private PortfolioManagerInput inp = new PortfolioManagerInput();
        public FXSimulator.Core.Helper.PortfolioManagerInput PortfolioManagerInput
        {
            get
            {
                return inp;
            }
        }

        public double RiskRewardRatio
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public FXSimulator.Core.Trade.Account DefaultAccount
        {
            get
            {
                return null;
            }
            set
            {
            }
        }

        public void Activate()
        {
            throw new NotImplementedException();
        }

        public void Deactivate()
        {
            throw new NotImplementedException();
        }

        public bool OpenPosition(FXSimulator.Core.Market.Instrument instrument, FXSimulator.Core.Helper.PositionType type)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IPortfilioManager Members


        public void Init()
        {
        }

        #endregion
    }
}
