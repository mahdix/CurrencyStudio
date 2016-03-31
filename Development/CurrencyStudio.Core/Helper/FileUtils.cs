using System;
using System.IO;
using System.Runtime;
using System.Reflection;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using CurrencyStudio.Core.Market.Data;
using CurrencyStudio.Core.Market;


namespace CurrencyStudio.Core.Helper
{
    public class FileUtils
    {
        /// <summary>
        /// base is keyDic but values are stored in valueDic and should not be removed
        /// unless keyDic does not have them
        /// </summary>
        /// <param name="keyDic"></param>
        /// <param name="valueDic"></param>
        public static void SyncDictionaries(Dictionary<string, object> keyDic, Dictionary<string, object> valueDic)
        {
            List<string> toBeRemovedFromValues = new List<string>();

            foreach (string key in valueDic.Keys)
            {
                if (keyDic.ContainsKey(key) == false) toBeRemovedFromValues.Add(key);
            }

            foreach (string key in toBeRemovedFromValues)
            {
                valueDic.Remove(key);
            }

            foreach (string key in keyDic.Keys)
            {
                if (false == valueDic.ContainsKey(key))
                {
                    valueDic.Add(key, keyDic[key]);
                }
            }
        }

        public static string AskAssemblyFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Assembly Files (*.dll)|*.dll";

            if (ofd.ShowDialog() == DialogResult.Cancel) return null;

            return ofd.FileName;
        }

        public static string AppFolder
        {
            get
            {
                string fxSimPath = Assembly.GetExecutingAssembly().CodeBase;
                UriBuilder uri = new UriBuilder(fxSimPath);
                string path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
        }

        public static string SignalLibFolder
        {
            get
            {
                return Path.Combine(AppFolder, Def.SignalDefinitionLibFolder);
            }
        }

        public static string PortfolioManagerLibFolder
        {
            get
            {
                return Path.Combine(AppFolder, Def.PortfolioManagerLibFolder);
            }
        }


        public static string ExpertLibFolder
        {
            get
            {
                return Path.Combine(AppFolder, Def.ExpertLibFolder);
            }
        }

        public static string ExpertPredicateLibFolder
        {
            get
            {
                return Path.Combine(AppFolder, Def.ExpertPredicateLibFolder);
            }
        }

        public static int CountLines(string filePath)
        {
            int count = 0;
            string line;
            TextReader reader = new StreamReader(filePath);
            while ((line = reader.ReadLine()) != null)
            {
                count++;
            }
            reader.Close();

            return count;
        }


    }
}
