using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestoDDD.Domaine.Entities
{
    public class Cuisine
    {
        public Cuisine()
        {
            this.Menu = new List<Menu>();
        }
        public int CuisineID { get; set; }
        public string typeCuisine { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public virtual ICollection<Menu> Menu { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}
