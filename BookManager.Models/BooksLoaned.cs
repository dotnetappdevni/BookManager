using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager.Models
{
    public class BooksLoaned
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }

        public string? BarCode { get; set; }
         
        public int BookId { get; set; }

        public bool? IsReturned { get; set; }
        public DateTime? DateBorrowed { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? DateReturned { get; set; }

        public int? Status { get; set; }
        public bool? IsDeleted { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateModified { get; set; }

        public DateTime? DateDeleted { get; set; }
    }
}
