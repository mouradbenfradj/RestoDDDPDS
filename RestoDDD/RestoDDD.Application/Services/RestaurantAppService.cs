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
    public class RestaurantAppService : AppServiceBase<Restaurant>, IRestaurantAppService
    {
        private readonly IRestaurantService _restaurantService;
        public RestaurantAppService(IRestaurantService restaurantService)
            : base(restaurantService)
        {
            _restaurantService = restaurantService;
        }

        public GeoCoord GetCoord(int Id)
        {
            return _restaurantService.GetCoord(Id);
        }

        public IEnumerable<Menu> GetMenus(int Id)
        {
            return _restaurantService.GetMenus(Id);
        }

        public double GetNote(int Id)
        {
            return _restaurantService.GetNote(Id);
        }

        public IEnumerable<Restaurant> GetParNom(string nom)
        {
            return _restaurantService.GetParNom(nom);
        }

        public IEnumerable<Table> GetTables(int Id)
        {
            return _restaurantService.GetTables(Id);
        }
    }
}
