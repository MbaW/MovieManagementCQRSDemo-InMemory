using MovieManagement.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.Library.Data
{
    public class DataRepository : IDataRepository
    {
        private static List<MovieModel> _movieModels = new List<MovieModel>()
        {
            new MovieModel{ Id= Guid.NewGuid(), Name= "Movie 1", Cost= 100 },
            new MovieModel{ Id= Guid.NewGuid(), Name= "Movie 2", Cost= 200 },
            new MovieModel{ Id= Guid.NewGuid(), Name= "Movie 3", Cost= 300 }
        };
        public MovieModel AddMovie(MovieModel movie)
        {
            _movieModels.Add(movie);
            return movie;
        }
        public List<MovieModel> GetMovies()
        {
            return _movieModels;
        }
    }
}