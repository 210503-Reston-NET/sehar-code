namespace Models
{
    public class MProduct
    {
        public MProduct(int id, string title, string description, double price, int quatity){
            this.Title = title;
            this.Description = description;
            this.Price = price;
            this.Quantity = quatity;
        }
        public MProduct(){
            
        }
        public int Id {get; set;}
        public string Title {get; set;}
        public string Description {get; set;}
        public double Price {get; set;}

        public double Quantity{get; set;}

        public MLocation MLocation {get; set;}

        public override string ToString()
        {
            return $"Product ID: {Id} \n Product title: {Title} \n Product Description: {Description} \n Product Price {Price} \n Product Quatity: {Quantity}";
        }
        public bool Equals(MProduct product)
        {
            return this.Id.Equals(product.Id) && this.Title.Equals(product.Title) && this.Description.Equals(product.Description) && this.Price.Equals(product.Price) && this.Quantity.Equals(product.Quantity);
        }
    }
}