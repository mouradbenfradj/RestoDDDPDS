using System.Collections.Generic;

namespace RestoDDD.Application.Entities
{
  public  class Cuisine_DTO
    {
        public Cuisine_DTO()
        {
            this.Menu = new List<Menu_DTO>();
        }
        public int CuisineID { get; set; }
        public string typeCuisine { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public virtual ICollection<Menu_DTO> Menu { get; set; }
        public virtual Restaurant_DTO Restaurant { get; set; }
    }
}
