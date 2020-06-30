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
        private static void ReportHighSwingDays(StockMarket tradingDays, double swingFactor = 0.1)
        {
            Console.WriteLine("\n" + "High Swing Days: " + "\n");

            foreach (TradingDay day in tradingDays.GetTradingDays())
            {
                IFilterStrategy tradingDay = new HighDailySwing();

                if (tradingDay.Include(day, swingFactor))
                    Console.WriteLine(day.ToString());
            }
        }

        // report days with high trading volume
        private static void ReportHighVolumeDays(StockMarket tradingDays, double highVolumeCap = 20000000)
        {
            Console.WriteLine("\n" + "High Volume Days: " + "\n");

            foreach (TradingDay day in tradingDays.GetTradingDays())
            {
                IFilterStrategy tradingDay = new HighDailyVolume();

                if (tradingDay.Include(day, highVolumeCap))
                    Console.WriteLine(day.ToString());
            }
        }

        static void Main(string[] args)
        {
            ICSVParser originalParser = new OriginalCSVParser();
            ICSVParser yahooParser = new YahooCSVParser();

            StockMarket tradingDays = new StockMarket(@"..\..\stockData.csv", originalParser);
            StockMarket googleDays = new StockMarket(@"..\..\GOOG.csv", yahooParser);

            ReportHighSwingDays(tradingDays);
            ReportHighVolumeDays(tradingDays);

            ReportHighSwingDays(googleDays, 0.01);
            ReportHighVolumeDays(googleDays, 50000);

            //Prevent the console window from closing during debugging. 
            Console.ReadLine();
        }        
    }
}
