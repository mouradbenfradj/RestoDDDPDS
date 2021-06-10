using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestoDDD.Application.Entities
{
    public class Note_DTO
    {
        public int NoteId { get; set; }
        public double NoteR { get; set; }

        




        public Restaurant_DTO Restaurant { get; set; }
    }
}
