using BookManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager.Services.Interfaces
{
    public interface IBookManagerServices
    {

        List<Book> GetAll();
        BookManagerErrorObject Add(Book book);

        BookManagerErrorObject Delete(Book book);

        BookManagerErrorObject CheckOut(int customerId, Book book, int returnDateInterval);


    }
}
