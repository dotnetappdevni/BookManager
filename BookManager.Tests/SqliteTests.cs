using BookManager.Models;
using System.Collections.Generic;
using Moq;
using NUnit;
using BookManager.Services.Interfaces;
using RichardSzalay.MockHttp;
using BookManager.Domain;
using Microsoft.EntityFrameworkCore;
using BookManager.Services;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.Extensions.Options;
using Microsoft.Data.Sqlite;
using Castle.Components.DictionaryAdapter.Xml;
namespace BookManager.Tests
{
    public class BookingServicesTests : IDisposable 
    {
        private bool _useSqlite;

        private SqliteConnection _connection;
        private DbContextOptions _options;

    public BookingServicesTests()
    {
        _connection = new SqliteConnection("datasource=:memory:");
        _connection.Open();

        _options = new DbContextOptionsBuilder()
            .UseSqlite(_connection)
            .Options;
        using (var context = new ApplicationDBContext(_options))
            context.Database.EnsureCreated();
    }

        /// <summary>
        /// Books the check out should decrease inventory of the same book.
        /// </summary>
        [Test]
        public async Task Book_Added_ShouldBeCreated()
        {
            using (var context = new ApplicationDBContext(_options))
            {                

            }
        }


    /// <summary>
    /// Books the check out should decrease inventory of the same book.
    /// </summary>
    /// <param name="expectedCount">The expected count.</param>
    [TestCase(9)]
    public async Task Book_CheckOut_ShouldDecreaseByNumber(int expectedCount)
    {

        using (var context = new ApplicationDBContext(_options))
        {
            context.BookInventories.Add(new BookInventory
            {

                BookId = 4,
                BarCode = "1111",
                InventoryCount = 10,
                IsActive = true,
                IsDeleted = false,

            });
            await context.SaveChangesAsync();

            using (var context2 = new ApplicationDBContext(_options))
            {
                var service = new BookManagerServices(context2);
                int bookId = 4;
                int customerId = 10;
                string barCode = "1111";

                // ACT
                var act = service.CheckOut(customerId, bookId, barCode, 7);


                // Assert
                Assert.AreEqual(act.Data, expectedCount);
            }
        }

    }

        public void Dispose()
        {
            _connection.Close();
        }


        public void UseSqlite()
        {
            throw new NotImplementedException();
        }
        public async Task<ApplicationDBContext> GetDbContext()
        {
            DbContextOptionsBuilder builder = new DbContextOptionsBuilder();
            if (_useSqlite)
            {
                // Use Sqlite DB.
                builder.UseSqlite("DataSource=:memory:", x => { });
            }
            else
            {

            }

            var dbContext = new ApplicationDBContext(builder.Options);
            if (_useSqlite)
            {
                // SQLite needs to open connection to the DB.
                // Not required for in-memory-database and MS SQL.
                await dbContext.Database.OpenConnectionAsync();
            }

            await dbContext.Database.EnsureCreatedAsync();

            return dbContext;
        }

    }


}