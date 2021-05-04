using System;
using RRModel;
namespace RRUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurants goodTaste = new Restaurants("Good Taste", "Lahore", "Punjab");
            goodTaste.Review = new Review {
                Rating = 5,
                Description = "A M A Z I N G"
            };
            Console.WriteLine(goodTaste.ToString());
        }
    }
}
