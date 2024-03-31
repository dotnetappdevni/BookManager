using BookManager.CustomerService.Interface;
using BookManager.DAL;
using BookManager.Models;
using Microsoft.Extensions.Logging;
using NLog;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BookManager.CustomerService
{
    public class CustomerServices : ICustomerService
    {
        private readonly ApplicationDBContext _dbContext;
        private static readonly NLog.Logger _logger = LogManager.GetCurrentClassLogger();


        public CustomerServices(ApplicationDBContext dBContext)
        {
            _dbContext = dBContext;

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
            _logger.Error("Entered the Update customer method  ");
            try
            {
                _dbContext.Customers.Add(customer);
                _dbContext.SaveChanges();
                bookManagerErrorObject.Succeeded = true;
                bookManagerErrorObject.Messages.Add("Customer Created Successfully");
                _logger.Info("Customer created successfully");
                _logger.Error("Exited the Update customer method");
            }
            catch (Exception ex)
            {
                bookManagerErrorObject.Succeeded = false;
                bookManagerErrorObject.Exception = ex;
                _logger.Error("Exception occurred in the add customer method service", ex);
            }
            _dbContext.SaveChanges();
            return bookManagerErrorObject;
        }

        public BookManagerErrorObject Update(Customer customer)
        {
            BookManagerErrorObject bookManagerErrorObject = new BookManagerErrorObject();
            _logger.Error("Entered the Update customer method  ");

            try
            {
                var customerToUpdate = _dbContext.Customers.Where(w => w.Id == customer.Id && w.IsActive==true  && w.IsDeleted==false).FirstOrDefault();
                if (customerToUpdate != null)
                {
                    _dbContext.Entry(customerToUpdate).CurrentValues.SetValues(customer);
                    try
                    {
                        _dbContext.SaveChanges();
                        bookManagerErrorObject.Succeeded = true;
                        bookManagerErrorObject.Messages.Add($"Customer Successfully updated {customer.Id}");
                       _logger.Error("Update customer method completed successfully");
                        _logger.Error("Exited the Update customer method  ");

                    }
                    catch (Exception ex)
                    {
                        bookManagerErrorObject.Succeeded = false;
                        bookManagerErrorObject.ExceptionErrors.Add($"Exception occurred while updating customer {customer.Id}");
                        bookManagerErrorObject.Exception = ex;
                        _logger.Error("Exception occurred in the Update customer method service", ex);


                    }
                }else
                {

                    bookManagerErrorObject.Errors.Add(new Models.Error { Field = "errorMessage", Message = "Customer Not Found please ensure customer Id correct." });
                    bookManagerErrorObject.Succeeded = false;
                }

            }

            catch (Exception ex)
            {
                bookManagerErrorObject.Succeeded = false;

                bookManagerErrorObject.ExceptionErrors.Add($"Exception occurred while updating customer {customer.Id}");
                bookManagerErrorObject.Exception = ex;
                _logger.Error("Exception occurred in the Update customer method service", ex);


            }
            return bookManagerErrorObject;
        }



        /// <summary>
        /// Deletes a customer
        /// </summary>
        /// <param name="customer"></param>
        /// <returns>BookManagerErrorObject cuustom error object</returns>
        public BookManagerErrorObject Delete(int customerId)
        {
            BookManagerErrorObject bookManagerErrorObject = new BookManagerErrorObject();
            var customerToDelete = _dbContext.Customers.Find(customerId);
            _logger.Error("Entered the Delete customer method  ");
            if (customerToDelete != null)
            {
                try
                {
                    _dbContext.Customers.Remove(customerToDelete);
                    _dbContext.SaveChanges();
                    bookManagerErrorObject.Succeeded = true;
                    bookManagerErrorObject.Messages.Add("Customer Deleted");
                    _logger.Info("Customer Deleted successfully");
                    _logger.Error("Exited the Delete customer method  ");

                }
                catch (Exception ex)
                {
                    bookManagerErrorObject.Succeeded = false;
                    bookManagerErrorObject.ExceptionErrors.Add(ex.Message);
                    
                    bookManagerErrorObject.Exception = ex;
                    _logger.Error("Exception occurred in the Delete customer method service", ex);

                }
            }
            else
            {
                bookManagerErrorObject.Errors.Add(new Models.Error { Field = "errorMessage", Message = "Customer Not Found please ensure customer Id correct." });
                bookManagerErrorObject.Succeeded = false;
                


            }
            return bookManagerErrorObject;
        }
    }
}
