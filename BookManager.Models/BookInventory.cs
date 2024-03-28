using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager.Models
{
    public class BookInventory
    {
        public int Id { get; set; }


        public int BookId { get; set; }

        public string? BarCode { get; set; }



        public int? InventoryCount { get; set; }

        public bool? IsDeleted { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateModified { get; set; }

        public DateTime? DateDeleted { get; set; }

    }
}
