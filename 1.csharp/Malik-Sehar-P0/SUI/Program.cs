using System;
using Models;
namespace SUI
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            do{
                Console.WriteLine("[1] To Admin View");
                Console.WriteLine("[2] To Customer View");
                Console.WriteLine("[0] To Exit");
                string input = Console.ReadLine();
                switch(input){
                    case "1":
                        ChocolateFactory.mainMenu("main").start();
                    break;
                    case "2":
                        ChocolateFactory.mainMenu("login").start();
                    break;
                    case "0":
                        repeat = false;
                    break;
                    default:
                    break;
                }
            }while(repeat);
        }
    }
}
