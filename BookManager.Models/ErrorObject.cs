using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Object = System.Object;

namespace BookManager.Models
{
    public class Error
    {
        public string Field { get; set; }
        public string Message { get; set; }
    }
    
    public  class BookManagerErrorObject
    {
         
        public BookManagerErrorObject()
        {
            Messages = new List<string>();
            Errors = new List<Error>();
            ExceptionErrors = new List<string>();
            Data = new object();
         
        }

        public string ErrorMessage;
        public bool Succeeded { get; set; }        

        public List<Error> Errors { get; set; }

        public List<string> ExceptionErrors { get; set; }

        public List<string> Messages { get; set; }

        public string Field { get; set; }
        public string CustomMessage { get; set; }
        public Exception Exception { get; set; }

        public Object Data { get; set; }
    }
}
