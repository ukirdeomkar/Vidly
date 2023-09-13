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

        //public  List<Customer> customer = new List<Customer>
        //    {
        //        new Customer {Name="Abrahama Linkon", Id=1},
        //        new Customer {Name="Ben Grey" , Id=2},
        //        new Customer {Name="Cella Hook" , Id=3},
        //        new Customer {Name = "Dolby Atmos" , Id=4},

        //    };
       

        
       

        //public List<Movie> movies = new List<Movie>
        //    {
        //        new Movie {Name="Interstellar", Id=1},
        //        new Movie { Name = "Mission Impossible" , Id =2},

        //    };

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}