using System.Collections.Generic;
using System.Linq;
using Models;
using Entity = SDL.Entities;
using System;
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
                customer => new MCustomer(customer.Id, customer.CustomerName, customer.PhoneNum, customer.CustomerAddress)
            ).ToList();
        }
        public List<MLocation> GetAllLocation()
        {
            throw new System.NotImplementedException();
        }



        public List<MOrders> GetAllOrders()
        {
            // List<MOrders> allOrders = (
            //     from li in _context.LineItems join o in _context.Orders on li.OrderId equals o.Id join p in _context.Products on li.ProductId equals p.BarCode join c in _context.Customers on o.CustomerId equals c.Id join l in _context.StoreFronts on o.StoreFrontId equals l.Id where o.Id.Equals(li.OrderId) select new MLineItems{
            //         Quantity = li.Quantity,
            //         products = new MProduct()}).ToList();
            return null;
        }

        public List<MProduct> GetAllProductss()
        {
            return _context.Products.Select(
                product => new MProduct(product.BarCode, product.ProName, product.Price)
            ).ToList();
        }

        public MProduct GetAProduct(MProduct product)
        {
            Entity.Product found = _context.Products.FirstOrDefault(pro => pro.BarCode == product.Barcode && pro.ProName == product.Name && pro.Price == product.Price);
            if(found != null) return null;
            return new MProduct(found.BarCode, found.ProName, found.Price);
        }

        public MLocation GetAStore(MLocation location)
        {
            Entity.StoreFront found = _context.StoreFronts.FirstOrDefault(store => store.StoreName == location.Name && store.StoreAddress == location.Address);
            if(found == null) return null;
            return new MLocation(found.Id, found.StoreName, found.StoreAddress);
        }

        public List<MInventory> GetProductInStock(MLocation mLocation)
        {
            return _context.Inventories.Where(inv => inv.StoreId == mLocation.Id).Select(
                invent =>  new MInventory{
                    StoreId = invent.StoreId,
                    ProductId = invent.ProductId,
                    Quantity = invent.Quantity
                }
            ).ToList();
        }

        public List<MProduct> GetProductsInventory(MInventory inventory)
        {
            return _context.Products.Where(pro => pro.BarCode == inventory.ProductId).Select(
                prod =>
                new MProduct{
                    Barcode = prod.BarCode,
                    Name = prod.ProName,
                    Price = prod.Price      
                }
            ).ToList();
        }

        public void ItemToAdd(int id, List<MLineItems> lineItems)
        {
            foreach(MLineItems item in lineItems){
                Entity.LineItem line1 = _context.LineItems.Add(
                    new Entity.LineItem{
                        OrderId = id,
                        ProductId = item.ProId,
                        Quantity = item.Quantity
                    }
                ).Entity;
            }
            _context.SaveChanges();
        }

        public void ItemToAddInOrders(MOrders orders){
            Entity.Order newOrder = new Entity.Order
            {
                CustomerId = orders.CustID,
                StoreFrontId = orders.LocationID,
                Total = orders.Total
            };
            try{
                Entity.Order AddedOrder = _context.Orders.Add(newOrder).Entity;
                _context.SaveChanges();
                ItemToAdd(AddedOrder.Id, orders.lineItems);
            }catch(Exception ex){
                Console.WriteLine(ex.Message);
            }
        }

        public MCustomer searchACustomer(MCustomer customer)
        {
            Entity.Customer found = _context.Customers.FirstOrDefault(pro =>pro.PhoneNum == customer.PhoneNo);
            if(found == null) return null;
            return new MCustomer(found.CustomerName, found.PhoneNum, found.CustomerAddress);
        }

        public MProduct searchAProduct(MProduct mProduct)
        {
            Entity.Product found = _context.Products.FirstOrDefault(prod1 => prod1.ProName == mProduct.Name && prod1.Price == mProduct.Price); 
            if(found == null) return null;
            return new MProduct(found.BarCode, found.ProName, found.Price);
        }
        public MCustomer searchCustomer(MCustomer customer)
        {
            throw new NotImplementedException();
        }
    }
}