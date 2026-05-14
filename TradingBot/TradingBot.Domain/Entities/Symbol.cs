namespace TradingBot.Domain.Entities;

public class Symbol : BaseEntity
{
    public int ExchangeId { get; set; }
    public Exchange Exchange { get; set; }

    public string BaseAsset { get; set; }
    public string QuoteAsset { get; set; }

    public string SymbolCode { get; set; } // BTCUSDT

    public ICollection<Candle> Candles { get; set; }
}