using RestoDDD.Domaine.Entities;
using RestoDDD.Domaine.Interfaces.Repositories;
using RestoDDD.Domaine.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoDDD.Domaine.Services
{
    public class NoteService : ServiceBase<Note>, INoteService
    {
        private readonly INote _noteRepository;
        public NoteService(INote noteRepository)
            : base(noteRepository)
        {
            _noteRepository = noteRepository;
        }
    }
}
