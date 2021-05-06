using System.Collections.Generic;
using RRModel;
namespace RRDL
{
    /// <summary>
    /// Restaurant Reviews Static collection storage
    /// </summary>
    public class RRSCStorage
    {
        public static List<Restaurants> Restaurants = new List<Restaurants>(){
            new Restaurants("Good Taste", "Lahore", "Punjab")
        };
    }
}