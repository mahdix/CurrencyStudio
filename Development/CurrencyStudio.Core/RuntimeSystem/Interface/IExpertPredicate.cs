using System;
using System.Collections.Generic;
using System.Text;
using CurrencyStudio.Core.RuntimeSystem;
using CurrencyStudio.Core.Market;
using CurrencyStudio.Core.Helper;

namespace CurrencyStudio.Core.RuntimeSystem.Interface
{
    public interface IExpertPredicate
    {
        string Name { get; }
        void Activate();
        void Deactivate();
        void Init();

        PositionType Process(SignalOutputSet signalOutputs, ExpertInput expertInput,  
            MarketWatch market,Instrument instrument, TimeFrame timeFrame);
    }
}
