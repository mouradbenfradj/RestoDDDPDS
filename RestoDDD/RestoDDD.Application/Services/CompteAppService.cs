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
    public class CompteAppService : AppServiceBase<Compte>, ICompteAppService
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
    }
}
