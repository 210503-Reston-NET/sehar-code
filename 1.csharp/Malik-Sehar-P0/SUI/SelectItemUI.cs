using System;
using System.Collections.Generic;
using Models;
namespace SUI
{
    public class SelectItemUI
    {
        public static MProduct start(List<MProduct> objects){
            string input;
            bool repeat = true;
            do{
                Console.WriteLine("Select a Product!");
                Console.WriteLine("[0] Exit");
                int i = 1;
                foreach (object item in objects)
                {
                    Console.WriteLine("[{0}] {1}", i++, item.ToString());
                }
                input = Console.ReadLine();
                if(input == "0"){
                    repeat = false;
                }
            }while(repeat);
            int selection = int.Parse(input);
            MProduct retVal =  objects[selection-1];
            return retVal;
        }
    }
}