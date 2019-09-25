using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Car
    {
        Engine Engine;
        public Car()
        {

        }

        public void AddEngine(Engine engine)
        {
            Engine = engine;
        }
    }

    class Engine
    {

    }

    class Book
    {
        List<Page> pages;
        public Book()
        {
            pages = new List<Page>();
        }
    }

    class MovieTheater
    {
        BoxOffice BoxOffice;
        List<Movie> movies;

        public MovieTheater(List<Movie> mv)
        {
            BoxOffice = new BoxOffice();
            movies = mv;
        }

        public void AddMove(Movie mv)
        {
            movies.Add(mv);
        }
    }

    class BoxOffice
    {

    }

    class Movie
    {

    }

    class Page
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            Engine myEngine = new Engine();
            myCar.AddEngine(myEngine);

            Book myBook = new Book();

            List<Movie> movies = new List<Movie>();
            MovieTheater myMovieTheater = new MovieTheater(movies);
        }
    }
}
