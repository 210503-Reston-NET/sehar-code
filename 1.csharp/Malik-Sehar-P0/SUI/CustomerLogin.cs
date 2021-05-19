using System;
using System.Collections.Generic;
using Models;
using SBL;

namespace SUI
{
    public class CustomerLogin: IChocolateFactory
    {
        
        private ICustomerBL _iCustomer;
        public CustomerLogin(ICustomerBL icustomer){
            _iCustomer = icustomer;
        }
        public void start(){
            bool repeat = true;
            do{
                Console.WriteLine("Enter your Phone Number to login");
                string input = Console.ReadLine();
                // searchCustomer(input);
                List<MCustomer> customers = _iCustomer.GetAllCustomers();
                foreach (MCustomer customer in customers)
                {
                    var phone =  customer.PhoneNo.ToString();
                    if(phone == input){
                        IChocolateFactory goToOrders = new OrdersUI(customer);
                        goToOrders.start();
                        repeat = false;
                    }
                }
            }while(repeat);
        }
    }
}