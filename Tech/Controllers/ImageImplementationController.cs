using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tech.Data;

namespace Tech.Controllers
{
    public class ImageImplementationController : Controller
    {
        private readonly DataContext context;

        public ImageImplementationController(DataContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View(context.ImageImplementations.ToList());
        }
    }
}