using System.Collections.Generic;


namespace RestoDDD.Domaine.Entities
{
    public class Restaurant
    {
        public Restaurant()
        {

            this.Reservations = new List<Reservation>();
            this.Commentaires = new List<Commentaire>();
            this.Images = new List<Images>();
            this.Tables = new List<Table>();
            this.Cuisine = new List<Cuisine>();
            this.Notes = new List<Note>();
        }

        public int RestaurantId { get; set; }
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public string Description { get; set; }
        public string MotBienvenu { get; set; }
        public string Slogon { get; set; }
        public string Lieu { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string region { get; set; }
        public string specialite { get; set; }
        public string Telephone { get; set; }


        public virtual ICollection<Commentaire> Commentaires { get; set; }
        public virtual ICollection<Images> Images { get; set; }
        public virtual ICollection<Table> Tables { get; set; }
        public virtual ICollection<Cuisine> Cuisine { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}

