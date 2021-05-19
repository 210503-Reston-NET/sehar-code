using Models;
using SDL;
using System;
using System.Collections.Generic;

namespace SBL
{
    public class LineItemBL : ILineItem
    {
        private IRepository _repo;
        public LineItemBL(IRepository repo){
            _repo = repo;
        }

        public List<MOrders> GetAllOrders()
        {
            return _repo.GetAllOrders();
        }

        // public double GetTotal(MProduct mProduct, int quantity)
        // {
        //     MProduct product =  _repo.GetAProduct(mProduct);
        //     return product.Price*quantity;
        // }
        public void ItemToAddInOrders(MOrders orders){
            _repo.ItemToAddInOrders(orders);
        }
    }
}