using Fluent.Infrastructure.FluentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebVidly.Models;

namespace WebVidly.Controllers.api
{
    public class CustomerController : ApiController
    {
        private CustomerContext _context;

        public CustomerController()
        {
            _context = new CustomerContext();
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _context.Customers;
        }

        public Customer GetCustomersById(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

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

            _context.Customers.Add(customers);
            _context.SaveChanges();

            return customers;
        }
        [HttpPut]
        public Customer UpdateCustomer(int id, Customer customers) 
        {
            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customerInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            customerInDb.Name = customers.Name;
            customerInDb.Address = customers.Address;
            customerInDb.City = customers.City;

            _context.SaveChanges();

            return customerInDb;
        }
        //Delete /api/customers/1
        [HttpDelete]
        public string DeleteCustomer(int id)
        {
            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customerInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            _context.Customers.Remove(customerInDb);
            _context.SaveChanges();
            return "Sucessfully Deleted";
        }
    }
}
