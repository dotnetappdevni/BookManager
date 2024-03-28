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

        List<Book> GetById(int id);

        BookManagerErrorObject Add(Book book);

        BookManagerErrorObject CheckOut(int customerId, int bookId, string barCode, int returnDateInterval);

        BookManagerErrorObject Delete(Book book);
      
        BookManagerErrorObject Return(int customerId, string barCode, DateTime dateReturned);

    }
}
