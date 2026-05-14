namespace TradingBot.Domain.Entities
{
    public class Candle : BaseEntity
    {
        public int SymbolId { get; set; }
        public Symbol? Symbol { get; set; }

        public int TimeframeId { get; set; }
        public Timeframe? Timeframe { get; set; }

        public DateTime OpenTime { get; set; }
        public DateTime CloseTime { get; set; }

        public bool IsClosed { get; set; }

        public decimal Open { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Close { get; set; }

        public decimal Volume { get; set; }

        public int NumberOfTrades { get; set; }
        public decimal QuoteAssetVolume { get; set; }

    }
}



