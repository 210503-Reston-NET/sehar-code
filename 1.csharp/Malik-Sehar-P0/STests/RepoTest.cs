using Microsoft.EntityFrameworkCore;
using Entity = SDL.Entities;
using Xunit;
using SDL;
namespace STests
{
    /// <summary>
    /// When Unit test DB Note that you need to install the Mcrosoft.EntityFrameworkCore.Sqlite
    /// package.Sqlite has features that lets you create an in memory rdb.
    /// </summary>
    public class RepoTest
    {
        private readonly DbContextOptions<Entity.chocolatefactoryContext> options;
        //Xunit creates new instances of classes, you need to make sure that you seed your DB
        //for each class
        public RepoTest(){
            options = new DbContextOptionsBuilder<Entity.chocolatefactoryContext>().UseSqlite("Filename=Test.db").Options;
            seed();
        }
        [Fact]
        public void GetAllCustomerShouldReturnAllCustomer(){
            using(var context = new Entity.chocolatefactoryContext(options)){
                //Arrange
                IRepository _repo = new RepoDB(context);
                //Act
                var customers = _repo.GetAllCustomers();
                //Assert
                Assert.Equal(2, customers.Count);
            }
        }
        private void seed(){
            //this is an example of a using block
            using(var context = new Entity.chocolatefactoryContext(options)){
                context.Database.EnsureCreated();
                context.Database.EnsureDeleted();
                context.Customers.AddRange(
                    new Entity.Customer{
                        Id = 1,
                        CustomerName = "Sehar",
                        PhoneNum = "345678",
                        CustomerAddress = "Reno"
                    },
                    new Entity.Customer{
                        Id = 2,
                        CustomerName = "Mehak",
                        PhoneNum = "456789",
                        CustomerAddress = "Fernley"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}