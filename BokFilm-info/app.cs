using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BokFilm_info
{
    internal class App
    {

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
                    break;
                case "3":
                    break;

            }

        }

        public void ShowMovies()
        {

            Console.Write("List of your movies: ");
            foreach (var movie in movies)
            {
                Console.WriteLine($"{movie._movie}");
                Console.WriteLine($"About: {movie._genre} {movie._year}");
                Console.Write("--------------------------------");
            }


        }
    }
}
