using System;
using Models;
using SBL;
using SDL;
namespace SUI
{
    public class CustomerUI: ICustomer
    {
        private ICustomer subCustomer;
        public void start(){
            bool repeat = true;
            do{
                Console.WriteLine("Press 1 to CRUD Cutomer");
                Console.WriteLine("Press 0 to Exit");
                string input = Console.ReadLine(); 
            switch(input){
                case "1":
                    subCustomer = new SubCustomer(new CustomerBL(new StoreRepo()),  new ValidateService());
                    subCustomer.start();
                break;
                case "0":
                    repeat = false;
                break;
                default:
                    Console.WriteLine("Please make a right selection!");
                break;
            }
            }while(repeat);
            
        }
    }
}