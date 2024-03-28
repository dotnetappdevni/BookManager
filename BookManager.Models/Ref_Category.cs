using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager.Models
{
    public class Ref_Category
    {
        public int Id { get; set; }

        
        public string Name { get; set; }
        public string? Description { get; set; }
        public int? GroupId { get; set; }
        public int? Type { get; set; }

        public bool? IsDeleted { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateModified { get; set; }

        public DateTime? DateDeleted { get; set; }

    }
}
