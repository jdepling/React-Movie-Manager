using Movies.Application.ViewModels;
using System.Collections.Generic;

namespace Movies.Infrastructure
{
    public interface IMovieService
    {
        IEnumerable<Movie> RetrieveMovies();
        void AddMovie(Movie movie);
        public Movie GetMovie(int id);
        public void DeleteMovie(int id);
       
    }
}