using System;
using System.Collections.Generic;
using System.Text;
using CurrencyStudio.Core.Trade;
using CurrencyStudio.Core.Helper;
using CurrencyStudio.Core.Market;
using CurrencyStudio.Core.RuntimeSystem.Interface;

namespace CurrencyStudio.Core.Helper.RuntimeTemplates
{
    public class PortfolioManagerTemplate: IPortfilioManager
    {
        private PortfolioManagerInput portfolioManagerInput = null;
        private double riskRewardRation = 0;
        private Account defaultAccount = null;


        public string Name
        {
            get
            {
                return "defaultPM";
            }
        }


        #region IPortfilioManager Members


        public PortfolioManagerInput PortfolioManagerInput
        {
            get { return portfolioManagerInput; }
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

        public Account DefaultAccount
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

        public void Activate()
        {
            throw new NotImplementedException();
        }

        public void Deactivate()
        {
            throw new NotImplementedException();
        }

        public bool OpenPosition(Instrument instrument, PositionType type)
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
