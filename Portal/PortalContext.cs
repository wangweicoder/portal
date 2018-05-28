using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

using Portal.Entities;
using Portal.Mapping;

namespace Portal
{
    public class PortalContext : DbContext
    {
        static PortalContext()
        {
            Database.SetInitializer<PortalContext>(null);
        }

        public DbSet<Province> Provinces { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProvinceMap());
            modelBuilder.Configurations.Add(new CityMap());
            modelBuilder.Configurations.Add(new CategoryMap());
        }
    }
}
