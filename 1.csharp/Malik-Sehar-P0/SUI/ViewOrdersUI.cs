using Models;
using System.Collections.Generic;
using System;
using SBL;
namespace SUI
{
    public class ViewOrdersUI:IChocolateFactory
    {
        private ILineItem _lineItem;
        private IValidateService _iValidate;
        public ViewOrdersUI(ILineItem lineItem, IValidateService validate){
            _lineItem = lineItem;
            _iValidate = validate;
        }
        public void start(){

            string storeName = _iValidate.ValidateString("Please enter the restaurant name to search the order history for!");
            string storeLocation = _iValidate.ValidateString("Please enter the restaurant Location to search the order history for!");
            MLocation searchedOrdersInStore = new MLocation(storeName, storeLocation);
            try{
                List<MOrders> allOrders = _lineItem.GetAllOrders(searchedOrdersInStore);
                foreach (MOrders order in allOrders)
                {
                    Console.Write(order.ToString());
                }
            }catch(Exception ex){
                Console.WriteLine(ex.Message);
            }
        }
    }
}