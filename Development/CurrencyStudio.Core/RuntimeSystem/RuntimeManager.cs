using System;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Text;
using CurrencyStudio.Core.Market;
using CurrencyStudio.Core.Market.Data;
using CurrencyStudio.Core.Helper;

namespace CurrencyStudio.Core.RuntimeSystem
{
    [Serializable]
    public class RuntimeManager
    {
        private static RuntimeManager instance = null;

        public static bool HasInstance()
        {
            return (instance != null);
        }

        public static RuntimeManager GetInstance()
        {
            if (instance == null)
            {
                instance = Load();
            }

            return instance;
        }
        public static void Reload()
        {
            instance = Load();
        }

        public List<Expert> Experts = new List<Expert>();
        public List<SignalDefinition> SignalDefinitions = new List<SignalDefinition>();
        public List<PortfolioManager> PortfolioManagers = new List<PortfolioManager>();
        public SignalGroup RootSignalGroup = new SignalGroup(Def.RootSignalGroupId);
        public List<string> CommonLibraries = new List<string>();

        public string DefaultPortfolioManagerName = "";
        public string DefaultExpertName = "";

        [XmlIgnore]
        public Expert DefaultExpert
        {
            get
            {
                return FindExpert(DefaultExpertName);
            }
        }

        [XmlIgnore]
        public PortfolioManager DefaultPortfolioManager
        {
            get
            {
                return FindPortfolioManager(DefaultPortfolioManagerName);
            }
        }

        public PortfolioManager FindPortfolioManager(string name)
        {
            foreach (PortfolioManager pm in PortfolioManagers)
            {
                if (pm.Name == name)
                {
                    return pm;
                }
            }

            return null;
        }

        
        public static void Reset()
        {
            foreach (Expert e in instance.Experts) e.Reset();

            foreach (PortfolioManager pm in instance.PortfolioManagers) pm.Reset();
        }

        private static RuntimeManager Load()
        {
            string filePath = CurrencyStudio.Core.Helper.Def.RuntimeManagerFileName;

            FileStream fs = new FileStream(filePath, FileMode.Open);
            RuntimeManager  result = Serializers.RuntimeManagerSerializer.Deserialize(fs) as RuntimeManager;
            fs.Close();

            return result;
        }

        public static void Save()
        {
            string filePath = CurrencyStudio.Core.Helper.Def.RuntimeManagerFileName;
            FileStream fs = new FileStream(filePath,FileMode.Create);

            try
            {
                Serializers.RuntimeManagerSerializer.Serialize(fs, instance);
            }
            catch (Exception exc)
            {
                int g = 12;
            }
            fs.Close();

            //empty code caches as codes may have changed
            Reset();
        }

        public SignalDefinition FindSignalDefinition(string name)
        {
            foreach (SignalDefinition rs in SignalDefinitions)
            {
                if (rs.Name == name) return rs;
            }

            return null;
        }

        public Expert FindExpert(string name)
        {
            foreach (Expert rs in Experts)
            {
                if (rs.Name == name) return rs;
            }

            return null;
        }

        public SignalInstance FindSignalInstance(string definitionName)
        {
            foreach (Expert rst in Experts)
            {
                foreach (SignalInstance si in rst.SignalInstances)
                {
                    if (si.DefinitionName == definitionName)
                    {
                        return si;
                    }
                }
            }

            return null;
        }
    }
}
