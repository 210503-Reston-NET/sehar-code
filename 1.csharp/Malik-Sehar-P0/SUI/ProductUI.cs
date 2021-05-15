using System;
using SBL;
using SDL;
namespace SUI
{
    public class ProductUI : IChocolateFactory
    {
        private IChocolateFactory _productCreate; 
        public void start(){
            bool repeat = true;
        do {
                Console.WriteLine("Press 1 to go to Products");
                Console.WriteLine("Press 0 to Exit");
                string input = Console.ReadLine(); 
            switch(input){
                case "1":
                    _productCreate = new ProductUICreation(new ProductBL(new StoreRepoFile()), new ValidateService());
                    _productCreate.start();
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