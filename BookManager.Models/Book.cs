using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing.Printing;
using System.Runtime.InteropServices;

namespace BookManager.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string BarCode { get; set; }
        public string Description { get; set; }

        public string ISBN { get; set; }

        public int Genre { get; set; }

        public int Type { get; set; }

        [Column(TypeName = "decimal(18,3)")]
        public decimal Price { get; set; }

        public int Condition { get; set; }

        public bool? IsDeleted { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateModified { get; set; }

        public DateTime? DateDeleted { get; set; }


    }
}
