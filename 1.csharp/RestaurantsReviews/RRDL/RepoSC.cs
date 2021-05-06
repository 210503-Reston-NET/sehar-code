using System.Collections.Generic;
using RRModel;
namespace RRDL
{
    //Implemetation of the IRepository that stores data in a static collection
    public class RepoSC: IRepository
    {
        public List<Restaurants> GetAllRestaurants(){
            //Todo return static collection of restaurants
            return RRSCStorage.Restaurants;
        }
    }
}