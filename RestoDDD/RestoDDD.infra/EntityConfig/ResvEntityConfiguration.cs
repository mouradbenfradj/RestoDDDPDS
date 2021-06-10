using RestoDDD.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoDDD.infra.EntityConfig
{
    class ResvEntityConfiguration :EntityTypeConfiguration<Reservation>
    {
        public ResvEntityConfiguration()
        {
           
            this.HasKey(t => t.ReservationId);

           
            this.Property(t => t.ResvDate)
                 .IsRequired();


            this.Property(t => t.NombrePres)
            .IsRequired();
            

           

            
            this.ToTable("Reservation");


            //relationShips
          /*  this.HasRequired(t => t.Membre)
                .WithMany(t => t.Reservations)
                .HasForeignKey(t => t.id_memb);

            this.HasRequired(t => t.Restaurant)
                .WithMany(t => t.Reservations)
                .HasForeignKey(t => t.id_resto);*/


        }
    }
}
