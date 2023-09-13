using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {

        private MyDBContext _context;
        public CustomerController()
        {
            _context = new MyDBContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public IActionResult Index()
        {
            var customer = _context.Customers.Include(c => c.MembershipType).ToList();
            var viewModel = new CustomerMovieViewModel
            {
                Customer = customer
            };


            return View(viewModel);
        }
        public IActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);



           

            return View(customer);

        }
    }
    
}
