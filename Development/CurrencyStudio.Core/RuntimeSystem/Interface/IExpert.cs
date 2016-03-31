using System;
using System.Collections.Generic;
using System.Text;
using CurrencyStudio.Core.RuntimeSystem;
using CurrencyStudio.Core.Market;
using CurrencyStudio.Core.Helper;
using CurrencyStudio.Core.Trade;

namespace CurrencyStudio.Core.RuntimeSystem.Interface
{
    public interface IExpert
    {
        string Name { get; }
        ExpertInput ExpertInput { get; }
        void Init();

        void Process(RuleOutputSet ruleOutputs, SignalOutputSet signalOutputs, 
            Instrument instrument, MarketWatch market);
        void Activate(IPortfilioManager portfolioManager);
        void Deactivate();
    }
}
