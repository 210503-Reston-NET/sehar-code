using Models;
using System.Collections.Generic;
using SDL;
namespace SBL
{
    public class CustomerBL:ICustomerBL
    {
        private IRepository _repo;
        public CustomerBL(IRepository repo){
            _repo = repo;
        }
        public List<MCustomer> GetAllCustomers(){
            return _repo.GetAllCustomers();
        }
        public MCustomer AddCustomer(MCustomer customer){
            return _repo.AddCustomer(customer);
        }
    }
}