using Models;
using System.Collections.Generic;
namespace SBL
{
    public interface IInventory
    {
        List<MProduct> GetProductsInventory(MInventory inventory);
    }
}