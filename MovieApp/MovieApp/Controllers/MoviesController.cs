using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieApp.Models;

namespace MovieApp.Controllers
{

    public class MoviesController : Controller
    {
        private List<Movie> movies;

        public MoviesController()
        {
            movies = new List<Movie>()
            {
                new Movie(){Id=1,Name="Brzi i Žestoki"},
                new Movie(){Id=2,Name="Spašavanje vojnika Rajana"}
            };
        }
        // GET: Movies
        public ActionResult Index()
        {
            return View(movies);
        }
    }
}