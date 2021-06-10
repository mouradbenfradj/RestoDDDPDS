using RestoDDD.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoDDD.infra.EntityConfig
{
    class RestoEntityConfiguration : EntityTypeConfiguration<Restaurant>
    {
        public RestoEntityConfiguration()
        {


            HasKey(c => c.RestaurantId);

            Property(c => c.Nom)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Description)
                .IsRequired()
                .HasMaxLength(300);

            Property(c => c.specialite)
              .IsRequired()
              .HasMaxLength(50);

            Property(c => c.region)
              .IsRequired()
              .HasMaxLength(50);

            Property(c => c.MotBienvenu)
            .IsRequired()
            .HasMaxLength(50);

            Property(c => c.Slogon)
            .IsRequired()
            .HasMaxLength(50);

            Property(c => c.Adresse)
                .IsRequired();

            Property(c => c.Fax)
               .IsRequired()
               .HasMaxLength(50); ;

            


/*
            this.HasMany<Table>(s => s.Tables)
                      .WithRequired(s => s.Restaurant)
                      .HasForeignKey(s => s.TableId);

            this.HasMany<Commentaire>(s => s.Commentaires)
                   .WithRequired(s => s.Restaurant)
                   .HasForeignKey(s => s.CommentaireId);

            this.HasMany<Menu>(s => s.Menus)
                   .WithRequired(s => s.Restaurant)
                   .HasForeignKey(s => s.MenuId);

            this.HasMany<Note>(s => s.Notes)
                   .WithRequired(s => s.Restaurant)
                   .HasForeignKey(s => s.NoteId);
  */

            this.ToTable("Restaurant");
        }




    }
}
