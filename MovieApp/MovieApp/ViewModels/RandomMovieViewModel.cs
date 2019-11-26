using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieApp.Models;
namespace MovieApp.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie movie { get; set; }
        public List<Customer> customerList { get; set; }

        public void setMovie()
        {
            movie.Name = "Brzi i Zestoki";
        }

        public void setCustomers()
        {
            customerList.Add(new Customer() {Id=1, Name = "Edo" });
            customerList.Add(new Customer() {Id=2, Name = "Ado" });
        }

        public string getName(int i)
        {
            return customerList[i].Name;
        }

        public int getId(int i)
        {
            return customerList[i].Id;
        }

    }
}