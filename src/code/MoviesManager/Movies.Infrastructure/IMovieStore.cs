using Movies.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Infrastructure
{
    public interface IMovieStore
    {
        IEnumerable<Movie> RetrieveMovies(); // TODO - this needs to be the domain movie model not the view model
        void AddMovie(Movie movie);
    }
}
