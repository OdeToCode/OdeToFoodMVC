using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OdeToFood.Data.Entities;

namespace OdeToFood.Data.Stores
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Scott's Pizza", Cuisine = CuisineType.Italian },
                new Restaurant { Id = 2, Name = "Mel's Place", Cuisine = CuisineType.None },
                new Restaurant { Id = 3, Name = "General Tso", Cuisine = CuisineType.Chinese },
                new Restaurant { Id = 4, Name = "Taco House", Cuisine = CuisineType.Mexican }
            };
        }

        public void Add(Restaurant newRestaurant)
        {
            newRestaurant.Id = restaurants.Max(r => r.Id) + 1;
            restaurants.Add(newRestaurant);
        }

        public void Commit()
        {
            
        }

        public Restaurant Get(int id)
        {
            return restaurants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants;
        }

        public void Update(Restaurant restaurant)
        {
            var target = restaurants.Single(r => r.Id == restaurant.Id);
            target.Name = restaurant.Name;
            target.Cuisine = restaurant.Cuisine;
        }
    }
}
