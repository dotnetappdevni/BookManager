using BookManager.Domain;
using BookManager.Models;
using BookManager.Services.Interfaces;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace BookManager.Services
{
    public class BookManagerServices : IBookManagerServices
    {
        IBookManagerServices _ibookManagerServices;
        private readonly ApplicationDBContext _dbContext;
        public BookManagerServices(ApplicationDBContext dbContext)

        {
            _dbContext = dbContext;
        }

        public List<Book> GetAll()
        {
            return _dbContext.Books.Where(w => w.IsDeleted == false && w.IsActive == true).ToList();
        }
        public int? ChecKIn(Book book)
        {
            var bookToCheckIn = _dbContext.BookInventories.FirstOrDefault(x => x.BarCode == book.BarCode);
            if (bookToCheckIn != null)
            {

                bookToCheckIn.InventoryCount--;
                _dbContext.SaveChanges();
            }
            return _dbContext.BookInventories.FirstOrDefault(x => x.BarCode == book.BarCode).InventoryCount;
        }

        public BookManagerErrorObject Add(Book book)
        {
            BookManagerErrorObject errorObject = new BookManagerErrorObject();
            try
            {
                _dbContext.Add(book);
                List<string> errors = new List<string>();
                errors.Add("Book Saved Succesfully");
                errorObject = new BookManagerErrorObject { Succeeded = true, Errors = null, Exception = null };
                _dbContext.SaveChanges();

            }
            catch (Exception ex)
            {
                List<string> errors = new List<string>();
                errors.Add(ex.Message);
                errorObject = new BookManagerErrorObject { Succeeded = false, Errors = errors, Exception = ex };


            }
            return errorObject;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public BookManagerErrorObject Delete(Book book)
        {
            BookManagerErrorObject errorObject = new BookManagerErrorObject();

            var bookToDelete = _dbContext.Books.FirstOrDefault(w => w.Id == book.Id);
            if (bookToDelete != null)
            {
                _dbContext.Books.Remove(bookToDelete);

                try
                {
                    _dbContext.SaveChanges();
                    List<string> messages = new List<string>();
                    messages.Add("Book Deleted Succesfully");
                    errorObject = new BookManagerErrorObject { Succeeded = true,Messages= messages, Errors = null, Exception = null };

                }
                catch (System.Exception ex)
                {
                    List<string> errors = new List<string>();
                    errors.Add(ex.Message);
                    errorObject = new BookManagerErrorObject { Succeeded = false, Errors = errors, Exception = ex };

                }

            }
            return errorObject;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Update()
        {
            throw new System.NotImplementedException();
        }


        /// <summary>
        /// Searches to see if the book can be checked out and if there is suffient inventory
        /// Also checks to see if the customer has already the same book checked out already.
        /// </summary>
        /// <param name="book"></param>
        /// <returns>returns a BookManagerErrorObject object with details of success or failure</returns>
        public BookManagerErrorObject CheckOut(int customerId, Book book, int returnDateInterval)
        {
            BookManagerErrorObject errorObject = new BookManagerErrorObject();

            var bookInventory = _dbContext.BookInventories
                .FirstOrDefault(w => w.BarCode == book.BarCode && w.IsActive == true && !w.IsDeleted == false);

            if (bookInventory != null)
            {
                // Check if the book is in stock to give out.
                if (bookInventory.InventoryCount > 0)
                {
                    var customerLoanedBooks = _dbContext.BooksLoand
                        .Where(w => w.BarCode == book.BarCode && w.CustomerId == customerId && w.IsActive==true && w.IsDeleted==false)
                        .ToList();

                    if (customerLoanedBooks.Any())
                    {
                        errorObject.Succeeded = false;
                        errorObject.Errors.Add("Customer already has checked out this book. Please ask them to return it.");
                    }
                    else
                    {
                        // Update inventory count.
                        bookInventory.InventoryCount--;
                        _dbContext.SaveChanges();

                        // Add book loan entry.
                        var newLoan = new BooksLoand
                        {
                            BarCode = book.BarCode,
                            CustomerId = customerId,
                            DateBorrowed = DateTime.Now,
                            DueDate = DateTime.Today.AddDays(returnDateInterval),
                            Status = (int)Enums.BookstatusEnuum.Loaned,
                            IsActive = true,
                            IsDeleted = false
                        };
                        _dbContext.BooksLoand.Add(newLoan);

                        try
                        {
                            _dbContext.SaveChanges();
                            errorObject.Succeeded = true;
                            errorObject.Messages.Add("Check Out Completed Successfully");
                        }
                        catch (Exception ex)
                        {
                            errorObject.Succeeded = false;
                            errorObject.Exception = ex;
                        }
                    }
                }
            }
            else
            {
                errorObject.Succeeded = false;
                errorObject.Errors.Add("Book not found in inventory.");
            }

            return errorObject;
        }

    }
}
