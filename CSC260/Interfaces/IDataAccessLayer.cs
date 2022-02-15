using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSC260.Models;

namespace CSC260.Interfaces
{

    public interface IDataAccessLayer
    {
        IEnumerable<Movie> GetMovies();

        void AddMovie(Movie movie);

        void RemoveMovie(int? id);

        Movie GetMovie(int? id);
    }
}
