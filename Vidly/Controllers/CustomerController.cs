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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(Customer customer)
        {

            //if(!ModelState.IsValid)
            //{
            //    var viewModel = new NewCustomeViewModel {
            //        Customer = customer ,
            //        MembershipType = _context.MembershipType.ToList()
            //    };
            //    return View("CustomerForm",viewModel);
            //}
            if (customer.Id == 0)
                _context.Customers.Add(customer);
            else
            {
                var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);

                customerInDb.Name = customer.Name;
                customerInDb.BirthDate = customer.BirthDate;
                customerInDb.MembershipType = customer.MembershipType;
                customerInDb.IsSubscribedToNewsLetter = customer.IsSubscribedToNewsLetter;

            }
            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return RedirectToAction("Index", "Customer");

        }
        public IActionResult New()
        {
            var membershipType = _context.MembershipType.ToList();
            var viewModel = new NewCustomeViewModel
            {
                Customer = new Customer(),
                MembershipType = membershipType
            };
            return View("CustomerForm", viewModel);
        }

        public IActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return new NotFoundResult();
            var viewModel = new NewCustomeViewModel
            {
                Customer = customer,
                MembershipType = _context.MembershipType.ToList()

            };
            return View("CustomerForm", viewModel);
        }


    }

}
