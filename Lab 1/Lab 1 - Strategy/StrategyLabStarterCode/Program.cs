using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyLabStarterCode
{
    class Program
    {
        private static void ReportTradingDays(StockMarket tradingDays)
        {
            foreach (TradingDay day in tradingDays.GetTradingDays())
            {
                //logic before the "if" inside the "foreach"
                double swing = day.Open - day.Close;
                double percentageSwing = Math.Abs(swing / day.Open);

                if (percentageSwing > 0.1)
                {
                    Console.WriteLine(day.ToString());
                }
            }
        }

        static void Main(string[] args)
        {
            StockMarket tradingDays = new StockMarket(@"..\..\stockData.csv");

            ReportTradingDays(tradingDays);

            //Prevent the console window from closing during debugging. 
            Console.ReadLine();
        }        
    }
}
