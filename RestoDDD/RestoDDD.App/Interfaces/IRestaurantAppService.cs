using RestoDDD.Application.Entities;
using RestoDDD.Domaine.Entities;
using System.Collections.Generic;

namespace RestoDDD.Application.Interfaces
{
    public interface IRestaurantAppService : IAppServiceBase<Restaurant_DTO>
    {

        IEnumerable<Restaurant> GetParNom(string nom);
        IEnumerable<Restaurant> GetParRegion(string region);

        IEnumerable<Restaurant> GetParSpecialité(string specialité);
        double GetNote(int Id);
        GeoCoord GetCoord(int Id);
        IEnumerable<Menu> GetMenus(int Id);
        IEnumerable<Table> GetTables(int Id);
       // bool Add(Restaurant obj);
    }
}
