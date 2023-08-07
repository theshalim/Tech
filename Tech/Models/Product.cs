using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tech.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string enName { get; set; }
        public string bnName { get; set; }

        public int UnitId { get; set; }
        public virtual ProductUnit ProductUnit{ get; set; }

        public int ColorId { get; set; }
        public virtual Color Color { get; set; }

        public int ManufracturingAddressId { get; set; }
        //public virtual ManufracturingAddress ManufracturingAddress { get; set; }

    }
}
