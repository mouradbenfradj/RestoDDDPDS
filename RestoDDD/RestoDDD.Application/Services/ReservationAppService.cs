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
    public class ReservationAppService : AppServiceBase<Reservation>, IReservationAppService
    {
        private readonly IReservationService _reservationService;
        public ReservationAppService(IReservationService reservationService)
            : base(reservationService)
        {
            _reservationService = reservationService;
        }

        public IEnumerable<Reservation> GetParDate(DateTime date)
        {
            return _reservationService.GetParDate(date);
        }
    }
}
