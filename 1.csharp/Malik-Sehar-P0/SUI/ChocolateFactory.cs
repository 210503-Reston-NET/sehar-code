using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SBL;
using SDL;
using SDL.Entities;

namespace SUI
{
    public class ChocolateFactory
    {
        public static IChocolateFactory mainMenu(string menuType){

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
            
            switch(menuType.ToLower()){
                case "main":
                    return new CustomerUI();
                case "customers":
                    return new SubCustomer(new CustomerBL(new RepoDB(context)), new ValidateService());
                case "products":
                    return new ProductUI();
                case "location":
                    return new LocationUI();
                default:
                    return null;
            }
        }
    }
}