using RestoDDD.Application.Entities;
using RestoDDD.Domaine.Entities;
using System;
using System.Collections.Generic;

namespace RestoDDD.Application.Interfaces
{
    public interface IReservationAppService : IAppServiceBase<Reservation_DTO>
    {
        IEnumerable<Reservation> GetParDate(DateTime date);
    }
}
