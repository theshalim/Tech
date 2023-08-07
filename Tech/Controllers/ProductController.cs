using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Tech.Data;
using Tech.Models;

namespace Tech.Controllers
{
    public class ProductController : Controller
    {
        private readonly DataContext _context;
        public ProductController(DataContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.products.ToListAsync());
            
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewData["ColorId"] = new SelectList(_context.colors, "ColorId", "ColorId");
            ViewData["UnitId"] = new SelectList(_context.productUnits, "UnitId", "UnitId");
            //ViewData["ManufracturingAddressId"] = new SelectList(_context.manufracturingAddresses, "ManufracturingAddressId", "ManufracturingAddressId");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            if(ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }
    }
}