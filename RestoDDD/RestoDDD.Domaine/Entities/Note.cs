using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestoDDD.Domaine.Entities
{
  public  class Note
    {
        public int NoteId { get; set; }
        public double NoteR { get; set; }

   
       

     

        public Restaurant Restaurant { get; set; }
    }
}
