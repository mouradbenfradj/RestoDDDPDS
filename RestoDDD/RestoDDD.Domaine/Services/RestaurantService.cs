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
    public class RestaurantService : ServiceBase<Restaurant>, IRestaurantService
    {

        private readonly IRestaurant _restaurantRepository;

        public RestaurantService(IRestaurant restaurantRepository)
            : base(restaurantRepository)
        {

            _restaurantRepository = restaurantRepository;
        }
        public GeoCoord GetCoord(int Id)
        {
            return _restaurantRepository.GetCoord(Id);
        }

        public IEnumerable<Menu> GetMenus(int Id)
        {
            return _restaurantRepository.GetMenus(Id);
        }

        public double GetNote(int Id)
        {
            return _restaurantRepository.GetNote(Id);
        }

        public IEnumerable<Restaurant> GetParNom(string nom)
        {
            return _restaurantRepository.GetParNom(nom);
        }

        public IEnumerable<Table> GetTables(int Id)
        {
            return _restaurantRepository.GetTables(Id);
        }


        public IEnumerable<Restaurant> GetParRegion(string region)
        {
            return _restaurantRepository.GetParRegion(region);
        }

        public IEnumerable<Restaurant> GetParSpecialité(string specialité)
        {
            return _restaurantRepository.GetParSpecialité(specialité);
        }
    }
}
