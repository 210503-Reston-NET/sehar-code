using System;
using System.Collections.Generic;
using Models;
using System.Text.Json;
using System.IO;
using System.Linq;

namespace SDL
{
    public class StoreRepoFile:IRepository
    {
        private const string proFilePath = "../SDL/Products.json";
        private const string customerFilePath = "../SDL/Customer.json";
        private string jsonString;

        public MCustomer AddCustomer(MCustomer mcustomer)
        {
            List<MCustomer> customersFromFile = GetAllCustomers();
            customersFromFile.Add(mcustomer);
            jsonString = JsonSerializer.Serialize(customersFromFile);
            File.WriteAllText(customerFilePath, jsonString);
            return mcustomer;
        }

        public MProduct AddProduct(MProduct mproduct)
        {
            List<MProduct> ProductsFromFile = GetAllProducts();
            ProductsFromFile.Add(mproduct);
            jsonString = JsonSerializer.Serialize(ProductsFromFile);
            File.WriteAllText(proFilePath, jsonString);
            return mproduct;
        }

        public List<MCustomer> GetAllCustomers()
        {
            try{
                jsonString = File.ReadAllText(customerFilePath);
            }catch(Exception ex){
                Console.WriteLine(ex.Message);
                return new List<MCustomer>();
            }
            return JsonSerializer.Deserialize<List<MCustomer>>(jsonString);
        }

        public List<MProduct> GetAllProducts()
        {
            try{

            jsonString = File.ReadAllText(proFilePath);
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

        public List<MLocation> GetAllLocation(){
            throw new NotImplementedException();
        }

        public List<MCustomer> searchCustomer(MCustomer customer)
        {
            throw new NotImplementedException();
        }

        public MLocation GetAStore(MLocation location)
        {
            throw new NotImplementedException();
        }

        public List<MInventory> GetProductInStock(MLocation mLocation)
        {
            throw new NotImplementedException();
        }

        public List<MProduct> GetProductsInventory(MInventory inventory)
        {
            throw new NotImplementedException();
        }

        public MProduct searchAProduct(MProduct mProduct)
        {
            throw new NotImplementedException();
        }

        public MCustomer searchACustomer(MCustomer customer)
        {
            throw new NotImplementedException();
        }

        public void ItemToAdd(MProduct mLine, MCustomer mCustomer, int q, int storeId)
        {
            throw new NotImplementedException();
        }

        public List<MOrders> GetAllOrders()
        {
            throw new NotImplementedException();
        }

        public void ItemToAddInOrders(MCustomer mCustomer, int storeid, double q)
        {
            throw new NotImplementedException();
        }

        public void ItemToAdd(MProduct mLine, MCustomer mCustomer, int q, double storeId)
        {
            throw new NotImplementedException();
        }

        public void ItemToAddInOrders(MCustomer mCustomer, int storeid, int q)
        {
            throw new NotImplementedException();
        }

        public void ItemToAddInOrders(MOrders orders)
        {
            throw new NotImplementedException();
        }

        public List<MProduct> GetAllProductss()
        {
            throw new NotImplementedException();
        }
    }
}