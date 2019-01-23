using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return Content("This is the book controller's index action");
        }
        public IActionResult New()
        {
            return Content("This is the book controller's New action");
        }
        public IActionResult BestSellers()
        {
            return Content("This is the book controller's Best action");
        }
    }
}