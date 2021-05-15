using System;
using System.Collections.Generic;
using SBL;
using Models;
namespace SUI
{
    public class ProductUICreation : IChocolateFactory
    {
        private IProductBL _iProductBL;
        private IValidateService _iValidate;
        public ProductUICreation(IProductBL iProductBL, IValidateService iValidate){
            _iProductBL = iProductBL;
            _iValidate = iValidate;
        }
        public void start(){
            bool repeat = true;
        do {
                Console.WriteLine("Press 1 to View Products");
                Console.WriteLine("Press 0 to Exit");
                string input = Console.ReadLine(); 
            switch(input){
                case "1":
                    ViewProducts();
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
        private void ViewProducts(){
            List<MProduct> products = _iProductBL.GetAllProducts();
            if(products.Count == 0){
                Console.WriteLine("There is no Product in the List, Please create one.");
            }else{
                foreach (MProduct product in products)
                {
                    Console.WriteLine(product.ToString());
                }
            }
        }
    }
} 
