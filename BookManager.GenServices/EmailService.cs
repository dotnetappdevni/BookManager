using BookManager.GenServices.Interface;
using BookManager.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BookManager.GenServices
{
    public class EmailService : IEmailService
    {
        private static readonly NLog.Logger _logger = LogManager.GetCurrentClassLogger();
        IConfigurationRoot _configuration;
        public EmailService()
        {
            var builder = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                            .AddEnvironmentVariables();

            _configuration = builder.Build();

        }


        /// <summary>
        /// Send an email for the activation emails and register emails of web api
        /// </summary>
        /// <param name="emailMessageModel"></param>
        public async Task Send(EmailMessageModel emailMessageModel)
        {
            try
            {
                var emailSettings = _configuration.GetSection("EmailSettings");
                var defaultFromEmail = emailSettings["DefaultFromEmail"];
                var host = emailSettings["Host"];
                var port = emailSettings.GetValue<int>("Port");
                var userName = emailSettings.GetValue<string>("Username");
                var password = emailSettings.GetValue<string>("Password");
                var toAddress = emailMessageModel.ToAddress.ToString();


                MailMessage mail = new MailMessage()
                {
                    From = new MailAddress(defaultFromEmail, defaultFromEmail)
                };

                mail.To.Add(new MailAddress(toAddress));
                mail.Subject = emailMessageModel.Subject;
                mail.Body = emailMessageModel.Body;
                mail.IsBodyHtml = true;
                mail.Priority = MailPriority.Normal;

                using (SmtpClient smtp = new SmtpClient(host, port))
                {
                    smtp.Credentials = new NetworkCredential(userName, password);
                    //  smtp.EnableSsl = true;

                    await smtp.SendMailAsync(mail);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
