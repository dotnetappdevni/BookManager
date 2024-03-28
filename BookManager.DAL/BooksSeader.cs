using BookManager.Domain;
using BookManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager.DAL
{
    internal class BooksSeader
    {
        internal static void Initialize(ApplicationDBContext dbContext)
        {
            ArgumentNullException.ThrowIfNull(dbContext, nameof(dbContext));
            dbContext.Database.EnsureCreated();
            if (dbContext.Users.Any()) return;

            var books = new Book[]
            {
            new Book{Title="Star Trek",IsActive=true,IsDeleted=false }
            //add other users
            };

            foreach (var book in books)
                dbContext.Books.Add(book);

            dbContext.SaveChanges();
        }
    }
}
