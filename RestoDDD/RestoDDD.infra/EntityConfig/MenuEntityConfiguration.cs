using RestoDDD.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoDDD.infra.EntityConfig
{
    class MenuEntityConfiguration : EntityTypeConfiguration<Menu>
    {
         public MenuEntityConfiguration()
        {
            this.HasKey(t => t.MenuId);

            // Properties
            this.Property(t => t.Nom)
                 .IsRequired()
                 .HasMaxLength(50);
            this.Property(t => t.Prix)
            .IsRequired();
            
            this.Property(t => t.Description)
          .IsRequired()
          .HasMaxLength(100);
           

            // Table & Column Mappings
            this.ToTable("Menu");


            
          /*  this.HasRequired(t => t.Restaurant)
                .WithMany(t => t.Menus)
                .HasForeignKey(t => t.id_resto);*/

        }
    }
}
