using System.Collections.Generic;
using System.Linq;
using Models;
using Entity = SDL.Entities;
namespace SDL
{
    public class RepoDB : IRepository
    {
        private Entities.chocolatefactoryContext _context;
        public RepoDB(Entities.chocolatefactoryContext context){
            this._context = context;
        }
        public MCustomer AddCustomer(MCustomer customer)
        {
            //this records the change in the cotext change tracker that we want to add this particular entity
           // to the db 
            _context.Customers.Add(
                new Entity.Customer
                {
                    CustomerName = customer.Name,
                    PhoneNum = customer.PhoneNo,
                    CustomerAddress = customer.Address
                }
            );
            //this persists the chnage to the database
            _context.SaveChanges();
            return customer;
        }

        public MProduct AddProduct(MProduct product)
        {
            throw new System.NotImplementedException();
        }

        public List<MCustomer> GetAllCustomers()
        {
            return _context.Customers
            .Select( 
                customer => new MCustomer(customer.CustomerName, customer.PhoneNum, customer.CustomerAddress)
            ).ToList();
        }

        public List<MLocation> GetAllLocation()
        {
            throw new System.NotImplementedException();
        }

        public List<MProduct> GetAllProducts()
        {
            throw new System.NotImplementedException();
        }

        public MProduct GetAProduct(MProduct product)
        {
            throw new System.NotImplementedException();
        }
    }
}