using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater
{
    class MovieTheater
    {
        BoxOffice BoxOffice;
        List<Movie> Movies;

        public MovieTheater()
        {
            BoxOffice = new BoxOffice();
            Movies = new List<Movie>();
        }

        public void AddMovie (Movie mv)
        {
            Movies.Add(mv);
        }

        public bool RemoveMovie(string movieName)
        {
            return false;
        }
    }

    class BoxOffice { }

    class Movie { }

    class Program
    {
        static void Main(string[] args)
        {
            MovieTheater myMovieTheater = new MovieTheater();
            Movie myMovie = new Movie();

            myMovieTheater.AddMovie(myMovie);

            Console.Read();

        }
    }
}
