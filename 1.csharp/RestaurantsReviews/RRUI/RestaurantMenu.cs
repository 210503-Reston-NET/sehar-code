using System;
using System.Collections.Generic;
using RRModel;
using RRBL;
namespace RRUI
{
    public class RestaurantMenu : IMenu
    {
        private IRestaurantBL _restaurantBL;
        public RestaurantMenu(IRestaurantBL restaurantBL){
            _restaurantBL = restaurantBL;
        }
      public void start(){
          bool repeat = true;
           do{
                Console.WriteLine("Welcome to my Restaurant Menu");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("[1] View restaurant");
                Console.WriteLine("[2] Go Back!s");
                string input = Console.ReadLine();
                switch(input){
                case "1":
                    viewRestaurants();
                break;
                case "2":
                    repeat = false;
                break;
                default:
                    Console.WriteLine("Please make a right selection");
                break;
                
            }
            }while(repeat);
    }
    private void viewRestaurants(){
            List<Restaurants> restaurants = _restaurantBL.GetAllRestaurants();
            foreach (Restaurants restaurant in restaurants){
                Console.WriteLine(restaurant.ToString());
            }
        }  
    }
}