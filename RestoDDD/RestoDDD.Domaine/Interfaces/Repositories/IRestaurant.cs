using RestoDDD.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoDDD.Domaine.Interfaces.Repositories
{
    public interface IRestaurant : IRepositoryBase<Restaurant>
    {
        IEnumerable<Restaurant> GetParNom(string nom);
        IEnumerable<Restaurant> GetParRegion(string region);
        IEnumerable<Restaurant> GetParSpecialité(string specialité);

        double GetNote(int Id);
        GeoCoord GetCoord(int Id);
        IEnumerable<Menu> GetMenus(int Id);
        IEnumerable<Table> GetTables(int Id);


    }
}
