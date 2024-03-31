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
            return _dbContext.Books.Where(w => w.IsDeleted == false && w.Id == id && w.IsActive == true).ToList();
        }

        /// <summary>
        /// Adds the specified book.
        /// </summary>
        /// <param name="book">The book.</param>
        /// <returns>BookManagerErrorObject custom error object</returns>
        public BookManagerErrorObject Add(Book book)
        {
            BookManagerErrorObject bookManagerErrorObject = new BookManagerErrorObject();
            try
            {
                _dbContext.Add(book);
                List<string> errors = new List<string>();
                errors.Add("Book Addedd Successfully");
                bookManagerErrorObject = new BookManagerErrorObject { Succeeded = true, Errors = null, Exception = null };
                _dbContext.SaveChanges();
                _logger.Info($"Book successfully added to system {book.Title}");

            }
            catch (Exception ex)
            {
                List<string> errors = new List<string>();
                errors.Add(ex.Message);
                bookManagerErrorObject = new BookManagerErrorObject { Succeeded = false, Errors = errors, Exception = ex };
                _logger.Error("Exception has occurred in the bookmanager service Add Book method ", ex);

            }
            return bookManagerErrorObject;
        }

        /// <summary>
        /// Updates the book.
        /// </summary>
        /// <param name="book">The book.</param>
        /// <returns>BookManagerErrorObject custom error object</returns>
        public BookManagerErrorObject UpdateBook(Book book)
        {
            BookManagerErrorObject bookManagerErrorObject = new BookManagerErrorObject();
            _logger.Info($"Enter the update book method {book.Id}");
            var bookToUpdate = _dbContext.Books.Where(w => w.Id == book.Id && w.IsDeleted == false && w.IsActive == true).FirstOrDefault();
            if (bookToUpdate != null)
            {
                _dbContext.Entry(book).CurrentValues.SetValues(book);
                try
                {
                    _dbContext.SaveChanges();
                    bookManagerErrorObject.Errors.Add($"Book has been updated successfully {book.Id}");
                    bookManagerErrorObject.Succeeded = true;
                    _logger.Info($"Book has been updated successfully {book.Id}");
                    _logger.Info($"Exited the update book method {book.Id}");
                }
                catch (Exception ex)
                {
                    bookManagerErrorObject.Errors.Add("Exception occurred in Update Book Method ");
                    bookManagerErrorObject.Exception = ex;
                    bookManagerErrorObject.Succeeded = false;
                }

            }
            return bookManagerErrorObject;


        }
        /// <summary>
        /// Delete A Book from the Book Manager
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public BookManagerErrorObject Delete(Book book)
        {
            BookManagerErrorObject bookManagerErrorObject = new BookManagerErrorObject();

            var bookToDelete = _dbContext.Books.FirstOrDefault(w => w.Id == book.Id);
            if (bookToDelete != null)
            {
                _dbContext.Books.Remove(bookToDelete);

                try
                {
                    _dbContext.SaveChanges();
                    List<string> messages = new List<string>();
                    messages.Add("Book Deleted successfully");
                    bookManagerErrorObject = new BookManagerErrorObject { Succeeded = true, Messages = messages, Errors = null, Exception = null };
                    _logger.Info($"Book Deleted successfully {book.Title}");


                }
                catch (System.Exception ex)
                {
                    List<string> errors = new List<string>();
                    errors.Add(ex.Message);
                    bookManagerErrorObject = new BookManagerErrorObject { Succeeded = false, Errors = errors, Exception = ex };
                    _logger.Info($"Book Deleted Failed {book.Title} Book Id={book.Id}");

                }

            }
            return bookManagerErrorObject;

        }

        /// <summary>
        /// Checks the in the book for the customer based of book id 
        /// </summary>
        /// <param name="customerId">The customer identifier.</param>
        /// <param name="bookId">The book identifier.</param>
        /// <param name="barCode">The bar code.</param>
        /// <param name="returnedDate">The returned date.</param>
        /// <returns></returns>
        public BookManagerErrorObject CheckIn(int customerId, int bookId, string barCode, DateTime returnedDate)
        {
            BookManagerErrorObject bookManagerErrorObject = new BookManagerErrorObject();

            var customerLoanedBooks = _dbContext.BooksLoaned
                      .Where(w => w.BarCode == barCode && w.CustomerId == customerId && w.IsActive == true && w.IsDeleted == false)
                      .ToList();

            var bookInventory = _dbContext.BookInventories
           .FirstOrDefault(w => w.BarCode == barCode && w.BookId == bookId && w.IsActive == true && w.IsDeleted == false);

            // if there is only one inventory count left we wish to remove that object.
            if (bookInventory.InventoryCount <= 1)
            {
                var customerLoanedBook = _dbContext.BooksLoaned
                     .Where(w => w.BarCode == barCode && w.CustomerId == customerId && w.IsActive == true && w.IsDeleted == false).FirstOrDefault();
                if (customerLoanedBook != null)
                {
                    //as this is the last book of the same type by the customer soft delete the record and set the is returned flag to true
                    //other wise we just want to add it back into the inventory
                    customerLoanedBook.DateReturned = returnedDate;
                    customerLoanedBook.IsActive = false;
                    customerLoanedBook.IsDeleted = true;
                    customerLoanedBook.IsReturned = true;
                    try
                    {
                        bookInventory.InventoryCount++;
                        bookInventory.DateModified = DateTime.Now;
                        try
                        {
                            _dbContext.SaveChanges();
                            bookManagerErrorObject.Messages.Add($"Successfully increased inventory and checked in book {bookId} for customer {customerId}");
                        }
                        catch (Exception ex)
                        {
                            _logger.Info($"Exception occurred on check in of a book {bookId} for customer {customerId} increasing inventory count");
                            bookManagerErrorObject.Errors.Add("Failed to increase inventory count");
                            bookManagerErrorObject.Succeeded = false;

                        }
                        _dbContext.SaveChanges();
                        bookManagerErrorObject.Messages.Add("Book successfully checked in");
                        bookManagerErrorObject.Succeeded = true;

                    }
                    catch (Exception ex)
                    {
                        _logger.Info($"Exception occurred on check in of a book {bookId} for customer {customerId}");
                        bookManagerErrorObject.Errors.Add("Exception occurred on check in of book");
                        bookManagerErrorObject.Succeeded = false;
                        bookManagerErrorObject.Exception = ex;
                    }

                }
            }
            else
            {
                bookInventory.InventoryCount++;
                bookInventory.DateModified = DateTime.Now;
                try
                {
                    _dbContext.SaveChanges();
                }
                catch (Exception ex)
                {
                    _logger.Info($"Exception occurred on check in of a book {bookId} for customer {customerId}");

                    bookManagerErrorObject.Errors.Add($"Reducing Inventory count failed for customer {customerId} and book id {bookId}");
                    bookManagerErrorObject.Succeeded = false;
                    bookManagerErrorObject.Exception = ex;
                }

            }
            return bookManagerErrorObject;
        }

        /// <summary>
        /// Searches to see if the book can be checked out and if there is suffient inventory
        /// Also checks to see if the customer has already the same book checked out already.
        /// </summary>
        /// <param name="book"></param>
        /// <returns>returns a BookManagerErrorObject object with details of success or failure</returns>
        public BookManagerErrorObject CheckOut(int customerId, int bookId, string barCode, int returnDateInterval)
        {
            BookManagerErrorObject bookManagerErrorObject = new BookManagerErrorObject();

            var bookInventory = _dbContext.BookInventories
                .FirstOrDefault(w => w.BarCode == barCode && w.BookId == bookId && w.IsActive == true && w.IsDeleted == false);

            if (bookInventory != null)
            {
                // Check if the book is in stock to give out.
                if (bookInventory.InventoryCount > 0)
                {
                    var customerLoanedBooks = _dbContext.BooksLoaned
                        .Where(w => w.BarCode == barCode && w.CustomerId == customerId && w.IsActive == true && w.IsDeleted == false)
                        .ToList();

                    if (customerLoanedBooks.Any())
                    {
                        bookManagerErrorObject.Succeeded = false;
                        bookManagerErrorObject.Errors.Add("Customer already has checked out this book. Please ask them to return it.");
                    }
                    else
                    {
                        // Update inventory count.

                        bookInventory.InventoryCount = bookInventory.InventoryCount - 1;
                        _dbContext.SaveChanges();
                        var customer = _dbContext.Customers.FirstOrDefault();
                        // Add book loan entry.
                        var newLoan = new BooksLoaned
                        {

                            BarCode = barCode,
                            BookId = bookId,
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
                            bookManagerErrorObject.Succeeded = true;
                            bookManagerErrorObject.Messages.Add("Check Out Completed Successfully");
                            bookManagerErrorObject.Data = bookInventory.InventoryCount;
                        }
                        catch (Exception ex)
                        {
                            bookManagerErrorObject.Succeeded = false;
                            bookManagerErrorObject.Exception = ex;
                        }
                    }
                }
            }
            else
            {
                bookManagerErrorObject.Succeeded = false;
                bookManagerErrorObject.Errors.Add("Book not found in inventory.");
            }

            return bookManagerErrorObject;
        }
   
    }
}
