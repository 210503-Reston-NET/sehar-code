using System;

namespace Models
{
    public class MOrders
    {
        public MOrders(string displayDate, double total, int custId, int locationId){
            this.DateCreated = displayDate;
            this.Total = total;
            this.CustID = custId;
            this.LocationID = locationId;
        }
        public MOrders(){}
        public int Id {get;}
        public string DateCreated { get; set; }
        public double Total {get; set;}
        public int CustID {get; set;} 
        public int LocationID {get; set;}
    }
}