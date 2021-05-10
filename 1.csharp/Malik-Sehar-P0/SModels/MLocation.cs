namespace Models
{
    public class MLocation
    {
        public MLocation(int id, string address){
            this.Id = id;
            this.StoreAddress = address;
        }
        public int Id {get; set;}
        public string StoreAddress {get; set;}
    }
}