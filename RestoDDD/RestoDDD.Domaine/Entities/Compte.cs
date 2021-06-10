using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoDDD.Domaine.Entities
{
    public class Compte 
    {

        public Compte(){


        this.Reservations = new List<Reservation>();
        this.Commentaires = new List<Commentaire>();
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

        public virtual ICollection<Reservation> Reservations { get; set; }
        public virtual ICollection<Commentaire> Commentaires { get; set; }

    }
}
