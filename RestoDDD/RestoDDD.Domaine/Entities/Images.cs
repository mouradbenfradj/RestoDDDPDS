using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestoDDD.Domaine.Entities
{
  public  class Images
    {
        public int ImagesId { get; set; }
        public string Nom { get; set; }
        public string Categorie { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}
