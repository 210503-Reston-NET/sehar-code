using System;
using SBL;
using SDL;
namespace SUI
{
    public class LocationUI:IChocolateFactory
    {
        private IChocolateFactory location;
        public void start(){
            bool repeat = true;
            do{
                Console.WriteLine("Press 1 to go to a Location!"); 
                Console.WriteLine("Press 0 to Exit!");
                string input = Console.ReadLine();
                switch(input){
                    case "1":
                        location = new LocationCreation(new LocationBL(new StoreRepo()), new ValidateService());
                        location.start();
                    break;
                    case "0":
                        repeat = false;
                    break;
                    default:
                        Console.WriteLine("Enter a right value!");
                    break;
                }
            }while(repeat);
        }
    }
}