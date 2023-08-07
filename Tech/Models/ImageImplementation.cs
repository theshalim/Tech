using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Tech.Models.ImageImplementation
{
    public class ImageImplementation
    {
        [Key]
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }

        public string path { get; set; }
        [NotMapped]
        [Display(Name ="Choose File")]
        public IFormFile ImagePath { get; set; }
    }
}
