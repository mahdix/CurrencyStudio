using System;
using System.Collections.Generic;
using System.Text;
using CurrencyStudio.Core.Market;

namespace CurrencyStudio.Core.Trade
{
    public class AccountInfo
    {
        //public double MinLotIncrement = 0.01;

        public double MaxOpenPositionSize = 3;  //max total open position size
        public double MaxOpenPositionCountLimitation = 2500;  //max # of open positions

        public int InitialDeposit = 100;
        public int LeverageFactor = 100;
        public int MinStopLossPips = 25;
        public int MinTakeProfitPips = 25;
        public double CallMarginThreshold = 0.2;    //if account equity is below this percent, its call margined
        public double MinimumPositionSize = 0.01;
        public double PositionSizeIncrement = 0.01;

        public double ClosedProfit = 0; //total profit/loss of closed positions
        public double CurrentProfit = 0;    //profit in amount of cash
        public double CurrentLoss = 0;    //profit in amount of cash

        public double Equity
        {
            get
            {
                double result = InitialDeposit;
                result += ClosedProfit;
                result += CurrentProfit;
                result -= CurrentLoss;

                return result;
            }
        }


      
        public double MinimumEquity
        {
            get
            {
                return CallMarginThreshold * InitialDeposit;
            }
        }

        public double GetPositionMargin(Position p)
        {
            return GetPositionMargin(p.Size, p.Instrument);
        }

        public double GetPositionMargin(double size,Instrument instrument)
        {
            return size * instrument.ContractSize / LeverageFactor;
        }

        public bool HasEnoughMoneyForPosition(double size, Instrument instrument)
        {
            double freeMargin = Equity - GetPositionMargin(size, instrument);

            if (freeMargin < (CallMarginThreshold * InitialDeposit))
            {
                return false;
            }

            return true;
        }
    }
}
