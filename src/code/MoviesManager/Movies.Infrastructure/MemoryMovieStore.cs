using Movies.Application.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Movies.Infrastructure
{
    public class MemoryMovieStore : IMovieStore
    {
        public List<Movie> Movies { get; private set; }

        public MemoryMovieStore()
        {
            Movies = new List<Movie>
            {
                new Movie()
                {
                    Name = "Pocahauntus",
                    Genre = Genre.Children.ToString(),
                    Minutes = 65,
                    Rating = MPAA.G.ToString(),
                    Id = 10001
                },
                new Movie()
                {
                    Name = "Red",
                    Genre = Genre.Action.ToString(),
                    Minutes = 65,
                    Rating = MPAA.PG13.ToString(),
                    Id = 10002
                }
            };
        }

        public IEnumerable<Movie> RetrieveMovies()
        {
            return Movies;
        }

        public void AddMovie(Movie movie)
        {
            movie.Id = Movies.Count + 10001;
            Movies.Add(movie);
        }
    }
}
