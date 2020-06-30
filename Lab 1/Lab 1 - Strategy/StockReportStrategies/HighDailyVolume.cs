namespace StockReportStrategies
{
    public partial class HighDailyVolume : IFilterStrategy
    {
        bool IFilterStrategy.Include(TradingDay day)
        {
            double volume = day.Volume;

            if (volume > day.DailyVolumeCap)
                return true;
            return false;
        }
    }

    public partial class HighDailyVolume : IGoogleFilterStrategy
    {
        bool IGoogleFilterStrategy.Include(GoogleTradingDay day)
        {
            double volume = day.Volume;

            if (volume > day.DailyVolumeCap)
                return true;
            return false;
        }
    }
}
