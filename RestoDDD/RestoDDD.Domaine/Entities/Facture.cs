using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoDDD.Domaine.Entities
{
    public class Facture
    {
        public int FactureId { get; set; }

    

        public virtual Reservation Reservation { get; set; }

    }
}
