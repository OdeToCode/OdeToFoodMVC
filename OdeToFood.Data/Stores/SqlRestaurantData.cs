using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OdeToFood.Data.Entities;

namespace OdeToFood.Data.Stores
{
    public class SqlRestaurantData : IRestaurantData
    {
        private readonly RestaurantDbContext db;

        public SqlRestaurantData(RestaurantDbContext db)
        {
            this.db = db;
        }

        public void Add(Restaurant newRestaurant)
        {
            db.Restaurants.Add(newRestaurant);
        }

        public void Commit()
        {
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Restaurant Get(int id)
        {
            return db.Restaurants.Find(id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return db.Restaurants.OrderBy(r => r.Name);
        }

        public void Update(Restaurant restaurant)
        {
            var entry = db.Entry(restaurant);
            entry.State = EntityState.Modified;
        }
    }
}
