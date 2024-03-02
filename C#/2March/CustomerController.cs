using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication2.Models;

namespace WebApplication2.Controllers.api
{
    public class CustomerController : ApiController
    {
        private ApplicationDbContext _context;

        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _context.Customer.ToList();
        }

        public Customer GetCustomersById(int id)
        {
            var customer = _context.Customer.SingleOrDefault(c => c.Id == id);

            if (customer == null)
            {
                throw new HttpRequestException(HttpStatusCode.NotFound.ToString());
            }

            return customer;
        }

        [HttpPost]
        public Customer CreateCustomers(Customer customers)
        {
            if (!ModelState.IsValid)
                throw new HttpRequestException(HttpStatusCode.BadRequest.ToString());

            _context.Customer.Add(customers);
            _context.SaveChanges();

            return customers;
        }
        [HttpPut]
        public Customer UpdateCustomer(int id, Customer customers)
        {
            var customerInDb = _context.Customer.SingleOrDefault(c => c.Id == id);
            if (customerInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            customerInDb.Id = customers.Id;
            customerInDb.Name = customers.Name;
            customerInDb.Address = customers.Address;
            customerInDb.City = customers.City;

            _context.Customer.Add(customers);
            _context.SaveChanges();

            return customers;
        }
        //Delete /api/customers/1
        [HttpDelete]
        public void DeleteCustomer(int id)
        {
            var customerInDb = _context.Customer.SingleOrDefault(c => c.Id == id);
            if (customerInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            _context.Customer.Remove(customerInDb);
            _context.SaveChanges();

        }
    }
}
