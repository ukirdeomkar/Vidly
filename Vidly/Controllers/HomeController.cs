using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Logging;
using System.Data.Entity;
using System.Diagnostics;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}