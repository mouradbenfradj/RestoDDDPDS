using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoDDD.Application.Entities
{
     public class Restaurant_DTO
    {
         public Restaurant_DTO()
         {
             this.Commentaires = new List<Commentaire_DTO>();
             this.Tables = new List<Table_DTO>();
             this.Menus= new List<Menu_DTO>();
             this.Notes = new List<Note_DTO>();
             this.Reservations = new List<Reservation_DTO>();


          }
        public int RestaurantId { get; set; }
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public string Description { get; set; }
        //public int GeoCoordId { get; set; }

        //public virtual GeoCoord Coord { get; set; }
        public virtual ICollection<Commentaire_DTO> Commentaires { get; set; }
        public virtual ICollection<Table_DTO> Tables { get; set; }
        public virtual ICollection<Menu_DTO> Menus { get; set; }
        public virtual ICollection<Note_DTO> Notes { get; set; }
        public virtual ICollection<Reservation_DTO> Reservations { get; set; }
    }
}
