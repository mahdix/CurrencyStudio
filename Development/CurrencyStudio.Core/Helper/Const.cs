using System;
using System.Collections.Generic;
using System.Text;
using ZedGraph;
using CurrencyStudio.Core.Market;

namespace CurrencyStudio.Core.Helper
{
    public delegate void OnTickHandler(Tick tick);

    public enum PositionType
    {
        Long,
        Short,
        Neutral
    }


    public enum DataProviderType
    {
        File,
        MT4
    }

    public enum PositionOpenResult
    {
        Done,
        NotEnoughtMoney,
        InvalidSL,
        InvalidTP          //SL TP pips less than min
    }

    public enum PositionCloseType
    {
        Rule,
        StopLoss,
        TakeProfit,
        MarginCall
    }

    public enum TimeFrameType
    {
        M1 = 1,
        M5 = 5,
        M15 = 15,
        M30 = 30,
        H1 = 60,
        H4 = 240,
        D1 = 1440,
        W1 = 1080,
        MN = 302400
    }

    public delegate void UpdateGraph(StockPt pt);

}
