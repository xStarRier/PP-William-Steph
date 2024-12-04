using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BokFilm_info
{
    internal class Movie
    {
        public string _movie {  get; private set; }
        public string _year { get; private set; }
        public string _genre { get; private set; }

        public Movie(string movie, string year, string genre)
        {
            _movie = movie;
            _year = year;
            _genre = genre;
        }

    }
}
