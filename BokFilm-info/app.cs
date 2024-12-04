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
            
            bool running = true;
            while (running)
            {   
                Console.Clear();
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
                        running = false;
                        break;
                }
            }
            

        }

        public void ShowMovies()
        {
            Console.Clear();
            Console.Write("List of your movies:\n");
            foreach (var movie in movies)
            {
                Console.WriteLine($"{movie._movie} ({movie._year})");
                Console.WriteLine($"About: {movie._genre}");
                Console.WriteLine("--------------------------------");
            }
            Console.WriteLine("Press ENTER to go back to menu");
            Console.ReadLine();
        }

        public void AddMovies()
        {
            Console.Clear();
            Console.Write("Movie title: ");
            _movie = Console.ReadLine();

             Console.Write("Year of the movie: ");
            _year = Console.ReadLine();

            Console.Write("Genre of the movie: ");
            _genre = Console.ReadLine();

            movies.Add(new Movie(_movie, _year, _genre));
            ShowNewest();
        }

        public void ShowNewest()
        {
            Console.Clear();
            Console.WriteLine($"Added new movie:\n ");
            Console.WriteLine($"{_movie} ({_year})");
            Console.WriteLine($"About: {_genre}");
            Console.WriteLine("--------------------------------");

            Console.WriteLine("Press ENTER to go back to menu");
            Console.ReadLine();
        }
    }
}
