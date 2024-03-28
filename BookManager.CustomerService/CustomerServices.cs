using BookManager.CustomerService.Interface;
using BookManager.Domain;
using BookManager.Models;

namespace BookManager.CustomerService
{
    public class CustomerServices : ICustomerService
    {
        private readonly ApplicationDBContext _dbContext;
        public CustomerServices(ApplicationDBContext dBContext) 
        {
            _dbContext = dBContext;
        }
        public BookManagerErrorObject Add(Customer customer)
        {
            BookManagerErrorObject bookManagerErrorObject = new BookManagerErrorObject();
            _dbContext.Customers.Add(customer);
            try 
            {               
                _dbContext.SaveChanges();
                bookManagerErrorObject.Succeeded = true;
            }
            catch (Exception ex)
            {
                bookManagerErrorObject.Succeeded = false;
                bookManagerErrorObject.Errors.Add(ex.Message);
                bookManagerErrorObject.Exception = ex;
            }
            _dbContext.SaveChanges();
            return bookManagerErrorObject;
        }

        public BookManagerErrorObject Delete(Customer customer)
        {
           BookManagerErrorObject bookManagerErrorObject = new BookManagerErrorObject();
            _dbContext.Customers.Remove(customer);
            try
            {
                _dbContext.SaveChanges();
                bookManagerErrorObject.Succeeded = true;
            }
            catch (Exception ex)
            {
                bookManagerErrorObject.Succeeded = false;
                bookManagerErrorObject.Errors.Add(ex.Message);
                bookManagerErrorObject.Exception = ex;
            }
            _dbContext.SaveChanges();
            return bookManagerErrorObject;
        }

        public List<Customer> GetAll()
        {
        return _dbContext.Customers.Where(w=>w.IsDeleted==false && w.IsActive==true).ToList();
        }
    }
}
