using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.logic;
using System.Data.Entity.ModelConfiguration;

namespace DAL.configurations
{
    class OrerDetailEntityConfiguration : EntityTypeConfiguration<OrderDetail>
    {
        public OrerDetailEntityConfiguration()
        {
            this.ToTable("OrderDetails");

            this.HasKey<int>(c => c.ID);
            //this.HasKey<int>(c => c.OrderID);

            this.Property(p => p.OrderID).HasColumnName("OrderID");
            this.Property(p => p.ProductID).HasColumnName("ProductID");
            this.Property(p => p.ProductQuantity).HasColumnName("ProductQuantity");

            this.HasRequired<Order>(s => s.Order).WithMany(o => o.orderDetails).HasForeignKey<int>(s => s.OrderID);
            this.HasRequired<Product>(s => s.Product).WithMany(o => o.OrderDetails).HasForeignKey<int>(s => s.ProductID);
        }
    }
}
