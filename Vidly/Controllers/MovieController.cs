using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET /movies/random
        public IActionResult Random()
        {

            var movie = new Movie() { 
                Name = "Intestellar",
                Id = 1,
            };
            var customers = new List<Customer>
            {
                new Customer {Name ="customer 1"},
                new Customer {Name ="customer 2"},

            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customer = customers
            };     
            

            return View(viewModel);
            // return Content("Hello !");
            //return new NotFoundResult();
            //return  RedirectToAction("Index" , "Home" , new {name="avenger",sortBy="part"});
        }

        //Route paramter validation still not working
        //[Route("movie/released/{{year}}/{{month:regex(\\d{2}$):range(1,12)}")]
        [Route("movie/released/{year}/{month}")]
        public IActionResult ByReleaseDate(int year , int month)
        {

            //return ControllerContext.MyDisplayRouteInfo();
            return Content(year + "/"+month);

        }
        //public IActionResult Index(int? pageIndex , string sortBy)
        //{
        //    if(pageIndex == null)
        //    {
        //        pageIndex = 1;
        //    }
        //    if(sortBy == null)
        //    {
        //        sortBy = "name";
        //    }
        //    //return Content("pageIndex=" + pageIndex + "&sortBy=" + sortBy);
        //    return Content(String.Format("pageIndex={0}&sortBy={1}",pageIndex, sortBy));

        //}



    }
}
