using BookManager.DAL;
using BookManager.Models;
using BookManager.Services.Interfaces;

using Microsoft.Identity.Client;
using Microsoft.VisualBasic;
using NLog;
using System.Collections.Generic;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace BookManager.Services
{
    public class BookManagerServices : IBookManagerServices
    {
        IBookManagerServices _ibookManagerServices;
        private readonly ApplicationDBContext _dbContext;
        private static readonly NLog.Logger _logger = LogManager.GetCurrentClassLogger();
        public BookManagerServices()
        {

        }
        public BookManagerServices(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;             
        }

        public List<Book> GetAll()
        {
            return _dbContext.Books.Where(w => w.IsDeleted == false && w.IsActive == true).ToList();
        }

        public List<Book> GetById(int id)
        {
            return _dbContext.Books.Where(w => w.IsDeleted == false && w.Id==id && w.IsActive == true).ToList();
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
                _logger.Error("Exception has occoured in the bookmanager service Add Book method ", ex);

            }
            return errorObject;
        }

        /// <summary>
        /// Delete A Book from the Book Manager
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
        /// Searches to see if the book can be checked out and if there is suffient inventory
        /// Also checks to see if the customer has already the same book checked out already.
        /// </summary>
        /// <param name="book"></param>
        /// <returns>returns a BookManagerErrorObject object with details of success or failure</returns>
        public BookManagerErrorObject CheckOut(int customerId,int bookId, string barCode, int returnDateInterval)
        {
            BookManagerErrorObject errorObject = new BookManagerErrorObject();

            var bookInventory = _dbContext.BookInventories
                .FirstOrDefault(w => w.BarCode == barCode && w.BookId== bookId && w.IsActive == true &&  w.IsDeleted == false);

            if (bookInventory != null)
            {
                // Check if the book is in stock to give out.
                if (bookInventory.InventoryCount > 0)
                {
                    var customerLoanedBooks = _dbContext.BooksLoaned
                        .Where(w => w.BarCode == barCode && w.CustomerId == customerId && w.IsActive==true && w.IsDeleted==false)
                        .ToList();

                    if (customerLoanedBooks.Any())
                    {
                        errorObject.Succeeded = false;
                        errorObject.Errors.Add("Customer already has checked out this book. Please ask them to return it.");
                    }
                    else
                    {
                        // Update inventory count.
                        
                        bookInventory.InventoryCount=bookInventory.InventoryCount-1;
                        _dbContext.SaveChanges();
                        var customer = _dbContext.Customers.FirstOrDefault();
                        // Add book loan entry.
                        var newLoan = new BooksLoaned
                        {
                           
                            BarCode = barCode,
                            BookId= bookId,                            
                            CustomerId = customerId,
                            DateBorrowed = DateTime.Now,
                            DueDate = DateTime.Today.AddDays(returnDateInterval),
                            Status = (int)Enums.BookstatusEnum.Loaned,
                            IsActive = true,
                            IsDeleted = false
                        };
                        _dbContext.BooksLoaned.Add(newLoan);

                        try
                        {
                            _dbContext.SaveChanges();
                            errorObject.Succeeded = true;
                            errorObject.Messages.Add("Check Out Completed Successfully");
                            errorObject.Data = bookInventory.InventoryCount;
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

        public BookManagerErrorObject Return(int customerId, string barCode, DateTime dateReturned)
        {
            BookManagerErrorObject errorObject= new BookManagerErrorObject();
            var booktoReturn = _dbContext.BooksLoaned.Where(w => w.CustomerId == customerId && w.BarCode == barCode && w.IsActive == true && w.IsDeleted == false).FirstOrDefault();
            if (booktoReturn != null)
            {
                booktoReturn.Status = (int)Enums.BookstatusEnum.Returned;
                booktoReturn.DateReturned = dateReturned;
                try
                {
                    _dbContext.SaveChanges();
                }
                catch (Exception ex)
                { 
                    errorObject.Exception= ex;
                    errorObject.Errors.Add("Error occoured in the return method in bookmanger service"); 
                    
                }

                var updateBookInventory = _dbContext.BookInventories.Where(w => w.BarCode == barCode && w.IsActive == true && w.IsDeleted == false).FirstOrDefault();
                if (updateBookInventory != null)
                {
                    updateBookInventory.InventoryCount++;
                    updateBookInventory.DateModified = dateReturned;
                    try
                    {
                       _dbContext.SaveChanges();
                       errorObject.Succeeded=true;
                       errorObject.Messages.Add("Book was sucesfull returned to the system");
                    } 
                    catch (Exception ex)
                    {
                       errorObject.Succeeded = false;
                       errorObject.Exception = ex;
                       errorObject.Errors.Add("Return a book failed please see exception");
                    }
                        
                }

            }
            return errorObject;
        }
    }
}
