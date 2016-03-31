using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;
using CurrencyStudio.Core.Helper;
using CurrencyStudio.Core.Market;
using System.Runtime.Remoting.Messaging;

namespace CurrencyStudio.Core.Market.Data
{
    public abstract class DataProvider
    {
        //in addition to calling marketWatch.Tick with every new tick, this is another method
        //dp can inform other code about new tick
        //this is a real tick-by-tick event which is called with time of each tick
        //used with live data providers
        public event OnTickHandler OnTickEvent;
        private AsyncCallback onTickFinishedCallback = null;
        protected bool isOffline = true;

        public bool IsOffline
        {
            get
            {
                return isOffline;
            }
        }

        public DataProvider()
        {
            onTickFinishedCallback = new AsyncCallback(OnTickDone);
        }

        private void OnTickDone(IAsyncResult result)
        {
            if (result.IsCompleted)
            {
                ((result as AsyncResult).AsyncDelegate as OnTickHandler).EndInvoke(result);
            }
        }

        protected void FireTickEvent(Tick t)
        {
            if (OnTickEvent != null)
            {
                OnTickEvent.BeginInvoke(t, onTickFinishedCallback,null);
            }
        }

        public DateTime startDateTime = DateTime.MinValue;
        public DateTime endDateTime = DateTime.MinValue;
        public List<string> Instruments = new List<string>();

        //this is set so DP know who sould it inform when a new tick is arrived
        public MarketWatch MarketWatch = null;

        #region Offline Data Provider Methods
        //implemented in child classes
        //generate ticks from offline store and inform market
        public virtual void SimulateTicks(int steps)
        {
            //read data and inform the market
        }

        public virtual Candle GetNextCandle()
        {
            return null;
        }

        public virtual Tick GetNextTick()
        {
            return null;
        }
        #endregion

        public abstract bool IsFinished { get; }

        //initialize DP - for live DP start listening
        public abstract void Activate();

        //uninitialize DP - for live DP stop listening
        public abstract void Deactivate();

        public abstract void SetParameter(string key, string value);

        public static void LoadParametersToGUI(DataProviderParameters parameters, TableLayoutPanel gui)
        {
            throw new Exception("Method Not Implemented");
        }

        public static void ReadParametersFromGUI(DataProviderParameters parameters, TableLayoutPanel gui)
        {
            throw new Exception("Method Not Implemented");
        }

        public static void LoadParametersToGUI(DataProviderType type,DataProviderParameters parameters, TableLayoutPanel gui)
        {
            if (type == DataProviderType.File)
            {
                FileDataProvider.LoadParametersToGUI(parameters, gui);
            }
            else if (type == DataProviderType.MT4)
            {
                MT4DataProvider.LoadParametersToGUI(parameters, gui);
            }
        }

        public static void ReadParametersFromGUI(DataProviderType type, DataProviderParameters parameters, TableLayoutPanel gui)
        {
            if (type == DataProviderType.File)
            {
                FileDataProvider.ReadParametersFromGUI(parameters, gui);
            }
            else if (type == DataProviderType.MT4)
            {
                MT4DataProvider.ReadParametersFromGUI(parameters, gui);
            }
        }
    }
}
