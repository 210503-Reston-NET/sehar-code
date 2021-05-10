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
            return StorageSC.products.FirstOrDefault(product => product.Id.Equals(product.Id));
        }
    }
}