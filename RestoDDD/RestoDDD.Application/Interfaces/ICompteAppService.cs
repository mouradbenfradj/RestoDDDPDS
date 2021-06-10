using RestoDDD.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoDDD.Application.Interfaces
{
    public interface ICompteAppService : IAppServiceBase<Compte>
    {
        IEnumerable<Compte> GetParNomC(string nomC);
    }
}
