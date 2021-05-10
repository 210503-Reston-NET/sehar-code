using System;
using System.Collections.Generic;
using Models;
using System.Text.Json;
using System.IO;
using System.Linq;

namespace SDL
{
    public class ProductRepoFile:IRepository
    {
        private const string filePath = "../SDL/Products.json";
        private string jsonString;

        public MCustomer AddCustomer(MCustomer customer)
        {
            throw new System.NotImplementedException();
        }

        public MProduct AddProduct(MProduct mproduct)
        {
            List<MProduct> ProductsFromFile = GetAllProducts();
            ProductsFromFile.Add(mproduct);
            jsonString = JsonSerializer.Serialize(ProductsFromFile);
            File.WriteAllText(filePath, jsonString);
            return mproduct;
        }

        public List<MCustomer> GetAllCustomers()
        {
            throw new System.NotImplementedException();
        }

        public List<MProduct> GetAllProducts()
        {
            try{

            jsonString = File.ReadAllText(filePath);
            }catch(Exception ex){
                Console.WriteLine(ex.Message);
                return new List<MProduct>();
            }
            return JsonSerializer.Deserialize<List<MProduct>>(jsonString);
        }

        public MProduct GetAProduct(MProduct product)
        {
            return GetAllProducts().FirstOrDefault(prod => prod.Equals(product));
        }
    }
}