using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoDDD.Application.Entities
{
    public class Facture_DTO
    {
        public int FactureId { get; set; }

        

        public virtual Reservation_DTO Reservation { get; set; }

    }
}
