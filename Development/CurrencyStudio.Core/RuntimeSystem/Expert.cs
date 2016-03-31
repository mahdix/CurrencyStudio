using System;
using System.Collections.Generic;
using System.Text;
using CurrencyStudio.Core.Helper;
using System.Xml.Serialization;
using CurrencyStudio.Core.Trade;
using CurrencyStudio.Core.RuntimeSystem.Interface;
using CurrencyStudio.Core.Market;


namespace CurrencyStudio.Core.RuntimeSystem
{
    [Serializable]
    public class Expert
    {
        //public string Name = "";

        public List<SignalInstance> SignalInstances = new List<SignalInstance>();
        public List<ExpertPredicate> ExpertPredicates = new List<ExpertPredicate>();
        public ExpertInput ExpertInput = new ExpertInput();
        public string Comments = "";
        public bool IsInline = false;
        public string CodeParameter = "";

        [XmlIgnore]
        public string Name
        {
            get
            {
                return InternalObject.Name;
            }
        }

        public IExpert InternalObject
        {
            get
            {
                RuntimeResult result = RuntimeHelper.GetObjectInstance(CacheId, CodeParameter,
                    Def.ExpertLibFolder, IsInline, typeof(IExpert), RuntimeManager.GetInstance().CommonLibraries);

                if (result.Success == false)
                {
                    throw new Exception("Error Executing Expert: " + result.ErrorMessage);
                }

                IExpert resObj = result.CreatedObject as IExpert;
                resObj.Init();
                return resObj;
            }
        }

        private string CacheId
        {
            get
            {
                return "Expert : " + this.CodeParameter.GetHashCode().ToString();
            }
        }

        public void Activate(IPortfilioManager portfolioManager)
        {
            foreach (SignalInstance si in SignalInstances) si.Activate();
            foreach (ExpertPredicate ep in ExpertPredicates) ep.Activate();

            foreach (string key in ExpertInput.Keys)
            {
                object value = ExpertInput[key];

                InternalObject.ExpertInput[key] = value;
            }

            InternalObject.Activate(portfolioManager);
        }

        public void Deactivate(RuntimeManager runtimeManager)
        {
            foreach (SignalInstance si in SignalInstances) si.Deactivate();
            foreach (ExpertPredicate ep in ExpertPredicates) ep.Deactivate();

            InternalObject.Deactivate();
        }

        public void Execute(Instrument inst,Tick tick, MarketWatch market)
        {
            SignalOutputSet sigOuts = new SignalOutputSet();
            RuntimeManager manager = RuntimeManager.GetInstance();

            foreach (SignalInstance signal in SignalInstances)
            {
                SignalOutput sigOut = signal.Execute(tick,market);
                sigOuts.Add(signal.Name, sigOut);
            }

            RuleOutputSet ruleOuts = new RuleOutputSet();

            foreach (ExpertPredicate rt in ExpertPredicates)
            {
                PositionType pos = rt.Execute(sigOuts, InternalObject.ExpertInput, inst, market);

                ruleOuts.Add(rt.Name, pos);
            }

            InternalObject.Process(ruleOuts, sigOuts, inst, market);
        }

        public void Reset()
        {
            foreach (SignalInstance si in SignalInstances) si.Reset();
            foreach (ExpertPredicate ep in ExpertPredicates) ep.Reset();
        }

        public Expert()
        {
        }


        public bool TestCompile(out string errorMessage)
        {
            try
            {
                RuntimeResult result = RuntimeHelper.GetObjectInstance(CacheId, CodeParameter,
                         Def.ExpertLibFolder, IsInline, typeof(IExpert), 
                         RuntimeManager.GetInstance().CommonLibraries);

                if (result.Success == false)
                {
                    throw new Exception("Error Executing Expert: " + result.ErrorMessage);
                }

                IExpert testObject = result.CreatedObject as IExpert;
            }
            catch (Exception exc)
            {
                errorMessage = exc.Message;
                return false;
            }

            errorMessage = "";
            return true;
        }

        public SignalInstance FindSignalInstance(string name)
        {
            foreach (SignalInstance rs in SignalInstances)
            {
                if (rs.Name == name) return rs;
            }

            return null;
        }

        public ExpertPredicate FindExpertPredicate(string name)
        {
            foreach (ExpertPredicate rs in ExpertPredicates)
            {
                if (rs.Name == name) return rs;
            }

            return null;
        }
    }
}
