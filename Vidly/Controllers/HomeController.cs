using Microsoft.AspNetCore.Mvc;
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
        public  List<Customer> customer = new List<Customer>
            {
                new Customer {Name="Abrahama Linkon", Id=1},
                new Customer {Name="Ben Grey" , Id=2},
                new Customer {Name="Cella Hook" , Id=3},
                new Customer {Name = "Dolby Atmos" , Id=4},

            };

        public IActionResult Customer()
        {
            
            var viewModel = new CustomerMovieViewModel
            {
                Customer = customer
            };


            return View(viewModel);
        }
        public IActionResult CustomerDetails(int id)
        {
            //string s = id.ToString();
            //var customer = new List<Customer>
            //{
            //    new Customer {Name="Abrahama Linkon", Id=1},
            //    new Customer {Name="Ben Grey" , Id=2},
            //    new Customer {Name="Cella Hook" , Id=3},

            //};
            var clicked_customer = new List<Customer> { };
            bool check = false;
            foreach (var c in customer)
            {
                if(c.Id == id)
                {
                    clicked_customer.Add(c);
                    check = true;
                }

            }
            if (!check)
            {
                return new NotFoundResult();
            }

            
            var viewModel = new CustomerMovieViewModel
            {
                Customer = clicked_customer
            };
            Console.WriteLine(clicked_customer.Count);

            return View(viewModel);
            //return Content();
        }
        public List<Movie> movies = new List<Movie>
            {
                new Movie {Name="Interstellar", Id=1},
                new Movie { Name = "Mission Impossible" , Id =2},

            };
        public IActionResult Movie()
        {
            var viewModel = new CustomerMovieViewModel
            {
                Movie = movies
            };


            return View(viewModel);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}