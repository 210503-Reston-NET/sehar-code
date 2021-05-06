using System;
using RRBL;
using RRDL;
namespace RRUI
{
    public class MainMenu : IMenu
    {   
        private IMenu submenu;
        public void start(){
            bool repeat = true;

            do{
                Console.WriteLine("Welcome to my Restaurant Reviews Application!");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("[1] CRUD restaurant");
                Console.WriteLine("[2] Exit");
                string input = Console.ReadLine();
                switch(input){
                case "1":
                    submenu = new RestaurantMenu(new RestaurantBL(new RepoSC()));
                    submenu.start();
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
        
    }
}