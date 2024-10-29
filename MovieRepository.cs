using ApplicationCore.Contracts.Repository;
using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class MovieRepository : IMovieRepository
    {
       public List<Movie> GetMovies(  )
        {
            List<Movie> movies = new List<Movie>();
            for (int i = 0; i < 10; i++)
            {
                Movie movie = new Movie();
                movie.name = "moviename" + i;
                movie.year = 2024;
                movies.Add( movie );
            }
            return movies;
        }
        
    }
}
