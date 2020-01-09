using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MovieApp.ViewModel;

namespace MovieApp.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Customers
        public ActionResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType);
            return View(customers);
        }
        /*
        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).Single(c => c.Id == id);
            return View(customer);
        }
          */
        public ActionResult New()
        {
            var DBmebershipTypes = _context.MembershipTypes;
            var ViewModel = new CustomerFormViewModel()
            {
                MembershipTypes = DBmebershipTypes
            };
            return View("CustomerForm",ViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Customer customer)
        {
            ModelState.Remove("customer.Id");
            var propertiesWithErrors = ModelState.Where(state => state.Value.Errors.Any()).Select(state => state.Key);
            if (!ModelState.IsValid)
            {
                var viewModel = new CustomerFormViewModel()
                {
                    Customer = customer,
                    MembershipTypes = _context.MembershipTypes.ToList()
                };
                return View("CustomerForm",viewModel);
            }
            if (customer.Id == 0)
                _context.Customers.Add(customer);
            else
            {
                var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);
                customerInDb.FirstName = customer.FirstName;
                customerInDb.LastName = customer.LastName;
                customerInDb.MembershipTypeId = customer.MembershipTypeId;
                customerInDb.IsSubscribedToNewsLetter = customer.IsSubscribedToNewsLetter;
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Customers");
        }

        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.Single(c => c.Id == id);
            if (customer is null)
                return HttpNotFound();

            var viewModel = new CustomerFormViewModel()
            {
                Customer = customer,
                MembershipTypes = _context.MembershipTypes.ToList(),
            };
            return View("CustomerForm", viewModel);
        }

        public ActionResult Delete(int id)
        {
            var customer = _context.Customers.Single(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();

            _context.Customers.Remove(customer);
            _context.SaveChanges();
            return View();
        }
    }
}