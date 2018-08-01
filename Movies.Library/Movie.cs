using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Library
{
    public class Movie
    {
        private readonly string _title;
        private readonly Enums.MovieCategories _category;

        public Movie(string title, Enums.MovieCategories category)
        {
            _title = title;
            _category = category;
        }

        public string Title => _title;
        public Enums.MovieCategories Category => _category;


    }
}
