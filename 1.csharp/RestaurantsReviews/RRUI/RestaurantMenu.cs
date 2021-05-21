using System;
using System.Collections.Generic;
using RRModel;
using RRBL;
namespace RRUI
{
    public class RestaurantMenu : IMenu
    {
        private IRestaurantBL _restaurantBL;
        private IValidateService _validate;
        public RestaurantMenu(IRestaurantBL restaurantBL, IValidateService validate){
            _restaurantBL = restaurantBL;
            _validate = validate;
        }
      public void start(){
          bool repeat = true;
           do{
                Console.WriteLine("Welcome to my Restaurant Menu");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("[1] View restaurant");
                Console.WriteLine("[2] Add restaurant");
                Console.WriteLine("[3] Go Back!s");
                string input = Console.ReadLine();
                switch(input){
                case "1":
                    viewRestaurants();
                break;
                case "2":
                AddARestaurant();
                break;
                case "3":
                    repeat = false;
                break;
                default:
                    Console.WriteLine("Please make a right selection");
                break;
                
            }
            }while(repeat);
    }
    private void AddARestaurant(){
        Console.WriteLine("Enter the details you want to add a restaurant.");
        string name = _validate.ValidateString("Enter a Restaurant name");
        string city = _validate.ValidateString("Enter a City where the restaurant is located:");
        string state = _validate.ValidateString("Enter a State where the restaurant is located at:");

            Restaurants newRestaurant = new Restaurants(name, city, state);
        try{
            //Todo: call a BL to add a Restaurant
            Restaurants createdRestaurant = _restaurantBL.AddRestaurant(newRestaurant);
            Console.WriteLine(createdRestaurant.ToString());
        }
        catch(Exception ex){
            Console.WriteLine(ex.Message);
        }
    }
    private void viewRestaurants(){
            List<Restaurants> restaurants = _restaurantBL.GetAllRestaurants();
            if(restaurants.Count == 0){
                Console.WriteLine("No Restaurant to view, you should add one.");
            }
            else{
                foreach (Restaurants restaurant in restaurants){
                    Console.WriteLine(restaurant.ToString());
                }
            }
        }  
    }
}