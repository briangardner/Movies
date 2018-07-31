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
                Console.Write($"What Category are you interested in? (Action, Comedy, or Drama)");
                var input = Console.ReadLine();
                Console.WriteLine();
                switch (input)
                {
                    case "Action":
                        ListMoviesByCategory(movies, "Action");
                        break;
                    case "Comedy":
                        ListMoviesByCategory(movies, "Comedy");
                        break;
                    case "Drama":
                        ListMoviesByCategory(movies, "Drama");
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

        private static void ListMoviesByCategory(ArrayList movies, string category)
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
                new Movie("Office Space", "Comedy"),
                new Movie("Monty Python and the Quest for the Holy Grail", "Comedy"),
                new Movie("Spaceballs", "Comedy"),
                new Movie("Hitchickers Guide To the Galaxy", "Comedy"),
                new Movie("Blazing Saddles", "Comedy"),
                new Movie("Braveheart", "Action"),
                new Movie("Gladiator", "Action"),
                new Movie("Snatch", "Action"),
                new Movie("Lock Stock and Two Smoking Barrels", "Action"),
                new Movie("Casino Royale", "Action"),
                new Movie("King's Speech", "Drama"),
                new Movie("Cool Hand Luke", "Drama"),
                new Movie("Shawshank Redemption", "Drama"),
                new Movie("The Color of Money", "Drama"),
                new Movie("The Usual Suspects", "Drama"),
            };

            arrayList.Add(new Movie("Gone with the Wind 2: Breaking Wind", "Comedy:"));
            return arrayList;
        }
    }
}
