using RestoDDD.Application.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestoDDD.Presentation.ViewModels
{
    public class RestaurantViewModels
    {
        public Restaurant_DTO Restaurant { get; set; }
        public IEnumerable<Images_DTO> ListeDesImagesRestaurant { get; set; }
        public IEnumerable<Cuisine_DTO> ListesDesCuisine { get; set; }
    }
}