namespace StockReportStrategies
{
    public interface IGoogleFilterStrategy
    {
        bool Include(GoogleTradingDay day);
    }
}