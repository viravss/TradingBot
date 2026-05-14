namespace TradingBot.Domain.Entities;

public class Timeframe : BaseEntity
{
    public string Name { get; set; } // 1m, 5m
    public int DurationInSeconds { get; set; }
    public ICollection<Candle> Candles { get; set; }
}