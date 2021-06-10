using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestoDDD.Domaine.Entities
{
   public class Menu
    {
        public int MenuId { get; set; }
        public string Nom { get; set; }
        public double Prix { get; set; }
        public string Description { get; set; }

     
        public virtual Restaurant Restaurant { get; set; }
    }
}
