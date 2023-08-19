using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tech.Areas.HrAddress.Models;
using Tech.Data;

namespace Tech.Areas.HrAddress.Controllers
{
    [Area("HrAddress")]
    //[Route("[HrAddress]/[Index]")]
    public class HrDivisionController : Controller
    {
        private readonly DataContext _context;
        public HrDivisionController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
           var Division = _context.HrDivisions.ToList();
            return View(Division);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return  View();
        }
        [HttpPost]
        public  IActionResult Create(HrDivision hrDivision)
        {
            _context.HrDivisions.Add(hrDivision);
            _context.SaveChangesAsync();
            return View(hrDivision);
        }
    }
}