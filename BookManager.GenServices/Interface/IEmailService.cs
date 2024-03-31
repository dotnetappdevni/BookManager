using BookManager.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager.GenServices.Interface
{
    public interface IEmailService
    {
        /// <summary>
        /// Send an email.
        /// </summary>
        /// <param name="emailMessage">Message object to be sent</param>
        Task Send(EmailMessageModel emailMessageModel);
    }
}
