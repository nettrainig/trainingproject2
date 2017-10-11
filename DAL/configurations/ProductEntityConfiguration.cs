using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using DAL.logic;

namespace DAL.configurations
{
    class ProductEntityConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductEntityConfiguration()
        {
            this.ToTable("Products");

            this.HasKey<int>(c => c.ID);

            this.Property(p => p.Code).HasColumnName("Code");
            this.Property(p => p.Name).HasColumnName("Name");
            this.Property(p => p.Price).HasColumnName("Price");
            this.Property(p => p.WarehouseID).HasColumnName("WarehouseID");
        }
    }
}
