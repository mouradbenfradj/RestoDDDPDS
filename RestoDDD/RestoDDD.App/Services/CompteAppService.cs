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
    public class CompteAppService : AppServiceBase<Compte,Compte_DTO>, ICompteAppService
    {
        private readonly ICompteService _compteService;
        public CompteAppService(ICompteService compteService)
            : base(compteService)
        {
            _compteService = compteService;
        }

        public IEnumerable<Compte> GetParNomC(string nomC)
        {
            return _compteService.GetParNomC(nomC);
        }

        public bool Add(Compte obj)
        {
            return _compteService.Add(obj);
        }

        public new Compte GetById(int id)
        {
            return _compteService.GetById(id);
        }

        public new IEnumerable<Compte> GetAll()
        {
            return _compteService.GetAll();
        }

        public bool Update(Compte obj)
        {
            return _compteService.Update(obj);
        }

        public bool Remove(Compte obj)
        {
            return _compteService.Remove(obj);
        }
    }
}
