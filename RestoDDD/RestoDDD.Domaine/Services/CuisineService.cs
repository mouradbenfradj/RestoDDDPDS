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
  public  class CuisineService :ServiceBase<Cuisine> , ICuisineService
    {
         private readonly ICuisine _cuisineRepository;
         public CuisineService(ICuisine cuisineRepository)
            : base(cuisineRepository)
        {
            _cuisineRepository = cuisineRepository;
        }
    }
}
