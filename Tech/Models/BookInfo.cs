using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tech.Models
{
    public class BookInfo
    {
        [Key]
        public int BookId { get; set; }
        [Display(Name = "Book Name")]
        [Required(ErrorMessage = "This field required!")]
        public string name { get; set; }

        public int AuthorId { get; set; }
        public AuthorInfo AuthorInfo { get; set; }
    }
}
