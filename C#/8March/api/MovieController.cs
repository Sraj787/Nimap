using ProboVideo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProboVideo.Controllers.api
{
    public class MovieController : ApiController
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

        [HttpGet]
        [Authorize(Roles = RolesName.ManageMovie)]
        public IEnumerable<Movie> Get()
        {
            var MovieALL = _context.Movies.ToList();

            return MovieALL;
        }
        [HttpGet]
        public Movie GetMovie(int id)
        {
            var movieByid = _context.Movies.FirstOrDefault(x => x.Id == id);

            return movieByid;
        }

        [HttpPost]
        [Authorize(Roles = RolesName.ManageMovie)]
        public Movie Create(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
            return movie;
        }
        [HttpPut]
        [Authorize(Roles = RolesName.ManageMovie)]
        public Movie Update(int id, Movie movie)
        {
            var movieDbModel = _context.Movies.FirstOrDefault(m=>m.Id == id);

            movieDbModel.Title = movie.Title;
            movieDbModel.Description = movie.Description;
            movieDbModel.AddedDate = movie.AddedDate;
            movieDbModel.ReleaseDate= movie.ReleaseDate;
            movieDbModel.genreId = movie.genreId;
            movieDbModel.NumberInStock = movie.NumberInStock;

            _context.SaveChanges();

            return movie;
        }
        [HttpDelete]
        [Authorize(Roles = RolesName.ManageMovie)]
        public string Delete(int id)
        {
            var deleteModel = _context.Movies.FirstOrDefault(m=>m.Id == id);

            _context.Movies.Remove(deleteModel);
            _context.SaveChanges();

            return "SuccessFully Movie Details are deleted.";
        }
    }
}
