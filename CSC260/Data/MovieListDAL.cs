using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSC260.Models;
using CSC260.Interfaces;

namespace CSC260.data
{

    public class MovieListDAL : IDataAccessLayer
    {
        /*        private static List<Movie> movieList = new List<Movie>
                {
                    new Movie("Iron Man", 2008, 5.0f),
                    new Movie("Star Wars", 1977, rating: 4.3f),
                    new Movie("WandaVision", 2021, rating: 4.5f),
                    new Movie("Terminator 2", 1991, rating: 4.2f),
                    new Movie("Incredible Hulk", 2007, rating: 4.0f)
                };*/

        private MovieContext db;

        public void AddMovie(Movie movie)
        {
            movieList.Add(movie);
        }

        public Movie GetMovie(int? id)
        {
            Movie foundMovie = null;

            if(id != null)
            {
                movieList.ForEach(m =>
                {
                    if (m.ID == id)
                    {
                        foundMovie = m;
                    }
                });
            }

            return foundMovie;
        }

        public IEnumerable<Movie> GetMovies()
        {
            return db.Movies.ToList();
        }

        public void RemoveMovie(int? id)
        {
            if(id>0)
            {
                db.Movies.Remove(db.Movie.Find(id));
                db.SaveChanges();
            }
/*            var foundMovie = GetMovie(id);
            if(foundMovie != null)
            {
                movieList.Remove(foundMovie);
            }*/
        }
    }
}
