using SBL;
using System.Collections.Generic;
using Models;
using System;
namespace SUI
{
    public class SubCustomer: IChocolateFactory
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
            if(customers.Count == 0){
                Console.WriteLine("There is no Customer, Please add one.");
            }else{
                foreach (MCustomer customer in customers)
                {
                    Console.WriteLine(customer.ToString());
                }
            }
            
        }
        private void AddACustomer(){
            Console.WriteLine("Add Customer Details!");
            string Name = _ivalidateService.ValidateString("Enter Customer's Name:");
            string PhoneNo = _ivalidateService.ValidateString("Enter Customer's PhoneNo:");
            string Address = _ivalidateService.ValidateString("Enter Customer's Address:");
            MCustomer customer = new MCustomer(Name, PhoneNo, Address);

            try{
                MCustomer createdCustomer = _iCustomerBL.AddCustomer(customer);
                Console.WriteLine(createdCustomer.ToString());
            }catch(Exception ex){
                Console.WriteLine(ex.Message);
            }
        }
    }
}