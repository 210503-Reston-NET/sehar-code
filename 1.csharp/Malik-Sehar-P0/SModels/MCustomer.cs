namespace Models
{
    public class MCustomer
    {
        public MCustomer(string name, string phoneNo, string address){
            this.Name = name;
            this.PhoneNo = phoneNo;
            this.Address = address;
        }
        public MCustomer(){
            
        }
        public int Id {get;}
        public string Name {get; set;}

        public string PhoneNo {get; set;}
        public string Address {get; set;}

        public override string ToString()
        {
            return $"Customer ID: {Id} \n Customer Name: {Name} \n Address: {Address}\n PhoneNo: {PhoneNo}";
        }
    }
}