using RestoDDD.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoDDD.Domaine.Interfaces.Services
{
    public interface ICompteService : IServiceBase<Compte>
    {
        IEnumerable<Compte> GetParNomC(string nomC);
    }
}
