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
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=StoreDB;");
        }
    }
}
