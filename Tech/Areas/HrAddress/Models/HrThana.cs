using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tech.Areas.HrAddress.Models
{
    public class HrThana
    {
        [Key]
        public int ThanaId { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "This field Required!"), StringLength(50)]
        public string EnName { get; set; }
        [Display(Name = "Name")]
        public string BnName { get; set; }
        public virtual ICollection<EmpInfo> EmpInfos { get; set; }
    }
}
