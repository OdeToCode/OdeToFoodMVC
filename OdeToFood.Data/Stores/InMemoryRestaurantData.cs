using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OdeToFood.Data.Entities;

namespace OdeToFood.Data.Stores
{
    class InMemoryRestaurantData : IRestaurantData
    {
        public IEnumerable<Restaurant> GetAll()
        {
            yield return new Restaurant { Id = 1, Name = "Scott's Pizza", Cuisine = CuisineType.Italian };
            yield return new Restaurant { Id = 2, Name = "Mel's Place", Cuisine = CuisineType.None };
            yield return new Restaurant { Id = 3, Name = "General Tso", Cuisine = CuisineType.Chinese };
            yield return new Restaurant { Id = 4, Name = "Taco House", Cuisine = CuisineType.Mexican };
        }
    }
}
