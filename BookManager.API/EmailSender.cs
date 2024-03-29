using BookManager.CustomerService;
using BookManager.CustomerService.Interface;
using BookManager.GenServices.Interface;
using BookManager.Models;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace BookManager.API
{
    public class EmailSender : IEmailSender
    {
        private readonly IEmailService _emailService;

        public EmailSender(IEmailService emailService)
        {
            _emailService = emailService;
        }
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            EmailMessageModel emailMessage = new(email,
            subject,
            htmlMessage);

            await _emailService.Send(emailMessage);
        }
    }
}
