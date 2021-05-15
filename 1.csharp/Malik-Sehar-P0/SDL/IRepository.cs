using Models;
using System.Collections.Generic;
namespace SDL
{
    public interface IRepository
    {
        List<MCustomer> GetAllCustomers();
        List<MProduct> GetAllProducts();
        MCustomer AddCustomer(MCustomer customer);
        MProduct AddProduct(MProduct product);
        MProduct GetAProduct(MProduct product);
        List<MLocation> GetAllLocation();
        
    }
}