using System;
using Microsoft.AspNet.Mvc;
using ModelDemo.Models;

namespace ModelDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        public IActionResult Index()
        {
            var model = new IndexPageModel()
            {
                FirstName = "John",
                LastName = "Doe",
                CurrentTime = DateTime.Now
            };

            return View(model);
        }
    }
}