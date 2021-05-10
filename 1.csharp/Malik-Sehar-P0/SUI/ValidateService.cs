using System;
namespace SUI
{
    public class ValidateService: IValidateService
    {
        public double ValidateDouble(string prompt)
        {
            bool repeat = true;
            string response;
            double price;

            do{
                Console.WriteLine(prompt);
                response = Console.ReadLine();
                repeat = double.TryParse(response, out price);
                if(price <= 0){
                    Console.WriteLine("Please enter a Value greater than 0.");
                }else {
                    repeat = false;
                }
            }while(repeat);
            return price;
        }
        public int ValidateInt(string prompt)
        {
            bool repeat = true;
            string response;
            int price;

            do{
                Console.WriteLine(prompt);
                response = Console.ReadLine();
                repeat = int.TryParse(response, out price);
                if(price <= 0){
                    Console.WriteLine("Please enter a Value greater than 0.");
                }else {
                    repeat = false;
                }
            }while(repeat);
            return price;
        }


        public string ValidateString(string prompt){
        bool repeat = true;
        string response;
            do{
                Console.WriteLine(prompt);
                response = Console.ReadLine();
                repeat = string.IsNullOrWhiteSpace(response);
                if(repeat) Console.WriteLine("Please input a non empty string");
            }while(repeat);
        return response;
        }
    }
}