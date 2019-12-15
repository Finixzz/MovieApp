using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieApp.Models;
namespace MovieApp.ViewModel
{
    public class MovieFormViewModel
    {
        public IEnumerable <Genre> Genres { get; set; }
        public Movie Movie { get; set; }
    }
}