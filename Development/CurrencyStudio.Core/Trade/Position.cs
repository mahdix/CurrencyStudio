using System;
using System.Collections.Generic;
using System.Text;
using CurrencyStudio.Core.Helper;
using CurrencyStudio.Core.Market;

namespace CurrencyStudio.Core.Trade
{
    public class Position
    {
        public Position(Instrument ins,PositionType type, double size, DateTime time)
        {
            PositionType = type;
            Time = time;
            Size = size;
            Instrument = ins;
        }

        public int TicketNumber = 0;
        public PositionType PositionType = PositionType.Long;
        public Instrument Instrument = null;
        public DateTime Time = DateTime.MinValue;
        public double Size = 0;
        public double StopLoss = 0;
        public double TakeProfit = 0;
        public double OpenPrice = 0;
        public int TrailingStopPoints = 0;

        public bool IsClosed = false;
        public double ClosePrice = 0;
        public DateTime CloseTime = DateTime.MinValue;
        public PositionCloseType CloseType = PositionCloseType.StopLoss;
        public int ProfitPips = 0;      //current proft/loss pip count

        public void UpdateProfitPips()
        {
            double price = VirtualClosePrice;

            if (PositionType == PositionType.Long)
            {
                ProfitPips = Utils.CountPips(price - OpenPrice, Instrument.Point);
            }
            else if (PositionType == PositionType.Short)
            {
                ProfitPips = Utils.CountPips(OpenPrice - price, Instrument.Point);
            }
        }


        /// <summary>
        /// IF we close the position right now, what is the price with which this will be done?
        /// </summary>
        public double VirtualClosePrice
        {
            get
            {
                if (PositionType == PositionType.Long)
                {
                    return Instrument.TickBid;
                }

                else if (PositionType == PositionType.Short)
                {
                    return Instrument.TickBid;
                }

                return 0;

            }
        }

        //if we have trailing stop
        public void UpdatePosition()
        {
            if ( IsClosed )
            {
                throw new Exception("Cannot update stoploss for a closed position");
            }

            //if profit of the position is more than trailing stop the update stop loss
            UpdateProfitPips();

            if (TrailingStopPoints != 0)
            {
                if (ProfitPips >= TrailingStopPoints)
                {
                    StopLoss = VirtualClosePrice - TrailingStopPoints * Instrument.Point;
                }                    
            }
        }

        public double GetCurrentProfit()
        {
            return ProfitPips * Size * Instrument.Point * Instrument.ContractSize;
        }

        internal string GetInfo()
        {
            string type = "LONG";

            if (PositionType == PositionType.Short)
            {
                type = "SHORT";
            }

            return type+"("+Instrument.Name+"@"+Utils.Str(OpenPrice)+")";
        }

        public bool StopLossHitTest()
        {
            double price = VirtualClosePrice;

            if (StopLoss == 0) return false;

            if (PositionType == PositionType.Long)
            {
                return (StopLoss >= price);
            }
            else if (PositionType == PositionType.Short)
            {
                return (StopLoss <= price);
            }

            return false;
        }

        public bool TakeProfitHitTest()
        {
            double price = VirtualClosePrice;

            if (TakeProfit == 0) return false;

            if (PositionType == PositionType.Long)
            {
                return (TakeProfit <= price);
            }
            else if (PositionType == PositionType.Short)
            {
                return (TakeProfit >= price);
            }

            return false;
        }

    }
}
