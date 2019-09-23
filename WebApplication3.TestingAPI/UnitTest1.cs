using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Controllers;
using WebApplication3.Models;
using Xunit;

namespace WebApplication3.TestingAPI
{
    public class UnitTest1
    {
        MoviesController _controller;
        FakeMovieRepository _service;

        public UnitTest1()
        {
            _service = new FakeMovieRepository();
            _controller = new MoviesController(_service);
        }

        [Fact]
        public void Get_Call_Check_For_OK_Result()
        {
            //Act
            var result = _controller.Get();

            //Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void Get_Call_Check_For_List_Of_Movies()
        {
            //Act
            var okResult = _controller.Get() as OkObjectResult;

            //Assert
            Assert.IsType<List<Movie>>(okResult.Value);

        }
    }
}
