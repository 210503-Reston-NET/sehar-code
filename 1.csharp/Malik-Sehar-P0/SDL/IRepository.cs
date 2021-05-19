using Models;
using System.Collections.Generic;
namespace SDL
{
    public interface IRepository
    {
        List<MCustomer> GetAllCustomers();
        List<MProduct> GetAllProductss();
        MCustomer AddCustomer(MCustomer customer);
        MProduct AddProduct(MProduct product);
        MProduct GetAProduct(MProduct product);
        List<MLocation> GetAllLocation();
        MLocation GetAStore(MLocation location);
        List<MInventory> GetProductInStock(MLocation mLocation);
        List<MProduct> GetProductsInventory(MInventory inventory);
        MProduct searchAProduct(MProduct mProduct);
        MCustomer searchACustomer(MCustomer customer);
        List<MOrders> GetAllOrders();
        public void ItemToAddInOrders(MOrders orders);
    }
}