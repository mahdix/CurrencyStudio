using System;
using System.Collections.Generic;
using System.Text;
using CurrencyStudio.Core.Market;
using CurrencyStudio.Core.Trade;

namespace CurrencyStudio.Core.Helper
{
    public class LogEntry
    {
        private string message = "";
        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
            }
        }

        public Position LogPosition = null;
    }
}
