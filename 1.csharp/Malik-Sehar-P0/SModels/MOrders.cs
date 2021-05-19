using System;
using System.Collections.Generic;
namespace Models
{
    public class MOrders
    {
        public readonly DateTime date;
        public MOrders(double total, int custId, int locationId){
            this.date = DateTime.Now;
            this.Total = total;
            this.CustID = custId;
            this.LocationID = locationId;
        }
        //Chaining Constructor
        public MOrders(int id,string displayDate, double total, int custId, int locationId) : this(total, custId,locationId)
        {
            this.Id = id;
        }
        public MOrders(){}
        public int Id {get;}
        public double Total {get; set;}
        public int CustID {get; set;} 
        public int OrderID {get; set;}
        public int LocationID {get; set;}
        public List<MCustomer> customers {get; set;}
        public List<MLocation> storeFront {get; set;}
        public List<MLineItems> lineItems {get; set;}
        public void UpdateTotal()
        {
            if(this.lineItems is null) this.Total = 0.0;
            double total = 0.0;
            foreach(MLineItems item in this.lineItems)
            {
                total += item.product.Price * item.Quantity;
            }
            this.Total = Math.Round(total, 2);
        }
    }
}