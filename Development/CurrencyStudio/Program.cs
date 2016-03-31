using System;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Collections.Generic;
using System.Windows.Forms;
using CurrencyStudio.Core.Market.Descriptor;
using System.IO;

namespace CurrencyStudio
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //CurrencyStudio.Core.RuntimeSystem.RuntimeManager.Save();
            //CurrencyStudio.Core.Market.Design.MarketProviderManager.Save();
            //CurrencyStudio.Core.Market.Design.MarketProviderManager.Load();
            //CurrencyStudio.Core.Trade.AccountManager.Save();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }

    [Serializable]
    public class C1
    {
        public int g = 12;
    }

 
}
