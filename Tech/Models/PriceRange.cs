﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tech.Models
{
    public class PriceRange
    {
        [Key]
        public int PriceRangeId { get; set; }
        [Required]
        [StringLength(20)]
        [DisplayName("Price Range")]
        public string enName { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
