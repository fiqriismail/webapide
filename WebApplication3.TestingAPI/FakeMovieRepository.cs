using System;
using System.Collections.Generic;
using System.Text;
using WebApplication3.Models;
using WebApplication3.Repository;

namespace WebApplication3.TestingAPI
{
    public class FakeMovieRepository : IMovieRepository
    {
        public List<Movie> GenerateMovies()
        {
            var movies = new List<Movie>();
            movies.Add(new Movie() { Id = 1, ReleasedDate = DateTime.Now, Title = "Test Title 1" });
            return movies;
        }
    }
}
