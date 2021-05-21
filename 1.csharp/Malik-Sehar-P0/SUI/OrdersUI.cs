using System;
using Models;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SBL;
using SDL;
using SDL.Entities;

namespace SUI
{
    public class OrdersUI:IChocolateFactory
    {
        MCustomer mcustomer = new MCustomer(); 
        public OrdersUI(MCustomer customer){
            mcustomer = customer;
        }
        public void start(){
            bool repeat = true;
            var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

            //setting up my db connection 
            string connectionString = configuration.GetConnectionString("chocolate_factory");
            DbContextOptions<chocolatefactoryContext> options = new DbContextOptionsBuilder<chocolatefactoryContext>()
            .UseSqlServer(connectionString)
            .Options;
            var context = new chocolatefactoryContext(options);
            do{
                Console.WriteLine("Press 1 To Place an Order");
                Console.WriteLine("Press 2 To Go back");
                string input = Console.ReadLine();
                switch(input){
                    case "1":
                        IChocolateFactory goToPlaceOrder = new PlaceOrder(mcustomer, new ProductBL(new RepoDB(context)), new LocationBL(new RepoDB(context)), new InventoryBL(new RepoDB(context)),new LineItemBL(new RepoDB(context)), new ValidateService());
                        goToPlaceOrder.start();
                    break;
                    case "2":
                        repeat = false;
                    break;
                    default:
                        Console.WriteLine("Please select a Valid Option");
                    break;
                }
            }while(repeat);
        }
    }
}