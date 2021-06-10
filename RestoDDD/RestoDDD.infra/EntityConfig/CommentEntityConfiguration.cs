using RestoDDD.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoDDD.infra.EntityConfig
{
    class CommentEntityConfiguration : EntityTypeConfiguration<Commentaire>
    {

        public CommentEntityConfiguration()
        {
            // Primary Key
            this.HasKey(t => t.CommentaireId);

            // Properties
            this.Property(t => t.Content)
                 .IsRequired()
                 .HasMaxLength(100);
            
         

            // Table & Column Mappings
            this.ToTable("Commentaire");


         /*   //relationShips
            this.HasRequired(t => t.Restaurant)
                .WithMany(t => t.Commentaires)
                .HasForeignKey(t => t.);

            this.HasRequired(t => t.Membre)
              .WithMany(t => t.Commentaires)
              .HasForeignKey(t => t.id_memb);*/



        }
    }
}
