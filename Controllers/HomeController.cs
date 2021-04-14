using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private DataContext Context;

        public HomeController(DataContext context)
        {
            Context = context;
        }
        //by id
        //public async Task<IActionResult>Index(long id = 1)
        //{
        //    return View(await Context.Products.FindAsync(id));
        //}
        public async Task<IActionResult> Index(long id=1)
        {
            Product prod = await Context.Products.FindAsync(id);
            if (prod.CategoryId == 1)
            {
                return View("Watersports", prod);
            }
            else
            {
                return View(prod);
            }

        }
        public IActionResult Common()
        {
            return View();
        }
    }
}
