using SBL;
using System.Collections.Generic;
using Models;
using System;
namespace SUI
{
    public class SubCustomer: ICustomer
    {
        private ICustomerBL _iCustomerBL;
        private IValidateService _ivalidateService;
        public SubCustomer(ICustomerBL icustomerBL, IValidateService validate){
            _iCustomerBL = icustomerBL;
            _ivalidateService = validate;
        }
        public void start(){
            bool repeat = true;
            do{
                Console.WriteLine("Press 1 to add a customer");
                Console.WriteLine("Press 2 to View a Customer");
                Console.WriteLine("Press 0 to Go Bacl!");
                string input = Console.ReadLine(); 
            switch(input){
                case "1":
                    AddACustomer();
                break;
                case "2":
                    ViewCustomers();
                break;
                case "0":
                    repeat = false;
                break;
                default:
                    Console.WriteLine("Please make a right selection!");
                break;
            }
            }while(repeat);
            
        }
        private void ViewCustomers(){
            List<MCustomer> customers = _iCustomerBL.GetAllCustomers();
            foreach (MCustomer customer in customers)
            {
                Console.WriteLine(customer.ToString());
            }
        }
        private void AddACustomer(){
            Console.WriteLine("Add Customer Details!");
            int id = 1;
            string firstName = _ivalidateService.ValidateString("Enter Customer's First Name:");
            string lastName = _ivalidateService.ValidateString("Enter Customer's Last Name:");

            MCustomer customer = new MCustomer(id,firstName, lastName);
            MCustomer createdCustomer = _iCustomerBL.AddCustomer(customer);
            Console.WriteLine(createdCustomer.ToString());
        }
    }
}