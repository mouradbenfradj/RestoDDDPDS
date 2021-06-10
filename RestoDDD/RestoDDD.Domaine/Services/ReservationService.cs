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
    public class ReservationService : ServiceBase<Reservation>, IReservationService
    {
        private readonly IReservation _reservationRepository;

        public ReservationService(IReservation reservationRepository)
            : base(reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        public IEnumerable<Reservation> GetParDate(DateTime date)
        {
            return _reservationRepository.GetParDate(date);
        }
    }
}
