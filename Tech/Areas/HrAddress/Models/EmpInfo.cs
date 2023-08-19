using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tech.Areas.HrAddress.Models
{
    public class EmpInfo
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="This Field Required!")]
        public int EmpCode { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "This field Required!"), StringLength(50)]
        public string EmpEnName { get; set; }
        [Display(Name = "Name")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "This field Required!"), StringLength(15), EmailAddress]
        public string Email { get; set; }

        public int DivisionId { get; set; }
        public HrDivision HrDivision { get; set; }

        public int DistrictId { get; set; }
        public HrDistrict HrDistrict { get; set; }

        public int ThanaId { get; set; }
        public HrThana HrThana { get; set; }

        
    }
}
