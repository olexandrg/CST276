namespace StockReportStrategies
{
    public interface IFilterStrategy
    {
        bool Include(TradingDay day, double swingFactor = 0);
    }
}
