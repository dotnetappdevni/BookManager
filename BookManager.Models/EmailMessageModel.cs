using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager.Models
{

    public class EmailMessageModel
    {
        public string ToAddress { get; set; }
        public string Subject { get; set; }
        public string? Body { get; set; }
        public string? AttachmentPath { get; set; }
        public EmailMessageModel(string toAddress, string subject, string? body = "")
        {
            ToAddress = toAddress;
            Subject = subject;
            Body = body;
        }
    }
    
}
