using RestoDDD.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoDDD.infra.EntityConfig
{
    class NoteEntityConfiguration : EntityTypeConfiguration<Note>
    {
        public NoteEntityConfiguration()
        {
            // Primary Key
            this.HasKey(t => t.NoteId);


            this.Property(t => t.NoteR)
                 .IsRequired();
                 
            

            
            this.ToTable("Note");
            

            //relationShips
          /*  this.HasRequired(t => t.Restaurant)
                .WithMany(t => t.Notes)
                .HasForeignKey(t => t.id_resto);*/

           
                
                
                
        }
    }
}
