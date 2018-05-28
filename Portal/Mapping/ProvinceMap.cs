using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Portal.Entities;

namespace Portal.Mapping
{
    public class ProvinceMap : EntityTypeConfiguration<Province>
    {
        public ProvinceMap()
        {
            // Primary Key
            this.HasKey(t => t.ProvinceID);

            // Properties
            this.Property(t => t.ProvinceNo)
                .HasMaxLength(10);

            this.Property(t => t.ProvinceName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Province");
            this.Property(t => t.ProvinceID).HasColumnName("ProvinceID");
            this.Property(t => t.ProvinceNo).HasColumnName("ProvinceNo");
            this.Property(t => t.ProvinceName).HasColumnName("ProvinceName");
        }
    }
}
