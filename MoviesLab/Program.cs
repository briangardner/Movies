using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movies.Library;

namespace MoviesLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Movie List Application");
            var movies = GetMovies();
            do
            {
                Console.WriteLine($"There are {movies.Count} movies in this list.");
                Console.Write("What Category are you interested in?\n1. Action \n2. Comedy \n3. Drama");
                var input = (Enums.MovieCategories) int.Parse(Console.ReadKey().KeyChar.ToString());
                Console.WriteLine();
                switch (input)
                {
                    case Enums.MovieCategories.Action:
                        ListMoviesByCategory(movies, Enums.MovieCategories.Action);
                        break;
                    case Enums.MovieCategories.Comedy:
                        ListMoviesByCategory(movies, Enums.MovieCategories.Comedy);
                        break;
                    case Enums.MovieCategories.Drama:
                        ListMoviesByCategory(movies, Enums.MovieCategories.Drama);
                        break;
                    default:
                        Console.WriteLine("I'm sorry, that is not a category option.");
                        break;
                    
                }
                if (!ShouldContinue())
                {
                    break;
                }
            } while (true);
        }

        private static void ListMoviesByCategory(ArrayList movies, Enums.MovieCategories category)
        {
            
            foreach (Movie movie in movies)
            {
                if (movie.Category == category)
                {
                    Console.WriteLine($"{movie.Title}");
                }
            }
        }

        private static bool ShouldContinue()
        {
            do
            {
                Console.WriteLine("Continue y/n");
                var input = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (input != 'y' && input != 'n')
                {
                    continue;
                }

                return input == 'y';
            } while (true);
        }

        private static ArrayList GetMovies()
        {
            var arrayList = new ArrayList()
            {
                new Movie("Office Space", Enums.MovieCategories.Comedy),
                new Movie("Monty Python and the Quest for the Holy Grail", Enums.MovieCategories.Comedy),
                new Movie("Spaceballs", Enums.MovieCategories.Comedy),
                new Movie("Hitchickers Guide To the Galaxy", Enums.MovieCategories.Comedy),
                new Movie("Blazing Saddles", Enums.MovieCategories.Comedy),
                new Movie("Braveheart", Enums.MovieCategories.Action),
                new Movie("Gladiator", Enums.MovieCategories.Action),
                new Movie("Snatch", Enums.MovieCategories.Action),
                new Movie("Lock Stock and Two Smoking Barrels", Enums.MovieCategories.Action),
                new Movie("Casino Royale", Enums.MovieCategories.Action),
                new Movie("King's Speech", Enums.MovieCategories.Drama),
                new Movie("Cool Hand Luke", Enums.MovieCategories.Drama),
                new Movie("Shawshank Redemption", Enums.MovieCategories.Drama),
                new Movie("The Color of Money", Enums.MovieCategories.Drama),
                new Movie("The Usual Suspects", Enums.MovieCategories.Drama),
            };

            return arrayList;
        }
    }
}
