using BookManager.CustomerService.Interface;
using BookManager.Models;
using FluentEmail.Core;
using Microsoft.Extensions.Logging;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager.CustomerService
{
    public class EmailService : IEmailService
    {
        private static readonly NLog.Logger _logger = LogManager.GetCurrentClassLogger();
        private readonly FluentEmailFactory _fluentEmailFactory;

        public EmailService(FluentEmailFactory fluentEmailFactory)
        {

            _fluentEmailFactory = fluentEmailFactory;
        }


        public async Task Send(EmailMessageModel emailMessageModel)
        {

            await _fluentEmailFactory.Create().To(emailMessageModel.ToAddress)
                .Subject(emailMessageModel.Subject)
                .Body(emailMessageModel.Body, true) // true means this is an HTML format message
                .SendAsync();
        }
    }



}
