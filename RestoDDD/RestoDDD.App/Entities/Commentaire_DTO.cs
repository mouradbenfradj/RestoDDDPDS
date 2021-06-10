using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestoDDD.Application.Entities
{
    public class Commentaire_DTO
    {
        public int? CommentaireId { get; set; }
        public string Content { get; set; }

        
        public virtual Restaurant_DTO Restaurant { get; set; }
        public virtual Compte_DTO Compte { get; set; }
    }
}
