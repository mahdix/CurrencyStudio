using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyStudio.Core.Trade.Descriptor
{
    [Serializable]
    public class AccountDescriptor
    {
        public string Name = "";
        public double MaxOpenPositionSize = 3;  //max total open position size
        public double MaxOpenPositionCountLimitation = 2500;  //max # of open positions
        public int InitialDeposit = 100;
        public int LeverageFactor = 100;
        public int MinStopLossPips = 25;
        public int MinTakeProfitPips = 25;
        public double CallMarginThreshold = 0.2;    //if account equity is below this percent, its call margined
        public double MinimumPositionSize = 0.01;
        public double PositionIncrement = 0.01;

        public Account Create()
        {
            Account result = new Account();

            result.AccountInfo.CallMarginThreshold = CallMarginThreshold;
            result.AccountInfo.InitialDeposit = InitialDeposit;
            result.AccountInfo.MaxOpenPositionCountLimitation = MaxOpenPositionCountLimitation;
            result.AccountInfo.LeverageFactor = LeverageFactor;
            result.AccountInfo.MaxOpenPositionSize = MaxOpenPositionSize;
            result.AccountInfo.MinStopLossPips = MinStopLossPips;
            result.AccountInfo.MinTakeProfitPips = MinTakeProfitPips;
            result.AccountInfo.PositionSizeIncrement = PositionIncrement;
            result.AccountInfo.MinimumPositionSize = MinimumPositionSize;
            
            return result;
        }
    }
}
