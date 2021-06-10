using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestoDDD.Application.Entities
{
    public class Menu_DTO
    {
        public int MenuId { get; set; }
        public string Nom { get; set; }
        public double Prix { get; set; }
        public string Description { get; set; }

        public int id_resto { get; set; }
        public virtual Restaurant_DTO Restaurant { get; set; }
    }
}
