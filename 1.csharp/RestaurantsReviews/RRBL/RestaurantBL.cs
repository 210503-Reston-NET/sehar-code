using System.Collections.Generic;
using RRModel;
using RRDL;
namespace RRBL
{
    /// <summary>
    /// business logic class for the restaurant model
    /// </summary>
    public class RestaurantBL: IRestaurantBL
    {
        //some things to note:
        //business classes are incharge of processing / sanitizing and further validating data
        // As the name suggests it is incharge of processing the logic. for example, how does the ordering
        //process work in a store app
        //Any logic that is related to accessing the data stored somewhere, should be relegated to the DL. 

        private IRepository _repo;
        public RestaurantBL(IRepository repo){
            _repo = repo;
        }
        public List<Restaurants> GetAllRestaurants(){
            //Note that is method isn't really dependent on any input/ parameters, i can directly call the
            //DL method in charge of getting all restaurants
            return _repo.GetAllRestaurants();

        }
    }
}