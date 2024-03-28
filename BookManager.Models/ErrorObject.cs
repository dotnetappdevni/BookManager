using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager.Models
{
    public  class BookManagerErrorObject
    {
        public BookManagerErrorObject()
        {
        
        }
        public bool Succeeded { get; set; }        

        public List<string> Errors { get; set; }

        public Exception Exception { get; set; }
    }
}
