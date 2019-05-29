using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreMovieApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace CoreMovieApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int? Id)
        {
            var movies = MovieRepository.Movies;
            if (Id!=null)
            {
                movies = movies.Where(x => x.CategoryID == Id).ToList();
            }
            return View(movies);
        }
    }
}