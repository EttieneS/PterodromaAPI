using Microsoft.EntityFrameworkCore;

namespace ASGExchangeAPI.Models
{
    public class ASGContext : DbContext
    {
        public ASGContext(DbContextOptions<ASGContext> options)
            : base(options) { }

        public DbSet<Currency> Currency { get; set; }
        public DbSet<Selection> Selection { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-21KV94U\\SQLEXPRESS;Database=ASGSolutions;Trusted_Connection=True;");
        }
    }
}
