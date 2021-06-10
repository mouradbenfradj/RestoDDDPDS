using RestoDDD.Application.Entities;
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
    public class ReservationAppService : AppServiceBase<Reservation,Reservation_DTO>, IReservationAppService
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





        public bool Add(Reservation obj)
        {
            return _reservationService.Add(obj);
        }

        public new Reservation GetById(int id)
        {
            return _reservationService.GetById(id);
        }

        public new IEnumerable<Reservation> GetAll()
        {
            return _reservationService.GetAll();
        }

        public bool Update(Reservation obj)
        {
            return _reservationService.Update(obj);
        }

        public bool Remove(Reservation obj)
        {
            return _reservationService.Remove(obj);
        }
    }
}
