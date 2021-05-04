using System;
using RRModel;
using System.Collections.Generic;
namespace RRUI
{
    public class MainMenu : IMenu
    {
        public void start(){
            bool repeat = true;

            do{
                Console.WriteLine("Welcome to my Restaurant Reviews Application!");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("[1] View a restaurant");
                Console.WriteLine("[2] Exit");
                string input = Console.ReadLine();
                switch(input){
                case "1":
                    viewRestaurant();
                break;
                case "2":
                    Console.WriteLine("Bubye!");
                    repeat = false;
                break;
                default:
                    Console.WriteLine("Please make a right selection");
                break;
                
            }
            }while(repeat);

        }
        public void viewRestaurant(){
            Restaurants goodTaste = new Restaurants("Good Taste", "Lahore", "Punjab");
            goodTaste.Reviews = new List<Review> {
                new Review{
                    Rating = 5,
                    Description = "A M A Z I N G",
                },
                new Review{
                    Rating = 5,
                    Description = "Good food for cheap",
                }
            };
            
            foreach (Review review in goodTaste.Reviews){
                Console.WriteLine(review.ToString());
            }
        }
    }
}