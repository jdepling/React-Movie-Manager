using Microsoft.AspNetCore.Mvc;
using Movies.Application.ViewModels;
using Movies.Infrastructure;
using System;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MoviesWebApi.Controllers
{
    [Route("api/[controller]")]
    public class MoviesController : Controller
    {
        private readonly IMovieService _movieService;

        /// <summary>
        /// Constructor that specifies dependencies
        /// </summary>
        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService ?? throw new ArgumentNullException(nameof(movieService));
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            var movies = _movieService.RetrieveMovies();
            return movies;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]Movie movie)
        {
            _movieService.AddMovie(movie);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
