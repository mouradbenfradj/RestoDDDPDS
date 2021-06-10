using RestoDDD.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoDDD.Application.Interfaces
{
    public interface IReservationAppService : IAppServiceBase<Reservation>
    {
        IEnumerable<Reservation> GetParDate(DateTime date);
    }
}
