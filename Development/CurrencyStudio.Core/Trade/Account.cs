using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using CurrencyStudio.Core.Market;
using CurrencyStudio.Core.Helper;
using CurrencyStudio.Core.UI;

namespace CurrencyStudio.Core.Trade
{
    public class Account
    {
        internal Account()
        {
        }

        public List<Position> Positions = new List<Position>();
        public AccountInfo AccountInfo = new AccountInfo();

        public int TotalPositionCount
        {
            get
            {
                return Positions.Count;
            }
        }

        public bool CanOpenPosition(Instrument instrument, PositionType type, double size, int slPoints, int tpPoints)
        {
            if (slPoints < AccountInfo.MinStopLossPips)
            {
                return false;
            }

            if (tpPoints < AccountInfo.MinTakeProfitPips)
            {
                return false;
            }

            if (Positions.Count >= AccountInfo.MaxOpenPositionCountLimitation)
            {
                return false;
            }

            if (size < AccountInfo.MinimumPositionSize)
            {
                return false;
            }

            double extraSize = size - AccountInfo.MinimumPositionSize;
            if (Math.Round(Math.IEEERemainder(extraSize,AccountInfo.PositionSizeIncrement)) != 0 )
            {
                return false;
            }

            double totalSize = 0;
            foreach (Position p in Positions) totalSize += p.Size;
            if (totalSize+size > AccountInfo.MaxOpenPositionSize)
            {
                return false;
            }

            return AccountInfo.HasEnoughMoneyForPosition(size, instrument);
        }

        public Position OpenPosition(Instrument instrument, PositionType type, double size, int slPoints,int tpPoints)
        {
            if (false == CanOpenPosition(instrument, type, size, slPoints, tpPoints))
            {
                throw new Exception("Can not open position");
            }

            Position pos = new Position(instrument, type, size, instrument.CurrentTime);

            if (type == PositionType.Long)
            {
                pos.OpenPrice = instrument.TickAsk;
                if (slPoints != 0)
                {
                    pos.StopLoss = pos.OpenPrice - (slPoints * instrument.Point);
                }
                if (tpPoints != 0)
                {
                    pos.TakeProfit = pos.OpenPrice + (tpPoints * instrument.Point);
                }

            }
            else if ( type == PositionType.Short )
            {
                pos.OpenPrice = instrument.TickBid;
                if (slPoints != 0)
                {
                    pos.StopLoss = pos.OpenPrice + (slPoints * instrument.Point);
                }
                if (tpPoints != 0)
                {
                    pos.TakeProfit = pos.OpenPrice - (tpPoints * instrument.Point);
                }
            }
            Positions.Add(pos);

            //TEMP pos.Instrument.PriceDiagram.AddPositionSymbol(pos.Instrument.CurrentQuoteIndex, pos.OpenPrice, pos.PositionType, false);

            Logger.GetInstance().Log("Position " + pos.GetInfo() + " Opened",pos);
            Logger.GetInstance().RefreshPosition(pos);
            return pos;
        }

        private void InternalClosePosition(Position p,PositionCloseType type)
        {
            p.IsClosed = true;
            p.CloseType = type;
            p.CloseTime = p.Instrument.CurrentTime;

            if (p.PositionType == PositionType.Long)
            {
                p.ClosePrice = p.Instrument.TickBid;
            }
            else
            {
                p.ClosePrice = p.Instrument.TickAsk;
            }

            p.UpdateProfitPips();
            //TEMP p.Instrument.PriceDiagram.AddPositionSymbol(p.Instrument.CurrentQuoteIndex, p.ClosePrice, p.PositionType, true);

            AccountInfo.ClosedProfit += p.GetCurrentProfit();

            Logger.GetInstance().Log("Position "+p.GetInfo()+" Closed at Price = " + p.ClosePrice+" due to "+Utils.GetCloseReason(type),p);
            Logger.GetInstance().RefreshPosition(p);
        }

        public void ClosePosition(int ticket)
        {
            Position pos = null;

            foreach (Position p in Positions)
            {
                if (!p.IsClosed && p.TicketNumber == ticket)
                {
                    pos = p;
                }
            }
            if ( pos == null || pos.Instrument.CurrentTime == DateTime.MinValue )
            {
                throw new Exception("Invalida Position or Quote for Position Close");
            }

            //Candle closeQuote = pos.Instrument.CurrentQuote;

            //if (false == Utils.IsBetween(pos.Instrument.CurrentTickPrice, closeQuote.Low, closeQuote.High))
            //{
            //    throw new Exception("Invalida Quote Low/High for Position Close");
            //}

            InternalClosePosition(pos, PositionCloseType.Rule);
        }

        public void ProcessPositions()
        {
            //double price = MarketWatch.GetInstance().ActiveInstrument.CurrentTickPrice;
            //DateTime time = MarketWatch.GetInstance().ActiveInstrument.CurrentTime;

            //runtime profit is set to zero and is updated for each non-closed position
            AccountInfo.CurrentProfit = 0;
            AccountInfo.CurrentLoss = 0;

            foreach (Position p in Positions)
            {
                if (p.IsClosed) continue;

                //update SL if position has a trailing stop
                p.UpdatePosition();

                if (p.StopLossHitTest() )
                {
                    //close by stoploss
                    InternalClosePosition(p,PositionCloseType.StopLoss);
                }
                else if ( p.TakeProfitHitTest() )
                {
                    //close by stoploss
                    InternalClosePosition(p, PositionCloseType.TakeProfit);
                }
                else
                {
                    double pl = p.GetCurrentProfit();

                    if (pl >= 0)
                    {
                        AccountInfo.CurrentProfit += pl;
                    }
                    else
                    {
                        AccountInfo.CurrentLoss += Math.Abs(pl);
                    }
                }
            }

            //check for margin-call close
            if (AccountInfo.Equity < (AccountInfo.CallMarginThreshold * AccountInfo.InitialDeposit))
            {
                Logger.GetInstance().Log("CALL MARGIN",null);
                throw new Exception("Call Margin");
            }
        }

        public void Reset()
        {
            Positions.Clear();
            AccountInfo.ClosedProfit = 0;
            AccountInfo.CurrentProfit = 0;
            AccountInfo.CurrentLoss = 0;
        }

       
    }
}
