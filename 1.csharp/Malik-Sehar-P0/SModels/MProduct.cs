using System.Collections.Generic;
namespace Models
{
    public class MProduct
    {
        public MProduct(string name, double price){
            this.Name = name;
            this.Price = price;
        }
        public MProduct(){
            
        }
        public int Id {get;}
        public string Name {get; set;}
        public double Price {get; set;}
        public string Barcode {get; set;}

        public List<MLocation> MLocation {get; set;}

        public override string ToString()
        {
            return $"Product Name: {Name}\n Price: {Price}";
        }
        public bool Equals(MProduct product)
        {
            return this.Name.Equals(product.Name) && this.Price.Equals(product.Price);
        }
    }
}