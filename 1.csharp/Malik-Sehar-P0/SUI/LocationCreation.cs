using System;
using System.Collections.Generic;
using SBL;
using Models;
namespace SUI
{
    public class LocationCreation : IChocolateFactory
    {
        private ILocationBL _iLocation;
        private IValidateService _iValidate;
        public LocationCreation(LocationBL locationBL, IValidateService iValidate){
            _iLocation = locationBL;
            _iValidate = iValidate;
        }
        public void start()
        {
            bool repeat = true;
            do{ 
                Console.WriteLine("Press 1 to view a Location!");
                Console.WriteLine("Press 0 to Exit!");
                string input = Console.ReadLine();
                switch(input){
                    case "1":
                        //View List of Locations
                        ViewLocation();
                    break;
                    case "0":
                        repeat = false;
                    break;
                    default:
                        Console.WriteLine("Enter a right value!");
                    break;
                }
            }while(repeat);
        }
        private void ViewLocation(){
            List<MLocation> mLocations = _iLocation.GetAllLocation();
            foreach (MLocation location in mLocations)
            {  
                Console.WriteLine(location.ToString());
            }
        }
    }
}