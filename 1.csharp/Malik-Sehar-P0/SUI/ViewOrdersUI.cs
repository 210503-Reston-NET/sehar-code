using Models;
using System.Collections.Generic;
using SBL;
namespace SUI
{
    public class ViewOrdersUI:IChocolateFactory
    {
        private ILineItem _lineItem;
        public ViewOrdersUI(ILineItem lineItem){
            _lineItem = lineItem;
        }
        public void start(){
            List<MOrders> allOrders = _lineItem.GetAllOrders();
            
        }
    }
}