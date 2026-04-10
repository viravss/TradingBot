namespace TradingBot.Domain.Entities
{
    public class Candle
    {
        public long Id { get; private set; }

        public string Symbol { get; private set; } // BTCUSDT

        public DateTime OpenTime { get; private set; }

        public decimal Open { get; private set; }
        public decimal High { get; private set; }
        public decimal Low { get; private set; }
        public decimal Close { get; private set; }

        public decimal Volume { get; private set; }
        private Candle() { } // EF

        public Candle(string symbol, DateTime openTime,
            decimal open, decimal high, decimal low, decimal close, decimal volume)
        {
            Symbol = symbol;
            OpenTime = openTime;
            Open = open;
            High = high;
            Low = low;
            Close = close;
            Volume = volume;
        }
    }
}



