using System;
using System.Collections.Generic;
using System.Text;
using CurrencyStudio.Core.Helper;
using System.Xml.Serialization;
using CurrencyStudio.Core.RuntimeSystem.Interface;
using CurrencyStudio.Core.Market;
using System.IO;

namespace CurrencyStudio.Core.RuntimeSystem
{
    [Serializable]
    public class SignalDefinition
    {
        //for assembly signals - name is read - only
        [XmlIgnore]
        public string Name
        {
            get
            {
                return InternalObject.SignalName;
            }
        }

        public ISignal InternalObject
        {
            get
            {
                RuntimeResult result = CreateNewInstance(CacheId);

                
                Assert.IsTrue(result.Success);

                return result.CreatedObject as ISignal;
            }
        }

        /// <summary>
        /// signal instances can use this method to create their own SI
        /// </summary>
        /// <param name="cacheKey"></param>
        /// <returns></returns>
        public RuntimeResult CreateNewInstance(string cacheKey)
        {
            RuntimeResult result = RuntimeHelper.GetObjectInstance(cacheKey, CodeParameter, Def.SignalDefinitionLibFolder,
                    IsInline, typeof(ISignal), RuntimeManager.GetInstance().CommonLibraries);

            if (result.CreatedObject != null)
            {
                (result.CreatedObject as ISignal).Init();
            }

            return result;
        }

        //public List<string> InputParameters = new List<string>();
        
        /// <summary>
        /// some inline code or an assembly name
        /// </summary>
        public string CodeParameter = "";
        public string GroupId = "";
        public bool IsInline = false;

        public SignalDefinition()
        {
        }

        [XmlIgnore]
        private string CacheId
        {
            get
            {
                return "Signal : " + CodeParameter.GetHashCode().ToString();
            }
        }

        public bool TestCompile(out string errorMessage)
        {
            try
            {
                Assert.IsTrue(IsInline == true);

                RuntimeResult result = RuntimeHelper.GetObjectInstance(CacheId,
                    CodeParameter,Def.SignalDefinitionLibFolder,IsInline, typeof(ISignal), 
                    RuntimeManager.GetInstance().CommonLibraries);

                if (result.Success == false)
                {
                    errorMessage = result.ErrorMessage;
                    return false;
                }

                ISignal testObject = result.CreatedObject as ISignal;
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
