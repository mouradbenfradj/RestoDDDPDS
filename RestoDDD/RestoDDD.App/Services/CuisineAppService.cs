using RestoDDD.Application.Entities;
using RestoDDD.Application.Interfaces;
using RestoDDD.Application.Services;
using RestoDDD.Domaine.Entities;
using RestoDDD.Domaine.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoDDD.Application.Services
{
  public  class CuisineAppService :AppServiceBase<Cuisine,Cuisine_DTO>, ICuisineAppService
    {
        private readonly ICuisineService _cuisineService;
        public CuisineAppService(ICuisineService cuisineService)
            : base(cuisineService)
        {
            _cuisineService = cuisineService;
        }


        public bool Add(Cuisine obj)
        {
            return _cuisineService.Add(obj);
        }

        public new Cuisine GetById(int id)
        {
            return _cuisineService.GetById(id);
        }

        public new IEnumerable<Cuisine> GetAll()
        {
            return _cuisineService.GetAll();
        }

        public bool Update(Cuisine obj)
        {
            return _cuisineService.Update(obj);
        }

        public bool Remove(Cuisine obj)
        {
            return _cuisineService.Remove(obj);
        }
    }
}
