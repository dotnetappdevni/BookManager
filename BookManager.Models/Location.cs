using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager.Models
{


    // Define the Location entity
    public class Location
    {
        [Key]
        [ForeignKey("Book")]
        public int BookId { get; set; }

        [Required]
        public string ShelfNumber { get; set; }

        [Required]
        public int Row { get; set; }

        [Required]
        public int Position { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal Price { get; set; }

        // Navigation property to access the corresponding book
        public virtual Book Book { get; set; }

        public bool? IsDeleted { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateModified { get; set; }

        public DateTime? DateDeleted { get; set; }
    }




}
