using RestoDDD.Application.Entities;
using RestoDDD.Application.Interfaces;
using RestoDDD.Domaine.Entities;
using RestoDDD.Domaine.Interfaces.Services;
using System.Collections.Generic;

namespace RestoDDD.Application.Services
{
    public class RestaurantAppService : AppServiceBase<Restaurant, Restaurant_DTO>, IRestaurantAppService
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
        public bool Add(Restaurant obj)
        {
            return _restaurantService.Add(obj);
        }

        public new Restaurant GetById(int id)
        {
            return _restaurantService.GetById(id);
        }

        public new IEnumerable<Restaurant> GetAll()
        {
            return _restaurantService.GetAll();
        }

        public bool Update(Restaurant obj)
        {
            return _restaurantService.Update(obj);
        }

        public bool Remove(Restaurant obj)
        {
            return _restaurantService.Remove(obj);
        }


        public IEnumerable<Restaurant> GetParRegion(string region)
        {
            return _restaurantService.GetParRegion(region);
        }

        public IEnumerable<Restaurant> GetParSpecialité(string specialité)
        {
            return _restaurantService.GetParSpecialité(specialité);
        }
    }
}
