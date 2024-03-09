using AutoMapper;
using ProboVideo.Dtos;
using ProboVideo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProboVideo.Controllers.api
{
    public class CustomerController : ApiController
    {
        private ApplicationDbContext _context;

        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [HttpPost]
        public CustomerDto Create(CustomerDto customerdto)
        {
            var customer = Mapper.Map<CustomerDto, Customer>(customerdto);
             _context.Customers.Add(customer);
             _context.SaveChanges();

            customerdto.Id = customer.Id;
             return customerdto;
        }
        [HttpGet]
        [Authorize(Roles = RolesName.ManageMovie)]
        public IEnumerable <CustomerDto> Get()
        {
            var customers = _context.Customers.ToList().Select(Mapper.Map<Customer, CustomerDto>);

            return customers;
        }
        [HttpGet]
        public CustomerDto Get(int id)
        {
            return Mapper.Map<Customer,CustomerDto> (_context.Customers.Find(id));
        }

        [HttpPut]
        [Authorize(Roles = RolesName.ManageMovie)]
        public CustomerDto Update(int id,CustomerDto customerDto) 
        {
            var customerdb = _context.Customers.SingleOrDefault(m=>m.Id == id);


            Mapper.Map(customerDto, customerdb);

            _context.SaveChanges();

            return customerDto;
        }
        [HttpDelete]
        [Authorize(Roles = RolesName.ManageMovie)]
        public string Delete(int id)
        {
            var deleteDb = _context.Customers.SingleOrDefault(m=>m.Id==id);

            _context.Customers.Remove(deleteDb);

            _context.SaveChanges();

            return "Sucessfully Customer details Deleted";
        }
    }
}
