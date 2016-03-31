using System;
using System.Collections.Generic;
using System.Text;
using CurrencyStudio.Core.Helper;
using System.Xml.Serialization;
using CurrencyStudio.Core.RuntimeSystem.Interface;
using CurrencyStudio.Core.Market;
using CurrencyStudio.Core.Trade;
using System.IO;

namespace CurrencyStudio.Core.RuntimeSystem
{
    public class PortfolioManager
    {
        //public string Name = "";
        public bool IsInline = true;
        public string CodeParameter = "";
        public double RiskRewardRatio = 0;
        public PortfolioManagerInput PortfolioManagerInput = new PortfolioManagerInput();

        [XmlIgnore]
        public string Name
        {
            get
            {
                return InternalObject.Name;
            }
        }
        
        [XmlIgnore]
        private string CacheId
        {
            get
            {
                return "PortfolioManager : " + CodeParameter.GetHashCode().ToString();
            }
        }

        public IPortfilioManager InternalObject
        {
            get
            {
                RuntimeResult result = RuntimeHelper.GetObjectInstance(CacheId,
                    CodeParameter,Def.PortfolioManagerLibFolder,  IsInline ,typeof(IPortfilioManager), RuntimeManager.GetInstance().CommonLibraries);

                if (result.Success == false)
                {
                    throw new Exception("Error Creating PortfolioManager: " + result.ErrorMessage);
                }

                IPortfilioManager resObj = result.CreatedObject as IPortfilioManager;
                resObj.Init();
                return resObj;
            }
        }

        public void Reset()
        {
        }

        public PortfolioManager()
        {
        }

        public IPortfilioManager InitInternalObject(Account defAccount)
        {
            IPortfilioManager result = InternalObject;

            result.DefaultAccount = defAccount;
            result.RiskRewardRatio = RiskRewardRatio;

            return result;
        }

        public void Activate()
        {
            foreach (string key in PortfolioManagerInput.Keys)
            {
                object value = PortfolioManagerInput[key];

                InternalObject.PortfolioManagerInput[key] = value;
            }

            InternalObject.Activate();
        }

        public void Deactivate()
        {
            InternalObject.Deactivate();
        }

        public bool TestCompile(out string errorMessage)
        {
            try
            {
                RuntimeResult result = RuntimeHelper.GetObjectInstance(CacheId,
                    CodeParameter, Def.PortfolioManagerLibFolder, IsInline, typeof(IPortfilioManager), RuntimeManager.GetInstance().CommonLibraries);

                if (result.Success == false)
                {
                    errorMessage = result.ErrorMessage;
                    return false;
                }

                IPortfilioManager testObject = result.CreatedObject as IPortfilioManager;
            }
            catch (Exception exc)
            {
                errorMessage = exc.Message;
                return false;
            }

            errorMessage = "";
            return true;
        }
    }
}
