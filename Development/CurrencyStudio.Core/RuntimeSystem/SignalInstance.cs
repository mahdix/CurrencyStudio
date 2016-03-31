using System;
using System.Collections.Generic;
using System.Text;
using CurrencyStudio.Core.Helper;
using System.Xml.Serialization;
using CurrencyStudio.Core.RuntimeSystem.Interface;
using CurrencyStudio.Core.Market;

namespace CurrencyStudio.Core.RuntimeSystem
{
    [Serializable]
    public class SignalInstance
    {
        public string Name = "";
        public string DefinitionName = "";
        public List<string> Instruments = new List<string>();
        public string TimeFrame = "";
        public SignalInput InputParametersValues = new SignalInput();
        private ISignal internalObject = null;
        

        public void Reset()
        {
            internalObject = null;
        }

        //can this signal handle the given instrument
        public bool IsMatch(string instrument)
        {
            return Utils.IsInstrumentMatch(this.Instruments, instrument);
        }

        public SignalOutput Execute(Tick tick,MarketWatch market)
        {
            if (false == IsMatch(tick.Instrument)) return null;

            return InternalObject.Process(
                market,
                market.FindInstrument(tick.Instrument),
                Utils.GetTimeFrame(market.FindInstrument(tick.Instrument),TimeFrame), 
                tick);
        }

        private string CacheId
        {
            get
            {
                return "SignalInstance : " + this.Name;
            }
        }

        /// <summary>
        /// we migh have multiple signal instances per signal definition
        /// so each si has to create his own internal object
        /// </summary>
        public ISignal InternalObject
        {
            get
            {
                if (internalObject == null)
                {
                    SignalDefinition definition = RuntimeManager.GetInstance().FindSignalDefinition(DefinitionName);
                    RuntimeResult result = definition.CreateNewInstance(CacheId);

                    if (result.Success == false)
                    {
                        throw new Exception("Error Executing Signal: " + result.ErrorMessage);
                    }

                    internalObject = result.CreatedObject as ISignal;
                }

                return internalObject;
            }
        }

        public void Deactivate()
        {
            InternalObject.Deactivate();
        }

        public void Activate()
        {
            foreach (string key in InputParametersValues.Keys)
            {
                object value = InputParametersValues[key];

                InternalObject.SignalInput[key] = value;
            }

            InternalObject.Activate();
        }
    }
}
