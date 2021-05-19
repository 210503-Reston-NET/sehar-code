using Models;
using SDL;
using System.Collections.Generic;
namespace SBL
{
    public class InventoryBL : IInventory
    {
        private IRepository _repo;
        public InventoryBL(IRepository repo){
            _repo = repo;
        }
        public List<MProduct> GetProductsInventory(MInventory inventory)
        {
            return _repo.GetProductsInventory(inventory);
        }
    }
}