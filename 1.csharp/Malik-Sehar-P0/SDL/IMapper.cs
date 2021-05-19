using Entity = SDL.Entities;
using Models;
namespace SDL
{
    /// <summary>
    /// To parse entities from DB to models used in BL and vice versa 
    /// </summary>
    public interface IMapper
    {
        MProduct ParseProduct(Entity.Product product);
        Entity.Product ParseProduct(MProduct product);
        MLocation ParseLocation(Entity.StoreFront store);
        Entity.StoreFront ParseLocation(MLocation mLocation);
        MCustomer ParseCustomer(Entity.Customer customer);
        Entity.Customer ParseLocation(MCustomer customer);
        MLineItems ParseLineItem(Entity.LineItem lineItem);
        Entity.LineItem ParseLineItem(MLineItems lineItems);
        MInventory ParseInventory(Entity.LineItem inventory);
        Entity.Inventory ParseInventory(MLineItems inventory);

        MOrders ParseOrder(Entity.Order order);
        Entity.Order ParseOrder(MOrders orders);
    }
}