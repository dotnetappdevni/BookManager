using BookManager.CustomerService.Interface;
using BookManager.Domain;
using BookManager.Models;
using Microsoft.Extensions.Logging;

namespace BookManager.CustomerService
{
    public class CustomerServices : ICustomerService
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly ILogger<CustomerServices> _logger;


        public CustomerServices(ILogger<CustomerServices> logger,ApplicationDBContext dBContext) 
        {
            _dbContext = dBContext;
            _logger = logger;
        }

        /// <summary>
        /// Gets all active customers
        /// </summary>
        /// <returns>List<Customer> a list of customer</returns>
        public List<Customer> GetAll()
        {
            return _dbContext.Customers.Where(w => w.IsDeleted == false && w.IsActive == true).ToList();
        }

        /// <summary>
        /// Gets a single customer by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Returns a single customer</returns>
        public Customer GetCustomerById(int id)
        {
            return _dbContext.Customers.Where(w => w.Id == id & w.IsDeleted == false && w.IsActive == true).FirstOrDefault(); 
        }

        /// <summary>
        /// Creates a Customer
        /// </summary>
        /// <param name="customer"></param>
        /// <returns>BookManagerErrorObject cuustom error object</returns>
        public BookManagerErrorObject Add(Customer customer)
        {
            BookManagerErrorObject bookManagerErrorObject = new BookManagerErrorObject();
            _dbContext.Customers.Add(customer);
            try 
            {               
                _dbContext.SaveChanges();
                bookManagerErrorObject.Succeeded = true;
                bookManagerErrorObject.Messages.Add("Customer Created Sucessfully");
                _logger.LogInformation("Customer created sucessfully");
            }
            catch (Exception ex)
            {
                bookManagerErrorObject.Succeeded = false;
                bookManagerErrorObject.Errors.Add(ex.Message);
                bookManagerErrorObject.Exception = ex;
                _logger.LogError("Exception occoured in the add customer method servce" , ex);
            }
            _dbContext.SaveChanges();
            return bookManagerErrorObject;
        }

        /// <summary>
        /// Deletes a customer
        /// </summary>
        /// <param name="customer"></param>
        /// <returns>BookManagerErrorObject cuustom error object</returns>
        public BookManagerErrorObject Delete(Customer customer)
        {
           BookManagerErrorObject bookManagerErrorObject = new BookManagerErrorObject();
            _dbContext.Customers.Remove(customer);
            try
            {
                _dbContext.SaveChanges();
                bookManagerErrorObject.Succeeded = true;
                bookManagerErrorObject.Messages.Add("Customer Deleted");
                _logger.LogInformation("Customer Deleted sucessfully");

            }
            catch (Exception ex)
            {
                bookManagerErrorObject.Succeeded = false;
                bookManagerErrorObject.Errors.Add(ex.Message);
                bookManagerErrorObject.Exception = ex;
                _logger.LogError("Exception occoured in the delete customer method servce", ex);

            }
            _dbContext.SaveChanges();
            return bookManagerErrorObject;
        }

      

    }
}
