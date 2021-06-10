using RestoDDD.Application.Interfaces;
using RestoDDD.Domaine.Entities;
using RestoDDD.Domaine.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoDDD.Application.Services
{
    public class NoteAppService : AppServiceBase<Note>, INoteAppService
    {
        private readonly INoteService _noteService;
        public NoteAppService(INoteService noteService)
            : base(noteService)
        {
            _noteService = noteService;
        }
    }
}
