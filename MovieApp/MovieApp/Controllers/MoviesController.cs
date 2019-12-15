using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieApp.ViewModel;
namespace MovieApp.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context { get; set; }
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Movies
        public ActionResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre);
            return View(movies);
        }

        public ActionResult New()
        {
            var DBgenreTypes = _context.Genres;
            var viewModel = new MovieFormViewModel()
            {
                Genres = DBgenreTypes
            };
            return View("MovieForm",viewModel);
        }

        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.Single(m => m.Id == id);
            if (movie is null)
                return HttpNotFound();
            var viewModel = new MovieFormViewModel()
            {
                Movie = movie,
                Genres = _context.Genres
            };
            return View("MovieForm", viewModel);
        }

        [HttpPost]
        public ActionResult Save(Movie movie)
        {
            if (movie.Id == 0)
                _context.Movies.Add(movie);
            else
            {
                var DBmovie = _context.Movies.Single(m => m.Id == movie.Id);
                DBmovie.Name = movie.Name;
                DBmovie.ReleaseDate = movie.ReleaseDate;
                DBmovie.GenreId = movie.GenreId;
                DBmovie.StockNumber = movie.StockNumber;
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Movies");
        }


    }
}