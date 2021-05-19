using System.Collections.Generic;
using Models;
namespace SBL
{
    public interface ILocationBL
    {
        List<MLocation> GetAllLocation();
        MLocation GetStore(MLocation location);
        List<MInventory> GetProductInStock(MLocation mLocation);
    }
}