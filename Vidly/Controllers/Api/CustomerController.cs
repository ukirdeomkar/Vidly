using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System.Data.Entity;
using System.Net;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private MyDBContext _context;


        // Get /api/customer
        public CustomerController()
        {
            _context = new MyDBContext();
        }
        [HttpGet]
        public IEnumerable<Customer> GetCustomers()
        {
            return _context.Customers.ToList();
        }

        //Get /api/customer/1

        [HttpGet("{id}")]
        public Customer GetCustomerById(int id)
        {
            var customer = _context.Customers.SingleOrDefault(x => x.Id == id);
            if (customer == null)
            {
                //throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.NotFound, "Resource not found"));
                Console.WriteLine("Not FOund");
            }

            return customer;
        }


        //Post /api/customer
        [HttpPost]
        public  Customer CreateCustomer(Customer customer)
        {
            if(!ModelState.IsValid)
            {
                Console.WriteLine("Bad Request");
            }
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return customer;
        }


        // Put /api/customer/id
        [HttpPut("{id}")]
        public void UpdateCustomer(int id, Customer customer)
        {
            if (!ModelState.IsValid)
            {
                Console.WriteLine("Bad Request");
            }
            var customerinDb = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customerinDb == null)
            {
                Console.WriteLine("Not FOund Customer");
            }
            customerinDb.Name = customer.Name;
            customerinDb.BirthDate = customer.BirthDate;
            customerinDb.IsSubscribedToNewsLetter = customer.IsSubscribedToNewsLetter;
            customerinDb.MembershipTypeId = customer.MembershipTypeId;

            _context.SaveChanges();
           
        }

        //Delete /api/customer/id
        [HttpDelete("{id}")]
        public void DeleteCustomer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c=>c.Id==id);
            if(customer == null)
            {
                Console.WriteLine("Customer nOt FOund");
            }
            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }
    }
}
