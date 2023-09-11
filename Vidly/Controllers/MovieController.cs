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
        }
    }
}
