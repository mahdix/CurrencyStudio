using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;
using CurrencyStudio.Core.Trade;
using CurrencyStudio.Core.Market;
using CurrencyStudio.Core.Helper;
using CurrencyStudio.Core.Market.Data;


namespace CurrencyStudio.Core.UI
{
    public class Logger
    {
        private static Logger instance = new Logger();
        public static Logger GetInstance()
        {
            return instance;
        }

        protected Logger()
        {
        }

        public Form statForm = null;
        private ListBox logList = null;

        public ListBox LogListBox
        {
            get
            {
                return logList;
            }
            set
            {
                logList = value;
                logList.DisplayMember = "Message";
                logList.DoubleClick += new EventHandler(logList_DoubleClick);
            }
        }

        private ListView positionList = null;

        public ListView PositionList
        {
            get
            {
                return positionList;
            }
            set
            {
                positionList = value;
            }
        }

        void logList_DoubleClick(object sender, EventArgs e)
        {
            Position p = (logList.SelectedItem as LogEntry).LogPosition;

            if (p == null) return;

            string msg = "Type: {0}\nSize: {1}\nInstrument: {2}\nOpen Price: {3}";
            msg = string.Format(msg, Utils.GetPositionType(p.PositionType), p.Size, p.Instrument.Name, p.OpenPrice);

            MessageBox.Show(msg);
            
        }

        public void RefreshStats()
        {
            if (statForm == null) return;

            if (statForm.InvokeRequired)
            {
                statForm.Invoke(new MethodInvoker(RefreshStats));
                return;
            }
            Account a = AccountManager.GetInstance().DefaultAccount;

            if (a == null) return;            

            Label initialDeposit = GetStatLabel("lblInitialDeposit");
            Label lblTotalProfit = GetStatLabel("lblTotalProfit");
            Label equity = GetStatLabel("lblEquity");
            Label totalPositionSize = GetStatLabel("lblTotalPositionsSize");
            Label lblMaxProfit = GetStatLabel("lblMaxProfit");
            Label lblMaxLoss = GetStatLabel("lblMaxLoss");
            Label lossInfo = GetStatLabel("lblLossInfo");
            Label profitInfo = GetStatLabel("lblProfitInfo");
            Label openPositionCount = GetStatLabel("lblOpenPositionCount");
            Label closedPositionCount = GetStatLabel("lblPositionCountClosed");
            Label openProfit = GetStatLabel("lblOpenProfit");

            double totalSize = 0;
            int totalClosed = 0;
            double maxProfit = 0;
            double maxLoss = 0;
            double totalProfit = 0;
            double totalLoss = 0;
            int totalInProfit = 0;
            int totalInLoss = 0;
            double openP = 0;

            if (a == null)
            {
                return;
            }

            foreach (Position p in a.Positions)
            {
                if (p.IsClosed)
                {
                    totalClosed++;
                }
                else
                {
                    openP += p.GetCurrentProfit();
                }

                totalSize += p.Size;

                double pl = p.GetCurrentProfit();

                if (pl >= 0)
                {
                    totalProfit += pl;
                    maxProfit = Math.Max(maxProfit, pl);
                    totalInProfit++;
                }
                else
                {
                    totalLoss += Math.Abs(pl);
                    maxLoss = Math.Max(maxLoss, Math.Abs(pl));
                    totalInLoss++;
                }
            }

            initialDeposit.Text = a.AccountInfo.InitialDeposit.ToString();
            lblTotalProfit.Text = Str(totalProfit - totalLoss);
            equity.Text = Str(a.AccountInfo.Equity);
            totalPositionSize.Text = Str(totalSize);
            lblMaxProfit.Text = Str(maxProfit);
            lblMaxLoss.Text = Str(maxLoss);
            openPositionCount.Text = Str(a.Positions.Count - totalClosed);
            closedPositionCount.Text = Str(totalClosed);
            openProfit.Text = Str(openP);
            profitInfo.Text = string.Format("{0}/{1}/{2}", Str(totalProfit), Str(totalProfit / a.Positions.Count), Str(maxProfit));
            lossInfo.Text = string.Format("{0}/{1}/{2}", Str(totalLoss), Str(totalLoss/ a.Positions.Count), Str(maxLoss));

            if (MarketProviderManager.GetInstance().DefaultMarketProvider != null)
            {
                GetStatLabel("lblCurrentTime").Text = MarketProviderManager.GetInstance().DefaultMarketProvider.MarketWatch.CurrentTime.ToString("yyyy.MM.dd HH:mm");
            }
            GetStatLabel("lblTWR").Text = Str(100 * a.AccountInfo.Equity / a.AccountInfo.InitialDeposit,0)+"%";
        }

        private Label GetStatLabel(string key)
        {
            return statForm.Controls.Find(key, true)[0] as Label;
        }

        private string Str(double d)
        {
            return Str(d, 2);
        }

        private string Str(double d,int digits)
        {
            return Math.Round(d, digits).ToString();
        }

        public void Reset()
        {
            if (LogListBox != null)
            {
                LogListBox.Items.Clear();
            }

            if (PositionList != null)
            {
                positionList.Items.Clear();
            }
        }


        private LogEntry logEntry = null;

        public void Log()
        {
            logList.Items.Add(logEntry);

            logList.SetSelected(logList.Items.Count - 1, true);
        }

        public void Log(string s,Position p)
        {
            if (logList != null)
            {
                logEntry = new LogEntry();
                logEntry.Message = s;
                logEntry.LogPosition = p;

                if (logList.InvokeRequired)
                {
                    logList.Invoke(new MethodInvoker(Log));
                }
                else
                {
                    Log();
                }
            }
        }

        public void RefreshPosition(Position p)
        {
            if (positionList == null) return;

            int positionIndex = AccountManager.GetInstance().DefaultAccount.Positions.IndexOf(p);
            ListViewItem lvi = null;

            if (positionIndex < PositionList.Items.Count)
            {
                //update existing position
                lvi = PositionList.Items[positionIndex];

                UpdateListViewItem(lvi, p, positionIndex);
            }
            else
            {
                //position is new
                lvi = new ListViewItem();

                UpdateListViewItem(lvi, p, positionIndex);

                PositionList.Items.Add(lvi);

                PositionList.EnsureVisible(PositionList.Items.Count - 1);
                PositionList.Update();
            }
        }

        private void UpdateListViewItem(ListViewItem lvi, Position p, int index)
        {
            lvi.SubItems.Clear();

            lvi.Text = index.ToString();
            lvi.SubItems.Add(Utils.DateString(p.Time));
            lvi.SubItems.Add(Utils.GetPositionType(p.PositionType));
            lvi.SubItems.Add(Utils.Str(p.Size, 2));
            lvi.SubItems.Add(p.Instrument.Name);
            lvi.SubItems.Add(Utils.Str(p.StopLoss, 5));
            lvi.SubItems.Add(Utils.Str(p.TakeProfit, 5));
            lvi.SubItems.Add(Utils.Str(p.GetCurrentProfit(),2));
            lvi.SubItems.Add(p.ProfitPips.ToString());

            lvi.SubItems.Add(p.IsClosed ? "Y" : "N");

            if (p.IsClosed)
            {
                lvi.SubItems.Add(Utils.DateString(p.CloseTime));
                lvi.SubItems.Add(Utils.Str(p.ClosePrice, 5));
                lvi.SubItems.Add(Utils.GetCloseReason(p.CloseType));
            }

            if (false == p.IsClosed)
            {
                lvi.BackColor = Color.Yellow;
            }
            else if (p.ProfitPips >= 0)
            {
                lvi.BackColor = Color.LightGreen;
            }
            else if (p.ProfitPips < 0)
            {
                lvi.BackColor = Color.OrangeRed;
            }
        }


    }
}
