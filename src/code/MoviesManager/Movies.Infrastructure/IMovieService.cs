using Movies.Application.ViewModels;
using System.Collections.Generic;

namespace Movies.Infrastructure
{
    public interface IMovieService
    {
        IEnumerable<Movie> RetrieveMovies();
        void AddMovie(Movie movie);
    }
}