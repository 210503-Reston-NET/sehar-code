using System.Collections.Generic;
using RRModel;
using System.IO;
using System.Text.Json; // Json serialization 
using System; 
using System.Linq;
namespace RRDL
{
    /// <summary>
    /// Implementation of Repo but i store it in a file
    /// </summary>
    public class RepoFile : IRepository
    {
        //The file path is relative to where you run your program.
        //I run in RRUI so the file path is how i navigate from RRUI to the path where file is stored.
        private const string filePath = "../RRDL/Restaurants.json";
        private string jsonString;
        public Restaurants AddRestaurant(Restaurants restaurants)
        {
            List<Restaurants> restaurantFromFile = GetAllRestaurants();
            restaurantFromFile.Add(restaurants);
            jsonString = JsonSerializer.Serialize(restaurantFromFile);
            File.WriteAllText(filePath, jsonString);
            return restaurants;
        }

        public List<Restaurants> GetAllRestaurants()
        {
            try{
                jsonString = File.ReadAllText(filePath);
            }
            catch(Exception){
                // Console.WriteLine(ex.Message);
                return new List<Restaurants>();
            }
            return JsonSerializer.Deserialize<List<Restaurants>>(jsonString);
        }

        public Restaurants GetRestaurants(Restaurants restaurants)
        {
            return GetAllRestaurants().FirstOrDefault(resto => resto.Equals(restaurants));
        }
    }
}