using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoDDD.Application.Entities
{
    public class Compte_DTO 
    {
        public Compte_DTO()
        {


            this.Reservations = new List<Reservation_DTO>();
            this.Commentaires = new List<Commentaire_DTO>();
    }
        public int CompteId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Adresse { get; set; }
        public string NumTel { get; set; }

        public virtual ICollection<Reservation_DTO> Reservations { get; set; }
        public virtual ICollection<Commentaire_DTO> Commentaires { get; set; }

    }
}
