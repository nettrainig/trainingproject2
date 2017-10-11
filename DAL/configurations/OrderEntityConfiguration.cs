using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using DAL.logic;

namespace DAL.configurations
{
    class OrderEntityConfiguration : EntityTypeConfiguration<Order>
    {
        public OrderEntityConfiguration()
        {
            this.ToTable("Orders");

            this.HasKey<int>(c => c.ID);

            this.Property(p => p.ClientID).HasColumnName("ClientID");
            this.Property(p => p.DateCreated).HasColumnName("DateCreated");
            this.Property(p => p.Status).HasColumnName("Status");

            this.HasRequired<Client>(s => s.Client).WithMany(o => o.Orders).HasForeignKey<int>(s => s.ClientID);
        }
    }
}
