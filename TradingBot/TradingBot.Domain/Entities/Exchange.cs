namespace TradingBot.Domain.Entities;

public class Exchange : BaseEntity
{
    public string Name { get; set; }
    public ICollection<Symbol> Symbols { get; set; }
}