using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSC260.Models;
using CSC260.Interfaces;

namespace CSC260.data
{

    public class FavoriteMoviesDAL : IDataAccessLayer
    {
        private static List<Movie> movieList = new List<Movie>
        {
            new Movie("Spider-Man", 2002, 5.0f),
            new Movie("John Wick", 2010, 4.3f),
            new Movie("Tangled", 2010, 4.5f),
            new Movie("Space balls", 1987, 2.0f)

        };

        public void AddMovie(Movie movie)
        {
            movieList.Add(movie);
        }

        public Movie GetMovie(int? id)
        {
            Movie foundMovie = null;

            if (id != null)
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
            return movieList;
        }

        public void RemoveMovie(int? id)
        {
            var foundMovie = GetMovie(id);
            if (foundMovie != null)
            {
                movieList.Remove(foundMovie);
            }
        }
    }
}
