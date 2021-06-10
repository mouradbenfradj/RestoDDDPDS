using RestoDDD.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoDDD.Domaine.Interfaces.Repositories
{
    public interface IReservation : IRepositoryBase<Reservation>
    {
        IEnumerable<Reservation> GetParDate(DateTime date);
    }
}
