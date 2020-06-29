using System;

namespace StockReportStrategies
{
    public partial class HighDailySwing: IFilterStrategy
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

    public partial class HighDailySwing : IGoogleFilterStrategy
    {
        bool IGoogleFilterStrategy.Include(GoogleTradingDay day)
        {
            double swing = day.Open - day.Close;
            double percentageSwing = Math.Abs(swing / day.Open);

            if (percentageSwing > 0.01)
                return true;
            return false;
        }
    }
}
