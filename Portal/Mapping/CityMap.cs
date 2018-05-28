using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Portal.Entities;

namespace Portal.Mapping
{
    public class CityMap : EntityTypeConfiguration<City>
    {
        public CityMap()
        {
            // Primary Key
            this.HasKey(t => t.CityID);

            // Properties
            this.Property(t => t.CityNo)
                .HasMaxLength(10);
            this.Property(t => t.CityName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("City");
            this.Property(t => t.CityID).HasColumnName("CityID");
            this.Property(t => t.CityNo).HasColumnName("CityNo");
            this.Property(t => t.CityName).HasColumnName("CityName");
        }
    }
}
