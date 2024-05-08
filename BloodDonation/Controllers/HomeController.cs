using BloodDonation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BloodDonation.Controllers
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

        [HttpGet]
        public IActionResult Registration()
        {
            return View();  
        }


        [HttpGet]
        public IActionResult Userlogin()
        {
            return View();
        }


        [HttpGet]
        public IActionResult BloodDonation()
        {
            return View();
        }
        [HttpGet]
        public  IActionResult Submitted()
        {
            return View();
        }

        [HttpGet]
        public IActionResult DonateFunds()
        {
            return View();
        }


        [HttpGet]
        public IActionResult BloodRequest()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
