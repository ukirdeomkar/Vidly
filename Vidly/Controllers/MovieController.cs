using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;
using System.Runtime.InteropServices;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET /movies/random
        private MyDBContext _context;
        public MovieController()
        {
            _context = new MyDBContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
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

            return Content(year + "/"+month);

        }
        public IActionResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();
            var viewModel = new CustomerMovieViewModel
            {
                Movie = movies
            };


            return View(viewModel);

        }
        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);
            if (movie == null)
                return new NotFoundResult(); 
            return View(movie);
        }

        public ActionResult New()
        {
            var genre = _context.MoviesGenre.ToList();
            
            var viewModel = new MovieFormViewModel
            {
                Movie = new Movie(),
                MovieGenre = genre
            };
            
            return View("MovieForm", viewModel);
        }
        public IActionResult Save(Movie movie)
        {
            //if (!ModelState.IsValid)
            //{
            //    var viewModel = new MovieFormViewModel
            //    {
            //        Movie = movie,
            //        MovieGenre = _context.MoviesGenre.ToList()
            //    };
            //    return View("MovieForm", viewModel);
            //}
            movie.DateAdded = DateTime.Now;
            if (movie.Id == 0)
                _context.Movies.Add(movie);
            else
            {
                var movieInDb = _context.Movies.Single(c => c.Id == movie.Id);

                movieInDb.Name = movie.Name;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.Genre = movie.Genre;
                movieInDb.NumberOfStocks = movie.NumberOfStocks;

            }
            //try
            //{
                _context.SaveChanges();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex);
            //}
            
            return RedirectToAction("Index", "Movie");

        }

        public IActionResult Edit(int id)
        {
            
                var movie = _context.Movies.SingleOrDefault(c => c.Id == id);
                if (movie == null)
                    return new NotFoundResult();
                var viewModel = new MovieFormViewModel
                {
                   Movie = movie,
                   MovieGenre = _context.MoviesGenre.ToList()

                };
                return View("MovieForm", viewModel );
            
        }



    }
}
