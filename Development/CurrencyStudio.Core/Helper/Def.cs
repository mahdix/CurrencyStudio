using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyStudio.Core.Helper
{
    public class Def
    {
        public const string LongOpenPositionSymbol = "/";
        public const string LongClosePositionSymbol = "//";
        public const string ShortOpenPositionSymbol = "\\";
        public const string ShortClosePositionSymbol = "\\\\";

        public const string SignalsNamespace = "CurrencyStudio.Core.Signals";
        public const string RulesNamespace = "CurrencyStudio.Core.Rules";
        public const string SimulationProfileConfigFileName = "SimulationProfile.xml";

        public const string RuntimeManagerFileName = "RepRun.xml";
        public const string MarketProviderManagerFileName = "MPM.xml";
        public const string AccountManagerFileName = "Acc.xml";

        public const string RootSignalGroupId = "Signal Library";

        public const string SignalDefinitionLibFolder = "st";
        public const string PortfolioManagerLibFolder = "pm";
        public const string ExpertPredicateLibFolder = "ep";
        public const string ExpertLibFolder = "ex";

        public const string CommonLibFolder = "lib";

        public const string DefaultSignalOutputKey = "out";  //key in output of a signal which shows default output
    }
}
