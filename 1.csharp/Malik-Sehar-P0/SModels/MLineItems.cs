namespace SModels
{
    public class MLineItems
    {
        public MLineItems(int proId, int orderId, string quantity){
            this.ProId = proId;
            this.OrderID = orderId;
            this.Quantity = quantity;
        }
        public MLineItems(){}
        public int Id {get;}
        public int ProId {get; set;}
        public int OrderID {get; set;}
        public string Quantity {get; set;}
    }
}