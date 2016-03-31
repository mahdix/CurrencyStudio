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
    public class ExpertPredicate
    {
        //public string Name = "";
        public string CodeParameter = "";
        public List<string> Instruments = new List<string>();
        public string TimeFrame = "";
        public bool IsInline = true;

        public void Reset()
        {
        }

        [XmlIgnore]
        public string CacheId
        {
            get
            {
                return "ExpertPredicate : " + CodeParameter.GetHashCode().ToString();
            }
        }

        [XmlIgnore]
        public string Name
        {
            get
            {
                return InternalObject.Name;
            }
        }

        public IExpertPredicate InternalObject
        {
            get
            {
                RuntimeResult result = RuntimeHelper.GetObjectInstance(CacheId,
                    CodeParameter, Def.ExpertPredicateLibFolder,IsInline, typeof(IExpertPredicate),
                    RuntimeManager.GetInstance().CommonLibraries);

                if (result.Success == false)
                {
                    throw new Exception("Error Executing Predicate: " + result.ErrorMessage);
                }

                IExpertPredicate resObj = result.CreatedObject as IExpertPredicate;
                resObj.Init();
                return resObj;
            }
        }

        public ExpertPredicate()
        {
        }

        //can this predicate handle the given instrument?
        public bool IsMatch(string inst)
        {
            return Utils.IsInstrumentMatch(this.Instruments, inst);
        }

        public PositionType Execute(SignalOutputSet signalOutputs,ExpertInput expertInput, 
            Instrument inst,MarketWatch market)
        {
            if (false == IsMatch(inst.Name)) return PositionType.Neutral;

            return InternalObject.Process(signalOutputs, expertInput,
                market, inst, Utils.GetTimeFrame(inst,TimeFrame));
        }

        public bool TestCompile(out string errorMessage)
        {
            try
            {
                RuntimeResult result = RuntimeHelper.GetObjectInstance(CacheId,
                        CodeParameter, Def.ExpertPredicateLibFolder, IsInline, typeof(IExpertPredicate), 
                        RuntimeManager.GetInstance().CommonLibraries);

                if (result.Success == false)
                {
                    errorMessage = result.ErrorMessage;
                    return false;
                }

                IExpertPredicate testObject = result.CreatedObject as IExpertPredicate;
            }
            catch (Exception exc)
            {
                errorMessage = exc.Message;
                return false;
            }

            errorMessage = "";
            return true;
        }


        internal void Deactivate()
        {
            InternalObject.Deactivate();
        }

        internal void Activate()
        {
            InternalObject.Activate();
        }
    }
}
