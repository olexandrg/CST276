﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockReportStrategies
{
    public class TradingDay
    {
        public TradingDay(DateTime date, double open, double high, double low, double close, double volume)
        {
            Date = date;
            Open = open;
            High = high;
            Low = low;
            Close = close;
            Volume = volume;
        }

        public override string ToString()
        {
            return String.Format("{0}, Open:{1}, High:{2}, Low:{3}, Close:{4}, Vol:{5}",
                Date.ToShortDateString(), Open, High, Low, Close, Volume);
        }

        private DateTime date;
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        private double open;
        public double Open
        {
            get { return open; }
            set { open = value; }
        }

        private double high;
        public double High
        {
            get { return high; }
            set { high = value; }
        }

        private double low;
        public double Low
        {
            get { return low; }
            set { low = value; }
        }

        private double close;
        public double Close
        {
            get { return close; }
            set { close = value; }
        }

        private double volume;
        public double Volume
        {
            get { return volume; }
            set { volume = value; }
        }
    }
}
