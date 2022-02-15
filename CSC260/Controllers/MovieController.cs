using CSC260.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSC260.Interfaces;
using CSC260.data;

namespace CSC260.Controllers
{
    public class MovieController : Controller
    {

        //IDataAccessLayer dal = new MovieListDAL();
        IDataAccessLayer dal;
       

        public MovieController(IDataAccessLayer indal)
        {
            dal = indal;
        }

        [HttpGet]
        public IActionResult AddMovie()
        {
            //Movie m = new Movie("Spiderman", 2002, 4.99f);
            return View("MovieForm");
        }       
        [HttpPost]
        public IActionResult AddMovie(Movie movie)
        {
            //if(string.IsNullOrEmpty(movie.Title))
            //{
            //    ModelState.AddModelError("Title", "Title cannot be empteeeee");
            //}

            if (ModelState.IsValid)
            {
                dal.RemoveMovie(movie.ID);
                dal.AddMovie(movie);
                return Redirect("/Movie/Index");
            }
            return View("MovieForm");
        }

        public IActionResult EditMovie(int id)
        {
            Movie m;
            m = dal.GetMovie(id);
            dal.RemoveMovie(id);

            return View("MovieForm", m);
        }

        public IActionResult Index()
        {
            return View(dal.GetMovies().OrderBy(m => m.ReleaseDate).ToList());
            //return View(movieList);
        }
        public IActionResult DisplayMovie()
        {
            Movie m = new Movie("Iron Man", 2008, 5.0f);
            return View(m);
        }
    }
}
