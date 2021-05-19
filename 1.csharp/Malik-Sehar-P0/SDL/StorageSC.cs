using Models;
using System.Collections.Generic;
namespace SDL
{
    public class StorageSC
    {
        public static List<MCustomer> customers = new List<MCustomer>(){
            new MCustomer("Sehar", "1234567", "Reno NV")
        };
        public static List<MProduct> products = new List<MProduct>(){
            new MProduct("gd789","Chocolate",10.00)
        };

        public static List<MLocation> locations = new List<MLocation>(){
            new MLocation(1,"Walmart","xyz")
        };
    }
}