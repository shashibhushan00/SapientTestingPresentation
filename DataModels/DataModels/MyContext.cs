using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace DataModels.Models
{
    public class MyContext : DbContext
    {
        public DbSet<ApiEndpoint> ApiEndpoints { get; set; }
        public DbSet<ApiConfiguration> ApiConfigurations { get; set; }
        public DbSet<MarketQuote> MarketQuotes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserGridView> UserGridViews { get; set; }
        public DbSet<Symbol> Symbols { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:sql-pricingsolution-dev-000.database.windows.net,1433;Initial Catalog=pricingsolutiondb;Persist Security Info=False;User ID=pricingsolution-admin;Password=Shashi@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
    }
}
