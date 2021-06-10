using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace RestoDDD.Application.Entities
{
    public class Table_DTO
    {
        public int TableId { get; set; }
        public int NombrePers { get; set; }
        public bool Etat { get; set; }
        


        public virtual Restaurant_DTO Restaurant { get; set; }
    }
}
