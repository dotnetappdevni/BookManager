﻿using BookManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager.CustomerService.Interface
{
    public interface ICustomerService
    {
        List<Customer> GetAll();

        Customer GetCustomerById(int id);

        BookManagerErrorObject Add(Customer customer);

        BookManagerErrorObject Update(Customer customer);

        BookManagerErrorObject Delete(int customerId);

    }
}
