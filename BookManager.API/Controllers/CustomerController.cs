﻿using BookManager.CustomerService.Interface;
using BookManager.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NLog;
using System.Diagnostics.Eventing.Reader;
using System.Text.Json;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;
using static System.Runtime.InteropServices.JavaScript.JSType;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CustomerController : ControllerBase
    {
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;

        }

        [HttpGet("GetAllCustomers")]
        public IActionResult GetAll()
        {
            return Ok(_customerService.GetAll());

        }

        [HttpGet("GetCustomerById")]

        public IActionResult GetCustomerById(int id)
        {
            return Ok(_customerService.GetCustomerById(id));
        }

        [Authorize]
        [HttpPost("AddCustomer")]
        public IActionResult Add(Customer customer)
        {
            var customerToAdd = _customerService.Add(customer);
            if (customerToAdd.Succeeded)
            {
                return Ok(JsonSerializer.Serialize(customerToAdd.Messages));
                _logger.Info($"Customer been created successfully");
            }
            else
            {
                _logger.Error($"Exception occurred on Add Customer Method");

                return StatusCode(400, JsonSerializer.Serialize(customerToAdd.Errors));

            }
        }


        [HttpPut("UpdateCustomer")]
        public IActionResult Update(Customer customer)
        {
            var customerToUpdate = _customerService.Update(customer);
            if (customerToUpdate.Succeeded)
            {
                _logger.Info($"Customer been updated successfully!");

                return Ok(JsonSerializer.Serialize(customerToUpdate.Messages));
            }
            else
            {
                _logger.Error("Exception has occurred in the Update Customer Controller method", customerToUpdate.Exception);

                return StatusCode(400, JsonSerializer.Serialize($"Error Message : {customerToUpdate.Errors}"));

            }
        }


        [HttpDelete("DeleteCustomer")]
        public IActionResult Delete(int customerId)
        {
            var customerToDelete = _customerService.Delete(customerId);
            if (customerToDelete.Succeeded)
            {
                _logger.Info($"Customer been deleted successfully!");

                return Ok(JsonSerializer.Serialize(customerToDelete.Messages));
            }
            else
            {

                _logger.Error("Exception has occurred in the Delete Customer Controller method", customerToDelete.Exception);
                
                string json = JsonSerializer.Serialize(customerToDelete.Errors);

                return BadRequest(json);


            }
        }
    }
}
