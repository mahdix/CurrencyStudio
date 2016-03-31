using System;
using System.Collections;
using System.Xml;
using System.Collections.Generic;
using System.Text;
using CurrencyStudio.Core.Market;
using CurrencyStudio.Core.Market.Descriptor;
using CurrencyStudio.Core.Trade;
using CurrencyStudio.Core.Helper;
using CurrencyStudio.Core.RuntimeSystem;
using CurrencyStudio.Core.Market.Data;

namespace CurrencyStudio.Core
{
    public class SimEngine
    {
        private RuntimeManager runtime = null;

        public void Initialize()
        {
            Account acc = AccountManager.GetInstance().DefaultAccount;

            if (acc != null)
            {
                acc.Reset();
            }

            RuntimeHelper.ResetObjectCache();

            runtime = RuntimeManager.GetInstance();

            CurrencyStudio.Core.UI.Logger.GetInstance().Reset();
            CurrencyStudio.Core.UI.Logger.GetInstance().RefreshStats();

            MarketProvider mp = MarketProviderManager.GetInstance().DefaultMarketProvider;

            if (mp != null)
            {
                mp.MarketWatch.OnTick += new OnTickHandler(MarketWatch_OnTick);
            }

            if (runtime.DefaultPortfolioManager != null && AccountManager.GetInstance().DefaultAccount != null)
            {
                //TEMP runtime.DefaultExpert.Activate(
                    //runtime.DefaultPortfolioManager.InitInternalObject(AccountManager.GetInstance().DefaultAccount), runtime);
            }
        }

        void MarketWatch_OnTick(Tick tick)
        {
            //TEMP runtime.DefaultExpert.Execute(instrument, tick,                
                //MarketProviderManager.GetInstance().DefaultMarketProvider.MarketWatch,runtime);

            AccountManager.GetInstance().DefaultAccount.ProcessPositions();
            CurrencyStudio.Core.UI.Logger.GetInstance().RefreshStats();
        }

        public void Tick()
        {
            Tick(1);
        }

        public void Tick(int steps)
        {
            MarketProviderManager.GetInstance().DefaultMarketProvider.SimulateTicks(steps);

            if (IsSimulationFinished())
            {
                runtime.DefaultExpert.Deactivate(runtime);
                return;
            }
        }

        public bool IsSimulationFinished()
        {
            return MarketProviderManager.GetInstance().DefaultMarketProvider.DataProviders[0].IsFinished;
        }
    }
}
