using System.Collections.Generic;
using RestoDDD.Application.Entities;

namespace RestoDDD.Application.Entities
{
    public class Restaurant_DTO
    {
        public Restaurant_DTO()
        {

            this.Reservations = new List<Reservation_DTO>();
            this.Commentaires = new List<Commentaire_DTO>();
            this.Images = new List<Images_DTO>();
            this.Tables = new List<Table_DTO>();
            this.Cuisine = new List<Cuisine_DTO>();
            this.Notes = new List<Note_DTO>();
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


        public virtual ICollection<Commentaire_DTO> Commentaires { get; set; }
        public virtual ICollection<Images_DTO> Images { get; set; }
        public virtual ICollection<Table_DTO> Tables { get; set; }
        public virtual ICollection<Cuisine_DTO> Cuisine { get; set; }
        public virtual ICollection<Note_DTO> Notes { get; set; }
        public virtual ICollection<Reservation_DTO> Reservations { get; set; }
    }
}
