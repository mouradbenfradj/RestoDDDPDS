using RestoDDD.Application.Entities;
using RestoDDD.Domaine.Entities;
using System.Collections.Generic;

namespace RestoDDD.Application.Interfaces
{
    public interface ICompteAppService : IAppServiceBase<Compte_DTO>
    {
        IEnumerable<Compte> GetParNomC(string nomC);
    }
}
