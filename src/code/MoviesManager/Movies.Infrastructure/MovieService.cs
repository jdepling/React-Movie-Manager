using Movies.Application.ViewModels;
using System;
using System.Collections.Generic;

namespace Movies.Infrastructure
{
    public class MovieService : IMovieService
    {
        private readonly IMovieStore _movieStore;

        public MovieService(IMovieStore movieStore)
        {
            _movieStore = movieStore ?? throw new ArgumentNullException(nameof(movieStore));
        }

        /// <summary>
        /// Adds a movie
        /// </summary>
        public void AddMovie(Movie movie)
        {
            _movieStore.AddMovie(movie);
        }

        /// <summary>
        /// Returns a list of all movies 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Movie> RetrieveMovies()
        {
            return _movieStore.RetrieveMovies(); // TODO - map domain model to view model
               
        }
    }
}
