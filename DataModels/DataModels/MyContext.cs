using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace DataModels
{
    public class MyContext : DbContext
    {
        public DbSet<api_endpoint> api_endpoints { get; set; }
        public DbSet<api_configuration> api_configurations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:sql-pricingsolution-dev-000.database.windows.net,1433;Initial Catalog=pricingsolutiondb;Persist Security Info=False;User ID=pricingsolution-admin;Password=Shashi@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
    }
}
