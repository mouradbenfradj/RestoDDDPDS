using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestoDDD.Application.Entities
{
   public class Membre_DTO :Personne_DTO
    {
       public Membre_DTO()
        {
            this.Reservations = new List<Reservation_DTO>();
            this.Commentaires = new List<Commentaire_DTO>();
           
        }
        public int MembreId { get; set; }

        public virtual ICollection<Reservation_DTO> Reservations { get; set; }
        public virtual ICollection<Commentaire_DTO> Commentaires { get; set; }

        

    }
}
