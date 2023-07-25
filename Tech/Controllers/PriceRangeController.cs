using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tech.Data;
using Tech.Models;

namespace Tech.Controllers
{
    public class PriceRangeController : Controller
    {
        private readonly DataContext _context;
        public PriceRangeController(DataContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.priceRanges.ToListAsync());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        } 
        [HttpPost]
        public async Task<IActionResult> Create(PriceRange priceRange)
        {
            if(ModelState.IsValid)
            {
                _context.Add(priceRange);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(priceRange);
           
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            var price =await _context.priceRanges.Where(x=>x.PriceRangeId == id).FirstOrDefaultAsync();
            return View(price);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var price = await _context.priceRanges.FindAsync(id);
            _context.priceRanges.Remove(price);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}