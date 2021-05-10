using System;
using System.Collections.Generic;
using SBL;
using Models;
namespace SUI
{
    public class ProductUICreation : IProduct
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
                Console.WriteLine("Press 1 to Add Product");
                Console.WriteLine("Press 2 to View Products");
                Console.WriteLine("Press 0 to Exit");
                string input = Console.ReadLine(); 
            switch(input){
                case "1":
                    //Add Product Function goes here.
                    AddProduct();
                break;
                case "2":
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
        private void AddProduct(){
            int Id;
            Random generator = new Random();
            Id = generator.Next(100000, 1000000);
            string Title = _iValidate.ValidateString("Enter Product Title:");
            string Description = _iValidate.ValidateString("Enter Product Description:");
            double Price = _iValidate.ValidateDouble("Enter the Price");
            int quatity = _iValidate.ValidateInt("Enter quatity of products");
            MProduct CreatedProduct = new MProduct(Id,Title,Description,Price,quatity);
            try{
                MProduct NewProduct = _iProductBL.AddAProduct(CreatedProduct);
                Console.WriteLine(NewProduct.ToString());
            }catch(Exception ex){
                Console.WriteLine(ex.Message);
            }
        }
    }
} 
