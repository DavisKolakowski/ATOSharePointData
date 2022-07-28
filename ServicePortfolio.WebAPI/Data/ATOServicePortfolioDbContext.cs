using Microsoft.EntityFrameworkCore;

using ServicePortfolio.WebAPI.Models;

namespace ServicePortfolio.WebAPI.Data
{
    public class ATOServicePortfolioDbContext : DbContext
    {
        public ATOServicePortfolioDbContext()
        {
        }

        public ATOServicePortfolioDbContext(DbContextOptions<ATOServicePortfolioDbContext> options)
            : base(options)
        {
        }

        public DbSet<Value> Values { get; set; } = null!;

        public DbSet<ContentType> ContentTypes { get; set; } = null!;

        public DbSet<ToolUsed> ToolsUsed { get; set; } = null!;

        public DbSet<SupportedProductL2> SupportedProductL2s { get; set; } = null!;

        public DbSet<User> Users { get; set; } = null!;
    }
}
