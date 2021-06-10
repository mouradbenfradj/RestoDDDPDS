using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoDDD.Application.Entities
{
    public class GeoCoord_DTO
    {
        public int GeoCoordId { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }

       

        public virtual Restaurant_DTO Restaurant { get; set; }
    }
}
