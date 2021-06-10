using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoDDD.Domaine.Entities
{
    public class GeoCoord
    {
        public int GeoCoordId { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }

        

        public virtual Restaurant Restaurant { get; set; }
    }
}
