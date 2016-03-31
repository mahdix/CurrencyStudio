using System;
using System.Collections.Generic;
using System.Text;
using CurrencyStudio.Core.RuntimeSystem;
using CurrencyStudio.Core.Market;
using CurrencyStudio.Core.Market.Data;
using CurrencyStudio.Core.Helper;

namespace CurrencyStudio.Core.RuntimeSystem.Interface
{
    public interface ISignal
    {
        string SignalName { get; }
        SignalInput SignalInput { get; }
        void Init();

        void Activate();
        void Deactivate();

        //although code can extract instrument via tick.instrument and market, we give it to signal
        //for ease of signal code
        SignalOutput Process(MarketWatch market, Instrument instrument, 
            TimeFrame timeFrame, Tick tick);

        object GetData(object input);
    }
}
