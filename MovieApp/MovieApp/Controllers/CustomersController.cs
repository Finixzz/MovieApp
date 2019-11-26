using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieApp.Models;
namespace MovieApp.Controllers
{
    public class CustomersController : Controller
    {
        private List<Customer> customers;

        public CustomersController()
        {
            customers = new List<Customer>()
            {
                new Customer{Id=1,Name="Edo"},
                new Customer{Id=2,Name="Ado"}
            };
        }
        public Customer GetCustomer(int i)
        {
            return customers[i];
        }
        // GET: Customers
        public ActionResult Index()
        {
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomer(id-1);
            return View(customer);
        }
    }
}