using System;
using Models;
namespace SUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // ICustomer customer = new CustomerUI();
            // customer.start();
            IProduct product = new ProductUI();
            product.start();
        }
    }
}
