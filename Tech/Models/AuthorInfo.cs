using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tech.Models
{
    public class AuthorInfo
    {
        [Key]
        public int AuthorId { get; set; }
        [Display(Name = "Author Name")]
        [Required(ErrorMessage ="This field required!")]
        public string name { get; set; }

      public virtual ICollection<BookInfo> bookInfos { get; set; }
    }
}
