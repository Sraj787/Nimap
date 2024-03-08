using ProboVideo.Models;
using ProboVideo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProboVideo.Controllers
{
    public class MovieController : Controller
    {

        private ApplicationDbContext _context;

        public MovieController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Movie
        public ActionResult Index()
        {

            var movie = _context.Movies.ToList();
          /*  var movie = new Movie() { Title = "Shark!" };
            var customer = new List<Customer>
        {
                new Customer{ Name="Customer 1"},
                new Customer{ Name="Customer 2"},
                new Customer{ Name="Customer 3"}
            };

            var viewModel = new RandomModel
            {
                Movie = movie,
                Customer = customer
            };*/

            return View(movie);
        }
         public ActionResult Save(Movie movie) {

            if(movie.Id==0)
                _context.Movies.Add(movie);
            else
            {
                var MovieDb = _context.Movies.SingleOrDefault(a=>a.Id==movie.Id);

                MovieDb.Title = movie.Title;
                MovieDb.Description = movie.Description;
                MovieDb.AddedDate = movie.AddedDate;
                MovieDb.ReleaseDate = movie.ReleaseDate;
                MovieDb.NumberInStock = movie.NumberInStock;
            }

             _context.SaveChanges();

            return View("Index","Movie");
        }
        public ActionResult New()
        {
            var moviegenre = _context.Genres.ToList();

            var viewModel = new RandomModel
            {
                Movie = new Movie(),
                Genres = moviegenre
            };
           return View("MovieForm",viewModel);
        }
        public ActionResult Edit(int id)
        {
            var movies = _context.Movies.SingleOrDefault(c => c.Id == id);
            if (movies == null)
            {
                return HttpNotFound();
            }
            var viewModel = new RandomModel
            {
                Movie = new Movie(),
                Genres = _context.Genres.ToList()
            };
            return View("MovieForm", viewModel);
        }
    }
}