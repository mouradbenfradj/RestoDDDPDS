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
    public class CompteService : ServiceBase<Compte>, ICompteService
    {
        private readonly ICompte _compteRepository;
        public CompteService(ICompte compteRepository)
            : base(compteRepository)
        {
            _compteRepository = compteRepository;
        }

        public IEnumerable<Compte> GetParNomC(string nomC)
        {
            return _compteRepository.GetParNomC(nomC);
        }
    }
}
