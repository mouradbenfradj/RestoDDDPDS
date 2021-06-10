using RestoDDD.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoDDD.infra.EntityConfig
{
    public class CompteEntityConfiguration : EntityTypeConfiguration<Compte>
    {

        public CompteEntityConfiguration()
        {
            // Primary Key
            this.HasKey(t => t.CompteId);

            // Properties
            this.Property(t => t.Nom)
                 .IsRequired()
                 .HasMaxLength(50);
            this.Property(t => t.Prenom)
            .IsRequired()
            .HasMaxLength(50);
            this.Property(t => t.Email)
          .IsRequired()
          .HasMaxLength(100);
            this.Property(t => t.NumTel)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Adresse)
                .IsRequired()
                .HasMaxLength(100);
           
            // Table & Column Mappings
            this.ToTable("Compte");

           
            
        }
    }
}
