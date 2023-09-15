using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System.Data.Entity;
using System.Net;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private MyDBContext _context;
        private readonly IMapper _mapper;

        // Get /api/customer
        public CustomerController(IMapper mapper)
        {
            _context = new MyDBContext();
            _mapper = mapper;
        }
        [HttpGet]
        public IEnumerable<CustomerDto> GetCustomers()
        {
            var customer = _context.Customers.Include(c=>c.MembershipType).ToList();
            // return _context.Customers.ToList();
            // return customer.Select(customer => _mapper.Map<CustomerDto>(customer));
            //var customers = _context.Customers.ToList();
            var customerDtos = customer.Select(customer => _mapper.Map<CustomerDto>(customer));
            return customerDtos;
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
            //if (ModelState.ContainsKey("MembershipType"))
            //{
            //    ModelState["MembershipType"].Errors.Clear();
            //}
            ModelState.Clear();
            if (!ModelState.IsValid)
            {
                Console.WriteLine("Bad Request");
                //return BadRequest();
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
