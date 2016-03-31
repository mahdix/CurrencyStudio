using System;
using System.Collections.Generic;
using System.Text;
using CurrencyStudio.Core.RuntimeSystem.Interface;
using CurrencyStudio.Core.RuntimeSystem;

namespace CurrencyStudio.Core.Helper
{
    public class ExpertHelper
    {
        public IExpertPredicate GetExpertPredicate(string name)
        {
            foreach (ExpertPredicate ep in RuntimeManager.GetInstance().DefaultExpert.ExpertPredicates)
            {
                if (ep.Name == name)
                {
                    return ep.InternalObject;
                }
            }

            return null;
        }

        public ISignal GetSignal(string name)
        {
            foreach (SignalInstance si in RuntimeManager.GetInstance().DefaultExpert.SignalInstances)
            {
                if (si.Name == name)
                {
                    return si.InternalObject;
                }
            }

            return null;
        }
    }
}
