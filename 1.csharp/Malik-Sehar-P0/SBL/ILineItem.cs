using Models;
using System.Collections.Generic;
namespace SBL
{
    public interface ILineItem
    {
        List<MOrders> GetAllOrders();
        public void ItemToAddInOrders(MOrders orders);
    }
}