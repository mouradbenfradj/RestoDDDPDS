using RestoDDD.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoDDD.infra.EntityConfig
{
    class CuisineEntityConfiguration : EntityTypeConfiguration<Cuisine>
    {
        public CuisineEntityConfiguration()
        {
            // Primary Key
            this.HasKey(t => t.CuisineID);

            // Properties
            this.Property(t => t.Description)
                 .IsRequired()
                 .HasMaxLength(100);

            this.Property(t => t.typeCuisine)
               .IsRequired()
               .HasMaxLength(50);
            this.Property(t => t.Image)
               .IsRequired();
             


            // Table & Column Mappings
            this.ToTable("Cuisine");
        }
    }
}
