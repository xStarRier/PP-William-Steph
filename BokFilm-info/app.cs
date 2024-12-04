using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BokFilm_info
{
    internal class App
    {
        public string _movie { get; private set; }
        public string _year { get; private set; }
        public string _genre { get; private set; }

        List<Movie> movies = new List<Movie>()
        {
            new Movie("Shrek", "2001", "Fantasy"),
            new Movie("Shrek 2", "2004", "Action/Adventure")
            
        };

        public void Run()
        {
            Console.WriteLine("1. See movie list");
            Console.WriteLine("2. Add movie");
            Console.WriteLine("3. Quit");
            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    ShowMovies();
                    break;
                case "2":
                    AddMovies();
                 
                    break;
                case "3":
                    
                    break;

            }

        }

        public void ShowMovies()
        {

            Console.Write("List of your movies:\n");
            foreach (var movie in movies)
            {
                Console.WriteLine($"{movie._movie} ({movie._year})");
                Console.WriteLine($"About: {movie._genre}");
                Console.WriteLine("--------------------------------");
            }


        }
        public void AddMovies()
        {   
            Console.Write("Movie title: ");
            _movie = Console.ReadLine();
             Console.WriteLine("Year of the movie: ");
            _year = Console.ReadLine();
            Console.WriteLine("Genre of the movie: ");
            _genre = Console.ReadLine();
            movies.Add(new Movie(_movie, _year, _genre));
            Run();
        }
    }
}
