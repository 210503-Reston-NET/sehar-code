using System;
using RRModel;
using System.Collections.Generic;
namespace RRUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurants goodTaste = new Restaurants("Good Taste", "Lahore", "Punjab");
            goodTaste.Reviews = new List<Review> {
                new Review{
                    Rating = 5,
                    Description = "A M A Z I N G",
                },
                new Review{
                    Rating = 5,
                    Description = "Good food for cheap",
                }
            };
            
            foreach (Review review in goodTaste.Reviews){
                Console.WriteLine(review.ToString());
            }
        }
    }
}
