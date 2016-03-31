using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using CurrencyStudio.Core.Market;
using CurrencyStudio.Core.Helper;
using System.Windows.Forms;

namespace CurrencyStudio.Core.Market.Data
{
    public class FileDataProvider: DataProvider
    {
        public FileDataProvider()
        {
            isOffline = true;
        }

        private StreamReader sr = null;
        private DataProviderParameters parameters = new DataProviderParameters();

        private Candle currentCandle = null;

        private int currentDataFileIndex = 0;
        private int maxDataFileIndex = 0;

        private string fileInstrment
        {
            get
            {
                return parameters["Instrument"].ToString();
            }
        }

        private string filesPath
        {
            get
            {
                return parameters["File(s) Path"].ToString();
            }
        }

        public int TotalLineCount = 0;
        public int CurrentLineNumber = 0;

        //temp - shows which price to set as tick O then H then L then C (4 steps)
        private int currentCandleStep = -1;

        //when checking for startTime we have to read the first candle to 
        //get sure we have reached to that point, 
        //that single candle is stored here to be used later
        private Candle tempCandle = null;

        public override void SimulateTicks(int steps)
        {
            Tick t = GetNextTick();

            if (t == null) return;

            if (MarketWatch != null)
            {
                MarketWatch.Tick(t.Instrument, t.Time, t.Bid, t.Ask);
            }
        }

        public override Tick GetNextTick()
        {
            if (currentCandle == null)
            {
                currentCandle = GetNextCandle();
                currentCandleStep = -1;
            }
            //maybe end of data
            if (currentCandle == null)
            {
                return null;
            }

            currentCandleStep++;

            if (currentCandleStep >= 4)
            {
                currentCandleStep = 0;
                currentCandle = GetNextCandle();

                if (currentCandle == null)
                {
                    return null;
                }
            }

            double price = 0;
            if (currentCandleStep == 0) price = currentCandle.Open;
            if (currentCandleStep == 1) price = currentCandle.High;
            if (currentCandleStep == 2) price = currentCandle.Low;
            if (currentCandleStep == 3) price = currentCandle.Close;

            if (endDateTime.Equals(DateTime.MinValue) || currentCandle.Time <= endDateTime)
            {
                //normally we read spread (bid and ask)from file, 
                //if not, instrument has to add default spread in this case we pass zero
                return new Tick(currentCandle.Time, price, 0,fileInstrment);
            }

            return null;
        }

        public override void Activate()
        {
            CreateStream();

            currentDataFileIndex = 0;
            maxDataFileIndex = filesPath.Split(';').Length - 1;

            if (startDateTime != null)
            {
                Candle c = GetNextCandle();

                while (c.Time < startDateTime ) c = GetNextCandle();

                tempCandle = c;
            }
        }


        public override void Deactivate()
        {
            sr.Close();
        }

        public override Candle GetNextCandle()
        {
            if (tempCandle != null)
            {
                Candle temp = tempCandle;
                tempCandle = null;
                return temp;
            }

            Candle result = new Candle();

            if (sr.EndOfStream)
            {
                if (currentDataFileIndex < maxDataFileIndex)
                {
                    //pass empty files if any
                    do
                    {
                        currentDataFileIndex++;
                        CreateStream();
                    } while (sr.EndOfStream);
                }
                else
                {
                    return null;
                }
            }

            string line = sr.ReadLine();

            string[] parts = line.Split(parameters["Delimiter"].ToString()[0]);

            Candle q = new Candle();

            q.Time = DateTime.Parse(GetItem(parameters["Date Indices"].ToString().Split(','), parts));
            q.Volume = int.Parse(GetItem(parameters["Volume Indices"].ToString().Split(','), parts));
            q.Open = double.Parse(GetItem(parameters["Open Indices"].ToString().Split(','), parts));
            q.Close = double.Parse(GetItem(parameters["Close Indices"].ToString().Split(','), parts));
            q.Low = double.Parse(GetItem(parameters["Low Indices"].ToString().Split(','), parts));
            q.High = double.Parse(GetItem(parameters["High Indices"].ToString().Split(','), parts));

            return q;
        }

        private void CreateStream()
        {
            string fileName = filesPath.Split(';')[currentDataFileIndex];

            sr = new StreamReader(fileName);
        }

        public override bool IsFinished
        {
            get
            {
                return sr.EndOfStream || 
                    (endDateTime != DateTime.MinValue && currentCandle != null && 
                        currentCandle.Time > endDateTime);
            }
        }

        private string GetItem(string[] indices, string[] parts)
        {
            string result = "";

            if (indices == null || indices.Length == 0) return "0";

            for (int i = 0; i < indices.Length; i++)
            {
                result += parts[int.Parse(indices[i])];

                if (i < indices.Length - 1) result += " ";
            }

            return result;
        }

        

        public override void SetParameter(string key, string value)
        {
            parameters.Add(key, value);
        }

        private static void InitParams(DataProviderParameters parameters)
        {
            parameters.Add("File(s) Path", "");
            parameters.Add("Instrument", "");
            parameters.Add("Delimiter", ",");
            parameters.Add("Date Indices", "0");
            parameters.Add("Volume Indices", "1");
            parameters.Add("Open Indices", "2");
            parameters.Add("Close Indices", "3");
            parameters.Add("Low Indices", "4");
            parameters.Add("High Indices", "5");
        }

        public new static void LoadParametersToGUI(DataProviderParameters parameters, TableLayoutPanel gui)
        {
            if (parameters.Count == 0)
            {
                InitParams(parameters);
            }

            gui.Controls.Clear();

            int row = 0;
            foreach (string key in parameters.Keys)
            {
                AddLabel(key + ":", row, 0, gui);
                AddTextBox(key.Replace(" ", "_"), parameters[key].ToString(), row++, 1, gui);
            }            
        }

        private static void AddLabel(string text,int r,int c,TableLayoutPanel gui)
        {
            Label lbl = new Label();
            lbl.Text = text;

            gui.Controls.Add(lbl, c,r);
        }

        private static void AddTextBox(string id,string text, int r, int c, TableLayoutPanel gui)
        {
            TextBox txt = new TextBox();
            txt.Name = id;
            txt.Text = text;
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.Dock = DockStyle.Fill;

            gui.Controls.Add(txt, c,r);
        }

        public new static void ReadParametersFromGUI(DataProviderParameters parameters, TableLayoutPanel gui)
        {
            if (parameters.Count == 0)
            {
                InitParams(parameters);
            }

            Dictionary<string,string> newValues = new Dictionary<string,string>();
            
            foreach(string key in parameters.Keys)
            {
                TextBox txt = gui.Controls.Find(key.Replace(" ", "_"), true)[0] as TextBox;

                newValues[key] = txt.Text;
            }

            foreach (string key in newValues.Keys)
            {
                parameters[key] = newValues[key];
            }
        }
    }
}
