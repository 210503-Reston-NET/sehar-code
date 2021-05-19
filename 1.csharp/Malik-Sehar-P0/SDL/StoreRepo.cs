using System.Collections.Generic;
using Models;
using System.Linq;
namespace SDL
{
    public class StoreRepo: IRepository
    {
        public List<MCustomer> GetAllCustomers(){
            return StorageSC.customers;
        }
        public List<MProduct> GetAllProducts(){
            return StorageSC.products;
        }
        public MCustomer AddCustomer(MCustomer customer){
            StorageSC.customers.Add(customer);
            return customer;

        }

        public MProduct AddProduct(MProduct product)
        {
            StorageSC.products.Add(product);
            return product;
        }
        public MProduct GetAProduct(MProduct product){
            return StorageSC.products.FirstOrDefault(pro => pro.Name.Equals(product.Name) && pro.Price.Equals(product.Price));
        }

        public List<MLocation> GetAllLocation()
        {
            return StorageSC.locations;
        }

        public List<MCustomer> searchCustomer(MCustomer customer)
        {
            throw new System.NotImplementedException();
        }

        public MLocation GetAStore(MLocation location)
        {
            throw new System.NotImplementedException();
        }

        public List<MInventory> GetProductInStock(MLocation mLocation)
        {
            throw new System.NotImplementedException();
        }

        public List<MProduct> GetProductsInventory(MInventory inventory)
        {
            throw new System.NotImplementedException();
        }

        public MProduct searchAProduct(MProduct mProduct)
        {
            throw new System.NotImplementedException();
        }

        public MCustomer searchACustomer(MCustomer customer)
        {
            throw new System.NotImplementedException();
        }

        public void ItemToAdd(MProduct mLine, MCustomer mCustomer, int q, int storeId)
        {
            throw new System.NotImplementedException();
        }

        public List<MOrders> GetAllOrders()
        {
            throw new System.NotImplementedException();
        }

        public void ItemToAddInOrders(MCustomer mCustomer, int storeid, double q)
        {
            throw new System.NotImplementedException();
        }

        public void ItemToAdd(MProduct mLine, MCustomer mCustomer, int q, double storeId)
        {
            throw new System.NotImplementedException();
        }

        public void ItemToAddInOrders(MCustomer mCustomer, int storeid, int q)
        {
            throw new System.NotImplementedException();
        }

        public void ItemToAddInOrders(MOrders orders)
        {
            throw new System.NotImplementedException();
        }

        public List<MProduct> GetAllProductss()
        {
            throw new System.NotImplementedException();
        }
    }
}