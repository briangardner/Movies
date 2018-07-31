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
        private readonly string _category;

        public Movie(string title, string category)
        {
            _title = title;
            _category = category;
        }

        public string Title => _title;
        public string Category => _category;


    }
}
