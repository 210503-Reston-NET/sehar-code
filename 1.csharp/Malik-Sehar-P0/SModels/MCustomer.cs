namespace Models
{
    public class MCustomer
    {
        public MCustomer(int id, string firstname, string lastname){
            this.Id = id;
            this.FirstName = firstname;
            this.LastName = lastname;
        }
        public MCustomer(){
            
        }
        public int Id {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}

        public override string ToString()
        {
            return $"Customer ID: {Id} \n Customer Name: {FirstName} {LastName}";
        }
    }
}