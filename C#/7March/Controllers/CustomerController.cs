using Microsoft.Ajax.Utilities;
using ProboVideo.Models;
using ProboVideo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProboVideo.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
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
        public ActionResult Save(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new NewCustomerViewModel
                {
                    Customer = customer,
                    MemberShipTypes = _context.MemberShipTypes.ToList()
                };
                return View("CustomerForm",viewModel);
            }
            if (customer.Id == 0)
                _context.Customers.Add(customer);
            else {
                var customerDb = _context.Customers.Single(c=>c.Id== customer.Id);

                customerDb.Name = customer.Name;
                customerDb.Address = customer.Address;
                customerDb.BirthDate = customer.BirthDate;
                customerDb.MemberShipTypeId = customer.MemberShipTypeId;
                customerDb.IsSubscribedToNowletter = customer.IsSubscribedToNowletter;
                 }
            
            _context.SaveChanges();

            return RedirectToAction("Index", "Customer");
        }
        // GET: Customer
        public ActionResult Index()
        {
            //var customers = _context.Customers.ToString();
            var customers = _context.Customers.Include("MemberShipType").ToList();
            return View(customers);
        }
        
        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include("MemberShipType").SingleOrDefault(c => c.Id == id);

            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        public ActionResult New()
        {
            var membershipTypes = _context.MemberShipTypes.ToList();

            var viewModel = new NewCustomerViewModel
            {
                Customer = new Customer(),
                MemberShipTypes = membershipTypes
            };
            return View("CustomerForm",viewModel);
        }
        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c=>c.Id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            var viewModel = new NewCustomerViewModel { Customer = customer,
                MemberShipTypes = _context.MemberShipTypes.ToList()
            };
            return View("CustomerForm", viewModel);
        }
    }
}