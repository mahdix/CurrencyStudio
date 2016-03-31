using System;
using System.Collections.Generic;
using System.Text;
using CurrencyStudio.Core.Trade.Descriptor;
using System.IO;
using System.Xml.Serialization;
using CurrencyStudio.Core.RuntimeSystem;

namespace CurrencyStudio.Core.Trade
{
    public class AccountManager
    {
        private static AccountManager instance = null;

        public static AccountManager GetInstance()
        {
            if (instance == null)
            {
                instance = Load();
            }

            return instance;
        }

        public List<AccountDescriptor> Accounts = new List<AccountDescriptor>();
        public string DefaultAccountName = "";

        public static AccountManager Load()
        {
            string filePath = CurrencyStudio.Core.Helper.Def.AccountManagerFileName;

            FileStream fs = new FileStream(filePath, FileMode.Open);
            AccountManager result = Serializers.AccountManagerSerializer.Deserialize(fs) as AccountManager;

            fs.Close();
            internalAccount = null;

            return result;
        }

        public static void Reload()
        {
            instance = Load();
        }

        public static void Save()
        {
            string filePath = CurrencyStudio.Core.Helper.Def.AccountManagerFileName;
            FileStream fs = new FileStream(filePath, FileMode.Create);

            try
            {
                Serializers.AccountManagerSerializer.Serialize(fs, instance);
            }
            catch (Exception exc)
            {
                int g = 12;
            }
            fs.Close();
            internalAccount = null;
        }

        private static Account internalAccount = null;
        public Account DefaultAccount
        {
            get
            {
                if (internalAccount == null)
                {
                    AccountDescriptor ad = FindAccountDescriptor(DefaultAccountName);
                    if (ad != null)
                    {
                        internalAccount = ad.Create();
                    }
                }

                return internalAccount;
            }
        }

        public AccountDescriptor FindAccountDescriptor(string name)
        {
            foreach (AccountDescriptor ad in Accounts)
            {
                if (ad.Name == name)
                {
                    return ad;
                }
            }

            return null;
        }
    }
}
