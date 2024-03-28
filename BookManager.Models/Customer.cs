using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager.Models
{
    public  class Customer
    {
        public int Id { get; set; }
        public string? Forename { get; set; }
        public string? MiddleName { get; set; }
        public string? Surname { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? Address3 { get; set; }
        public string? Address4 { get; set; }
        public string? Address5 { get; set; }

        public string? County { get; set; }

        public string? Notes { get; set; }

        public string? Country { get; set; }
        public string? PostCode { get; set; }
        public string? Email { get; set; }
        public bool? IsDeleted { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateModified { get; set; }

        public DateTime? DateDeleted { get; set; }

 

    }
}
