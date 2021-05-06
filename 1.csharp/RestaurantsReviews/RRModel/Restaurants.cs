/// <summary>
    /// namespace for the models/custom data structure involved in the restaurant reviews
    /// </summary>
using System.Collections.Generic;
namespace RRModel
{
    /// <summary>
    /// Data structure used to define a restaurant
    /// </summary>
    public class Restaurants
    {
       //class members
       //1. constructors: use this to create the instance of the class
       //2. Fields: define the charactristics of a class
       //3. Methods: define the behavior of a class
       //4. Properties: also known as smart fields, are accessor method used to access private backing fields.
       //*Note that the properties are the analague to java getter and setter
       //property naming convension use pascal class.

    public Restaurants (string Name, string City, string State){
        this.Name = Name;
        this.City = City;
        this.State = State;
    }
    public Restaurants(){

    }

        public string Name {get;}
        public string State{get;}
        public string City {get;}
        public List<Review> Reviews{get; set;}

        public override string ToString(){
            return $" Name: {Name} \n Location: {City}, {State}";
        }
    }

}