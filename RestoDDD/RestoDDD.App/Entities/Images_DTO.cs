using RestoDDD.Application.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestoDDD.Application.Entities
{
  public  class Images_DTO
    {

        public int ImagesId { get; set; }
        public string Nom { get; set; }
        public string Categorie { get; set; }
        public virtual Restaurant_DTO Restaurant { get; set; }
    }
}
