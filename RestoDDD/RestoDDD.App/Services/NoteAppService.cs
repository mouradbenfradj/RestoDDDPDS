using RestoDDD.Application.Entities;
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
    public class NoteAppService : AppServiceBase<Note , Note_DTO>, INoteAppService
    {
        private readonly INoteService _noteService;
        public NoteAppService(INoteService noteService)
            : base(noteService)
        {
            _noteService = noteService;
        }

        public bool Add(Note obj)
        {
            return _noteService.Add(obj);
        }

        public new Note GetById(int id)
        {
            return _noteService.GetById(id);
        }

        public new IEnumerable<Note> GetAll()
        {
            return _noteService.GetAll();
        }

        public bool Update(Note obj)
        {
            return _noteService.Update(obj);
        }

        public bool Remove(Note obj)
        {
            return _noteService.Remove(obj);
        }
    }
}
