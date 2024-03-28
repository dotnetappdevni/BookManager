using BookManager.Models;
using System.Collections.Generic;
using Moq;
using BookManager.Services.Interfaces;
using RichardSzalay.MockHttp;
namespace BookManager.Tests
{

    public class Tests
    {
        [SetUp]
        public void Setup()
        {
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