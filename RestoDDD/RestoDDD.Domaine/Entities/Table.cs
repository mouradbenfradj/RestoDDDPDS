using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestoDDD.Domaine.Entities
{
 public   class Table
    {
        public int TableId { get; set; }
        public int NombrePers { get; set; }
        public bool Etat { get; set; }
       
     

        public virtual Restaurant Restaurant { get; set; }
    }
}
