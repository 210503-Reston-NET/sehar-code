using System.Collections.Generic;
using RRModel;
using System.Linq;
namespace RRDL
{
    //Implemetation of the IRepository that stores data in a static collection
    public class RepoSC: IRepository
    {
        public Restaurants AddRestaurant(Restaurants restaurants)
        {
            RRSCStorage.Restaurants.Add(restaurants);
            return restaurants; 
        }

        public List<Restaurants> GetAllRestaurants(){
            //Todo return static collection of restaurants
            return RRSCStorage.Restaurants;
        }


        public Restaurants GetRestaurants(Restaurants restaurants)
        {
            return RRSCStorage.Restaurants.FirstOrDefault(resto => resto.Equals(restaurants));
        }
    }
}