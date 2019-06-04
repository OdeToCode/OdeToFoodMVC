using OdeToFood.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data.Stores
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }
}
