using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;
using WebApplication3.Repository;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private IMovieRepository _movieService;

        public MoviesController(IMovieRepository movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var movies = _movieService.GenerateMovies();
            return Ok(movies);
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var movies = _movieService.GenerateMovies();
            var movie = movies.SingleOrDefault(m => m.Id == id);

            if (movie == null)
            {
                return StatusCode(StatusCodes.Status404NotFound);
            }

            return Ok(movie);
        }

        
    }

    
}