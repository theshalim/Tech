using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tech.Data;

namespace Tech.Areas.HrAddress.Controllers
{
    [Area("HrAddress")]
    public class HrDistrictController : Controller
    {
        private readonly DataContext _context;
        public HrDistrictController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var DistrictList = _context.HrDistricts.ToList();
            return View(DistrictList);
        }
    }
}