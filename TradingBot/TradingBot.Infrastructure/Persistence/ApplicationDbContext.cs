using Microsoft.EntityFrameworkCore;
using TradingBot.Domain.Entities;

namespace TradingBot.Infrastructure.Persistence;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Candle> Candles { get; set; }
    public DbSet<Symbol> Symbols { get; set; }
    public DbSet<Exchange> Exchanges { get; set; }
    public DbSet<Timeframe> Timeframes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}