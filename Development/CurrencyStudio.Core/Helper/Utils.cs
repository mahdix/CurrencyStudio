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
    public delegate object FindObjectDelegate(string key);

    public class Utils
    {
        public static bool IsBetween(double value, double min, double max)
        {
            return (value <= max && value >= min);
        }

        public static int CountPips(double val, double pipSize)
        {
            return (int)Math.Round(val / pipSize);
        }

        public static string Str(double d)
        {
            return Str(d, 5);
        }

        public static string Str(double d,int digits)
        {
            return Math.Round(d, digits).ToString();
        }

        internal static string GetPositionType(PositionType t)
        {
            switch (t)
            {
                case PositionType.Long: { return "Long"; }
                case PositionType.Short: { return "Short"; }
                default: { return "?"; }
            }
        }

        public static string DateString(DateTime dt)
        {
            return dt.ToString("yyyy.MM.dd HH:mm");
        }

        internal static string GetCloseReason(PositionCloseType type)
        {
            switch (type)
            {
                case PositionCloseType.MarginCall: { return "Margin Call"; }
                case PositionCloseType.Rule: { return "Rule"; }
                case PositionCloseType.StopLoss: { return "StopLoss"; }
                case PositionCloseType.TakeProfit: { return "TakeProfit"; }
                default: { return "?"; }
            }
        }

        internal static string LoadResource(string name)
        {
            Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name);

            return new StreamReader(stream).ReadToEnd();
        }

        internal static object RuntimeCreateObject(Type interfaceType, Assembly assembly)
        {
            if (assembly == null) return null;

            foreach (Type t in assembly.GetTypes())
            {
                if (interfaceType.IsAssignableFrom(t))
                {
                    return assembly.CreateInstance(t.FullName);
                }
            }

            return null;
        }

        public static void DelimitedStringToList(string data, List<string> result)
        {
            result.Clear();

            foreach (string item in data.Split(','))
            {
                result.Add(item);
            }
        }

        public static TimeFrame GetTimeFrame(Instrument inst, string tfName)
        {
            int index = 0;
            foreach (string name in Enum.GetNames(typeof(TimeFrameType)))
            {
                if (name == tfName)
                {
                    TimeFrameType tftype = (TimeFrameType)Enum.GetValues(typeof(TimeFrameType)).GetValue(index);

                    return inst[tftype];
                }

                index++;
            }

            return null;
        }

        public static string ListToDelimitedString(List<string> list)
        {
            string result = "";

            for(int i=0;i<list.Count;i++)
            {
                result += list[i];

                if (i < list.Count - 1)
                {
                    result += ",";
                }
            }

            return result;
        }

        

        public static string FindUniqueName(FindObjectDelegate finderMethod, string prefix)
        {
            int counter = 0;
            string name = prefix;

            while (finderMethod(name + counter.ToString()) != null) counter++;

            return name + counter.ToString();

        }

        public static bool IsInstrumentMatch(List<string> configInstruments, string currentInstrument)
        {
            foreach (string instrument in configInstruments)
            {
                if (instrument == currentInstrument) return true;

                //start means all possible instruments
                if (instrument == "*") return true;

                int idx = instrument.IndexOf("*");

                if (idx == -1) continue;

                int idx2 = currentInstrument.IndexOf("*");

                if (idx2 == -1) continue;

                //*USD for example
                if (idx == 0 && idx2 == 0)
                {
                    if (instrument.Substring(1) == currentInstrument.Substring(1))
                    {
                        return true;
                    }
                }

                //if EUR* 
                if (idx == instrument.Length - 1 && idx2 == currentInstrument.Length - 1)
                {
                    if (instrument.Substring(1, instrument.Length - 1) == currentInstrument.Substring(1, currentInstrument.Length - 1))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
