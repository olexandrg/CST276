using System;

namespace StockReportStrategies
{
    public class HighDailySwing: IFilterStrategy
    {
        bool IFilterStrategy.Include(TradingDay day)
        {
            double swing = day.Open - day.Close;
            double percentageSwing = Math.Abs(swing / day.Open);

            if (percentageSwing > 0.1)
                return true;
            return false;
        }
    }
}
