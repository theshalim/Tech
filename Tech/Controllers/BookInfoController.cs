using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tech.Data;

namespace Tech.Controllers
{
    public class BookInfoController : Controller
    {
        private readonly DataContext _conttext;
        public BookInfoController(DataContext context)
        {
            _conttext = context;
        }
        public IActionResult Index()
        {
            var BookList = _conttext.BookInfos.ToList();
            return View(BookList);
        }
    }
}