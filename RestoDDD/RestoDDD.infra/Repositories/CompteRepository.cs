using RestoDDD.Domaine.Entities;
using RestoDDD.Domaine.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoDDD.infra.Repositories
{
  public  class CompteRepository :RepositoryBase<Compte> ,ICompte
    {
        public IEnumerable<Compte> GetParNomC(string nomC)
        {
            return Db.Comptes.Where(p => p.Nom == nomC);
        }
    }
}
