using CoffeeShopRegistration.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Reflection;

namespace CoffeeShopRegistration.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Registration()
        { return View(); }

        public IActionResult Welcome(User u)
        {
            // the following logic has been added to the Registration page for practicing alternative solutions.
            //Random rand = new Random();
            //int userCount = rand.Next(1, 20);

            //if (userCount < 11)
            //{
            //    u.topTenCustomer = true;
            //}
            //else
            //{
            //    u.topTenCustomer = false;
            //}

            return View(u); 
    }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
