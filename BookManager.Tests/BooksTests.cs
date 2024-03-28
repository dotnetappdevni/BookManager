using BookManager.Models;
using System.Collections.Generic;
using Moq;
using NUnit;
using BookManager.Services.Interfaces;
using RichardSzalay.MockHttp;
using BookManager.Domain;
using Microsoft.EntityFrameworkCore;
using BookManager.Services;
namespace BookManager.Tests
{

    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// Test to ensure that the count of book inventory is decreased 
        /// by the booked checked out.
        /// </summary>
        [Test]
        public void Book_Checkout_ShouldDescreaseInventory()
        {
            var mockDbContext = new Mock<ApplicationDBContext>();
 
            var bookInventoryData = new List<BookInventory>
            {
                new BookInventory { BarCode = "12345", IsActive = true, IsDeleted = false, InventoryCount = 1 }
            }.AsQueryable();

            var mockBookInventorySet = new Mock<DbSet<BookInventory>>();
            mockBookInventorySet.As<IQueryable<BookInventory>>().Setup(m => m.Provider).Returns(bookInventoryData.Provider);
            mockBookInventorySet.As<IQueryable<BookInventory>>().Setup(m => m.Expression).Returns(bookInventoryData.Expression);
            mockBookInventorySet.As<IQueryable<BookInventory>>().Setup(m => m.ElementType).Returns(bookInventoryData.ElementType);
            mockBookInventorySet.As<IQueryable<BookInventory>>().Setup(m => m.GetEnumerator()).Returns(bookInventoryData.GetEnumerator());

            mockDbContext.Setup(m => m.BookInventories).Returns(mockBookInventorySet.Object);

            var bookLoanData = new List<BooksLoand>().AsQueryable();
            var mockBookLoanSet = new Mock<DbSet<BooksLoand>>();
            mockBookLoanSet.As<IQueryable<BooksLoand>>().Setup(m => m.Provider).Returns(bookLoanData.Provider);
            mockBookLoanSet.As<IQueryable<BooksLoand>>().Setup(m => m.Expression).Returns(bookLoanData.Expression);
            mockBookLoanSet.As<IQueryable<BooksLoand>>().Setup(m => m.ElementType).Returns(bookLoanData.ElementType);

            mockBookLoanSet.As<IQueryable<BooksLoand>>().Setup(m => m.GetEnumerator()).Returns(bookLoanData.GetEnumerator());

            var bookManager = new BookManagerServices(mockDbContext.Object);
            var book = new Book { BarCode = "12345" };
            int customerId = 1;
            int returnDateInterval = 7;

            var result = bookManager.CheckOut(customerId, book, returnDateInterval);
               var actual = result.Data.ToString();
            // Assert
            Assert.AreEqual(result.Succeeded,true);


        }
        //public async void Returns_ALLItems_FromGetAll()
        //{
        //    var mockHttp = new MockHttpMessageHandler();

        //    // Setup a respond for the user api (including a wildcard in the URL)
        //    mockHttp.When("http://localhost/api/user/*")
        //            .Respond("application/json", "{'name' : 'Test McGee'}"); // Respond with JSON

        //    // Inject the handler or client into your application code
        //    var client = mockHttp.ToHttpClient();

        //    // Act
        //    var response = await client.GetAsync("http://localhost/api/user/1234");
        //    var json = await response.Content.ReadAsStringAsync();

        //    var test = BooksData(); 
        //    Assert.Equals(1, 3);
        //}
        /// <summary>
        /// Test data for the books test.
        /// </summary>
        /// <returns> List<Book> A List of books</returns>
        public List<Book> BooksData()
        {
            List<Book> books = new List<Book>();
            books.Add(new Book { Id = 3, ISBN = "329-320-2392-1", BarCode = "1111", Title = "Star Trek - Beyond", Description = "After stopping off at Starbase Yorktown, a remote outpost on the fringes of Federation space, the USS Enterprise, halfway into their five-year mission, is destroyed by an unstoppable wave of unknown aliens.", IsDeleted = false, IsActive = true, DateCreated = DateTime.Now, DateModified = DateTime.Now, Type = 1, Price = 15.99m });
            books.Add(new Book
            {
                Id = 4,
                BarCode = "3333",
                ISBN = "978-0-671-56743-1",
                Title = "Star Trek - First Contact",
                Description = "The novelization of the \"First Contact\" film which also includes a behind-the-scenes look at the making of the film. Captain Pickard, Commander Riker, Lieutenant Commander Data and the rest of the crew must face their greatest foe, the half-organic, half-mechanical Borg..",
                IsDeleted = false,
                IsActive = true,
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now,
                Type = 1,
                Price = 10.99m
            });
            books.Add(
             new Book
             {
                 Id = 5,
                 BarCode = "4444",
                 ISBN = "978-1-84607-571-7",
                 Title = "Doctor Who: The Star Beast ",
                 Description = "Landing on Earth, the Doctor finds a stranded alien in need of protection – and is dragged headlong into the life of his old friend Donna Noble, knowing that if she ever remembers their time together, she will die…",
                 IsDeleted = false,
                 IsActive = true,
                 DateCreated = DateTime.Now,
                 DateModified = DateTime.Now,
                 Type = 1,
                 Price = 16.00m
             }
            );
            return books;


        }
    }
}