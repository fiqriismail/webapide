using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Repository
{
    public class MovieService : IMovieRepository
    {
        public List<Movie> GenerateMovies()
        {
            List<Movie> movies = new List<Movie>();
            for (int i = 1; i <= 10; i++)
            {
                movies.Add(new Movie()
                {
                    Id = i,
                    Title = $"Title {i}",
                    ReleasedDate = DateTime.Now
                });
            }

            return movies;
        }
    }
}
