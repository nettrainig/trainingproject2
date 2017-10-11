using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using DAL.logic;

namespace DAL.configurations
{
    class ClientEntityConfiguration : EntityTypeConfiguration<Client>
    {
        public ClientEntityConfiguration()
        {
            this.ToTable("Clients");

            this.HasKey<int>(c => c.ID);

            this.Property(p => p.Name).HasColumnName("Name");
        }
    }
}
