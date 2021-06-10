using RestoDDD.Domaine.Entities;
using RestoDDD.Domaine.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace RestoDDD.infra.Repositories
{
    public class RestaurantRepository : RepositoryBase<Restaurant>, IRestaurant
    {
        public IEnumerable<Restaurant> GetParNom(string nom)
        {
            return Db.Restaurants.Where(p => p.Nom == nom);
        }

        public double GetNote(int Id)
        {
            return Db.Notes.Where(p => p.Restaurant.RestaurantId == Id).Average(p => p.NoteR);
        }

        public GeoCoord GetCoord(int Id)
        {
            return Db.GeoCoords.FirstOrDefault(p => p.Restaurant.RestaurantId == Id);
        }

        public IEnumerable<Menu> GetMenus(int Id)
        {
            return Db.Menus.Where(p => p.Restaurant.RestaurantId == Id).ToList();
        }

        public IEnumerable<Table> GetTables(int Id)
        {
            return Db.Tables.Where(p => p.Restaurant.RestaurantId == Id).ToList();
        }




        public IEnumerable<Restaurant> GetParRegion(string region)
        {
            return Db.Restaurants.Where(p => p.region == region);
        }

        public IEnumerable<Restaurant> GetParSpecialité(string specialité)
        {
            return Db.Restaurants.Where(p => p.specialite == specialité);
        }
    }
}
