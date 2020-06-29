namespace StockReportStrategies
{
    public interface IFilterStrategy
    {
        bool Include(TradingDay day);
    }
}
