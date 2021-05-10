using Models;
using System.Collections.Generic;
namespace SDL
{
    public class StorageSC
    {
        public static List<MCustomer> customers = new List<MCustomer>(){
            new MCustomer(2, "Sehar", "Malik")
        };
        public static List<MProduct> products = new List<MProduct>(){
            new MProduct(1, "Chocolate", "This is Dairy Milk Chocolate", 10, 1)
        };
    }
}