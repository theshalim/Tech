using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tech.Models
{
    public class ProductUnit
    {
        [Key]
        public int UnitId { get; set; }
        [Required]
        [StringLength(20)]
        public string enName { get; set; }
        public string bnName { get; set; }
        public virtual ICollection<Product> Products { get; set; }

    }
}
