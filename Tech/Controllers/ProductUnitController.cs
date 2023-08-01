using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tech.Data;

namespace Tech.Controllers
{
    public class ProductUnitController : Controller
    {
        private readonly DataContext _context;
        public ProductUnitController (DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View( await _context.productUnits.ToListAsync());
        }
    }
}