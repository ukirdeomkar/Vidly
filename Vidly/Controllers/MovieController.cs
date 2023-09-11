using Microsoft.AspNetCore.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET /movies/random
        public IActionResult Random()
        {

            var movie = new Movie() { 
                Name = "move",
                Id = 1,
            };

            return View(movie);
            // return Content("Hello !");
            //return new NotFoundResult();
            //return  RedirectToAction("Index" , "Home" , new {name="avenger",sortBy="part"});
        }

        // Route paramter validation still not working
        [Route("movie/released/{year}/{month:regex(\\d{2}):range(1,12)}")]

        public IActionResult ByReleaseDate(int year , int month)
        {


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
