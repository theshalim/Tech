using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tech.Models;
using Tech.Data;

namespace Tech.Controllers
{
    
    public class AuthorInfoController : Controller
    {
        private readonly DataContext _context;
        public AuthorInfoController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var Author = _context.AuthorInfos.ToList();
            return View(Author);
        }
        //return View(await _context.priceRanges.ToListAsync());
        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }
       [HttpPost]
        public  IActionResult Create(AuthorInfo authorInfo)
        {
            if (ModelState.IsValid) {

                _context.AuthorInfos.Add(authorInfo);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(authorInfo);
        }

        [HttpGet]
        public IActionResult Delete(int AuthorId)
        {
            var AuthorInfo = _context.AuthorInfos.FirstOrDefault(x => x.AuthorId == AuthorId);
            if(AuthorInfo == null)
            {
                return NotFound();
            }
            return View(AuthorInfo);
        }
        [HttpPost]
        public IActionResult DeleteConfirmed(int AuthorId)
        {
            var AuthorInfo = _context.AuthorInfos.FirstOrDefault(x => x.AuthorId == AuthorId);
            if(AuthorInfo == null)
            {
                return NotFound();
            }

            _context.AuthorInfos.Remove(AuthorInfo);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int AuthorId)
        {
            var AuthorInfo = _context.AuthorInfos.FirstOrDefault(x => x.AuthorId == AuthorId);
            if(AuthorInfo == null)
            {
                return NotFound();
            }
            return View(AuthorInfo);
        }

        [HttpPost]
        public IActionResult Update(AuthorInfo UpdatedAuthorInfo)
        {
            var AuthorInfo = _context.AuthorInfos.FirstOrDefault(x => x.AuthorId == UpdatedAuthorInfo.AuthorId);
            if (AuthorInfo == null)
            {
                return NotFound();
            }
            _context.AuthorInfos.Update(AuthorInfo);
            _context.SaveChanges();
            return View(AuthorInfo);
        }
    }
}
