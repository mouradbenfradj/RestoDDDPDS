using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestoDDD.Domaine.Entities
{
    public class Commentaire
    {
        public int? CommentaireId { get; set; }
        public string Content { get; set; }

      
        public virtual Restaurant Restaurant { get; set; }
        public virtual Compte Compte { get; set; }
    }
}
