using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspCoreLibraryEF.wwwroot.Models;

namespace BookLibraryEF.Controllers
{
    public class HomeController : Controller
    {
        private IBookRepository _bookRepo;
        private ICategoryRepo _categoryRepo;

        public HomeController(IBookRepository _book, ICategoryRepo _category) {
            _bookRepo= _book ;
             _categoryRepo= _category;
        }
        public IActionResult Index()
        {
            Console.WriteLine(_bookRepo.Books);
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
