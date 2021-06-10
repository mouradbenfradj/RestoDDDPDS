using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestoDDD.Domaine.Entities
{
  public  class Reservation
    {
        public int ReservationId { get; set; }
        public int NombrePres { get; set; }
        public DateTime ResvDate { get; set; }

       


        public virtual Compte Compte { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}
