namespace Models
{
    public class MLocation
    {
        public MLocation(string name, string address){
            this.Name = name;
            this.Address = address;
        }
        public int Id {get;}
        public string Name {get; set;}

        public string Address {get; set;}

        public override string ToString()
        {
            return $"ID: {Id} \n Store Name: {Name}\n Address: {Address}";
        }
    }
}