using Models;
using SDL.Entities;
using Entity = SDL.Entities;
namespace SDL
{
    public class StoreMapper : IMapper
    {
        
        public MProduct ParseProduct(Product product)
        {
            throw new System.NotImplementedException();
        }

        Product IMapper.ParseProduct(MProduct product)
        {
            throw new System.NotImplementedException();
        }

        public MLocation ParseLocation(StoreFront store)
        {
            throw new System.NotImplementedException();
        }

        public StoreFront ParseLocation(MLocation mLocation)
        {
            throw new System.NotImplementedException();
        }

        public MCustomer ParseCustomer(Customer customer)
        {
            throw new System.NotImplementedException();
        }

        public Customer ParseLocation(MCustomer customer)
        {
            throw new System.NotImplementedException();
        }

        public MLineItems ParseLineItem(LineItem lineItem)
        {
            throw new System.NotImplementedException();
        }

        LineItem IMapper.ParseLineItem(MLineItems lineItems)
        {
            throw new System.NotImplementedException();
        }

        public MInventory ParseInventory(LineItem inventory)
        {
            throw new System.NotImplementedException();
        }

        public Inventory ParseInventory(MLineItems inventory)
        {
            throw new System.NotImplementedException();
        }

        public MOrders ParseOrder(Order order)
        {
            throw new System.NotImplementedException();
        }

        public Order ParseOrder(MOrders orders)
        {
            throw new System.NotImplementedException();
        }
    }
}