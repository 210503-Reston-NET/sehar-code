using Models;
using System;
using System.Collections.Generic;
using SBL;
namespace SUI
{
    public class PlaceOrder : IChocolateFactory
    {
        private IProductBL _iProductBL;
        private ILocationBL _iLocationBL;
        private IValidateService _IValidate;
        private IInventory _iInventory; 
        private ILineItem _iLineItem;
        int selectedInventory;
        MCustomer mcustomer = new MCustomer();
        public PlaceOrder(MCustomer customer, IProductBL iProductBL, ILocationBL iLocationBL, InventoryBL iInventory,ILineItem iline,IValidateService iValidate){
            mcustomer = customer;
            _iProductBL = iProductBL;
            this._iLocationBL = iLocationBL;
            this._IValidate = iValidate;
            this._iInventory = iInventory;
            this._iLineItem = iline;
        }
        private MOrders _openOrder;
        public void start()
        {
            MLocation store = SearchForStore();
            if(_openOrder == null){
                _openOrder = new MOrders{
                    Total = 0,
                    CustID = mcustomer.Id,
                    LocationID = store.Id
                };
                _openOrder.lineItems = new List<MLineItems>();
            }
            bool repeat = true;
            if(store != null){
                do{
                Console.WriteLine($"Welcome to the Chocolate Factory {store.Name}!");
                Console.WriteLine("Press 1 to view products to start ordering");
                Console.WriteLine("Press 2 to exit!");
                string input = Console.ReadLine();
                switch(input){
                    case "1":
                        PlaceOrderbyCustomer(store);
                    break;
                    case "2":
                        repeat = false;
                    break;
                    default:
                        Console.WriteLine("Please enter a valid selection");
                    break;
                }
                
                }while(repeat);
            }else{
                Console.WriteLine("Store not found in directory! please enter a valid name and address");
            }
        }
        
        private MLocation SearchForStore (){
            Console.WriteLine("Enter Store Name and Location for the store you want to put an order.");
            string name = _IValidate.ValidateString("Enter the name of store");
            string address = _IValidate.ValidateString("Enter the address of store");
            try{
                MLocation foundStore = _iLocationBL.GetStore(new MLocation(name, address));
                return foundStore;
            }catch(Exception ex){
                Console.WriteLine(ex.Message);
                return null;
            }
            
        }
        private void PlaceOrderbyCustomer(MLocation mlocation){
            try{
                List<MInventory> inventories = _iLocationBL.GetProductInStock(mlocation);
                int i = 1;
                foreach(MInventory inventory in inventories){
                    if(inventory.Quantity >0){
                        List<MProduct> listProducts = _iInventory.GetProductsInventory(inventory);
                        foreach (MProduct item in listProducts)
                        {   
                            Console.WriteLine($"{i++} : {item.ToString()}");
                        }
                    }
                    selectedInventory = inventory.StoreId; 
                }
                
                    selectProductByUser(selectedInventory, mlocation);
                    bool repeat = true;
                    do{
                        Console.WriteLine("Continue Shopping y/n");
                        string input = Console.ReadLine();
                        if(input.ToLower() == "n"){
                            repeat = false;
                        }else{
                            selectProductByUser(selectedInventory, mlocation);
                        }
                    }while(repeat);
                
            }catch(Exception ex){
                Console.WriteLine(ex.Message);
            }
        }
        private MProduct selectProductByUser(int storeId, MLocation mLocation){
            string name = _IValidate.ValidateString("Please enter product name to shop");
            double price = _IValidate.ValidateDouble("Please enter price of product");
            int quantity = _IValidate.ValidateInt("Please enter quantity");
            // quantityinp = quantity;
            MProduct ProSelected = new MProduct(name, price);
            try{
                MProduct foundPro = _iProductBL.searchAProduct(ProSelected);
                if(foundPro != null){
                    MLineItems lineI = new MLineItems(foundPro.Barcode, quantity);
                    lineI.product = foundPro;
                    _openOrder.lineItems.Add(lineI);
                    _openOrder.UpdateTotal();
                    Console.WriteLine($"Your total is: {_openOrder.Total}");
                    _iLineItem.ItemToAddInOrders(_openOrder);
                }
                return foundPro;
            }catch(Exception ex){
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}