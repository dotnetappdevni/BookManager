using BookManager.Domain;
using BookManager.Models;
using BookManager.Services.Interfaces;
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

            var bookToDelete = _dbContext.Books.FirstOrDefault(x => x.Id == book.Id);
            if (bookToDelete != null)
            {
                _dbContext.Books.Remove(bookToDelete);

                try
                {
                    _dbContext.SaveChanges();
                    List<string> errors = new List<string>();
                    errors.Add("Book Deleted Succesfully");
                    errorObject = new BookManagerErrorObject { Succeeded = true, Errors = null, Exception = null };

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
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public int? CheckOut(Book book)
        {
            var bookToCheckIn = _dbContext.BookInventories.FirstOrDefault(w => w.BarCode == book.BarCode);
            if (bookToCheckIn != null)
            {
                //check if the book is in stock to give out.
                var checkInventoryCount = _dbContext.BookInventories.Where(w => w.BarCode == book.BarCode).FirstOrDefault().InventoryCount;
                if (checkInventoryCount != 0)
                {
                    var inventoryToUpdate = _dbContext.BookInventories.Where(w => w.BarCode == book.BarCode).FirstOrDefault();
                    if (inventoryToUpdate != null)
                    {
                        inventoryToUpdate.InventoryCount--;
                        _dbContext.SaveChanges();
                    }


                }
               
            }
            return 1;

        }
    }

    }
