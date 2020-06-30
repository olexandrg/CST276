using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockReportStrategies;

namespace StrategyLabStarterCode
{
    class Program
    {
        // report days with high daily swing
        private static void ReportTradingDays(StockMarket tradingDays)
        {
            Console.WriteLine("\n" + "High Swing Days: " + "\n");

            foreach (TradingDay day in tradingDays.GetTradingDays())
            {
                IFilterStrategy tradingDay = new HighDailySwing();

                if (tradingDay.Include(day))
                    Console.WriteLine(day.ToString());
            }
        }

        // overloaded definition to parse GOOG swing data
        private static void ReportTradingDays(GoogleStockMarket tradingDays)
        {
            Console.WriteLine("\n" + "High Swing Days: " + "\n");

            foreach (GoogleTradingDay day in tradingDays.GetGoogleTradingDays())
            {
                IGoogleFilterStrategy tradingDay = new HighDailySwing();

                if (tradingDay.Include(day))
                    Console.WriteLine(day.ToString());
            }
        }

        // report days with high trading volume
        private static void ReportHighVolumeDays(StockMarket tradingDays)
        {
            Console.WriteLine("\n" + "High Volume Days: " + "\n");

            foreach (TradingDay day in tradingDays.GetTradingDays())
            {
                IFilterStrategy tradingDay = new HighDailyVolume();

                if (tradingDay.Include(day))
                    Console.WriteLine(day.ToString());
            }
        }

        // overloaded definition to parse GOOG volume data
        private static void ReportHighVolumeDays(GoogleStockMarket tradingDays)
        {
            Console.WriteLine("\n" + "High Volume Days: " + "\n");

            foreach (GoogleTradingDay day in tradingDays.GetGoogleTradingDays())
            {
                IGoogleFilterStrategy tradingDay = new HighDailyVolume();

                if (tradingDay.Include(day))
                    Console.WriteLine(day.ToString());
            }
        }
        static void Main(string[] args)
        {
            StockMarket tradingDays = new StockMarket(@"..\..\stockData.csv",0.1,20000000);
            GoogleStockMarket googleDays = new GoogleStockMarket(@"..\..\GOOG.csv", 0.01, 2000000);

            ReportTradingDays(tradingDays);
            ReportHighVolumeDays(tradingDays);

            ReportTradingDays(googleDays);
            ReportHighVolumeDays(googleDays);

            //Prevent the console window from closing during debugging. 
            Console.ReadLine();
        }        
    }
}
