namespace SModels
{
    public class MInventory
    {
        public MInventory(int storeId, int ProId, string quantity){
            this.StoreId = storeId;
            this.ProductId = ProId;
            this.Quantity = quantity;
        }
        public MInventory (){}
        public int Id {get;}
        public int StoreId {get; set;}

        public int ProductId {get; set;}
        public string Quantity {get; set;}
    }
}