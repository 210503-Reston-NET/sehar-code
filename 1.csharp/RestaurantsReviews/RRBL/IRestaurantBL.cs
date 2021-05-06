using System.Collections.Generic;
using RRModel;
namespace RRBL
{
    public interface IRestaurantBL
    {
         List<Restaurants> GetAllRestaurants();
    }
}