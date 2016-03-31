using System;
using System.Collections.Generic;
using System.Text;
using CurrencyStudio.Core.RuntimeSystem;
using CurrencyStudio.Core.Market;
using CurrencyStudio.Core.Trade;
using CurrencyStudio.Core.Helper;

namespace CurrencyStudio.Core.RuntimeSystem.Interface
{
    public interface IPortfilioManager
    {
        string Name { get; }
        PortfolioManagerInput PortfolioManagerInput { get; }
        double RiskRewardRatio { get; set; }
        Account DefaultAccount { get; set; }
        void Init();

        void Activate();
        void Deactivate();

        bool OpenPosition(Instrument instrument, PositionType type);
    }
}
