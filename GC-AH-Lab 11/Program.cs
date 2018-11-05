using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_AH_Lab_11
{
    class Movie
    {
        private string Title;
        private string Category;

        public Movie(string title, string category)
        {
            Title = title;
            Category = category;
        }

        public string GetTitle()
        {
            return Title;
        }

        public string GetCategory()
        {
            return Category;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> vhs = MovieDatabase.MovieList();

            while (true)
            {
                Console.WriteLine("Scifi / Action / Fantasy / Drama / Comedy / Horror");
                Console.WriteLine("============");
                Console.WriteLine("Please enter a movie genre from the list above:");
                var genre = Console.ReadLine();
                Console.WriteLine("============");

                foreach (var movie in vhs)
                {
                    if (string.Equals(genre, movie.GetCategory(), StringComparison.CurrentCultureIgnoreCase))
                    {
                        Console.WriteLine(movie.GetTitle());
                    }
                }

                while (true)
                {
                    Console.Write("Continue? (y/n):");
                    var answer = Console.ReadLine();

                    if (answer == "n")
                    {
                        return;
                    }
                    else if (answer == "y")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input--either y to continue or n to exit:");
                        continue;
                    }
                }
            }
            //Console.ReadKey();
        }








        //private static List<Movie> MovieList()
        //{
        //    List<Movie> vhs = new List<Movie>();
        //    vhs.Add(new Movie("Star Wars", "Scifi"));
        //    vhs.Add(new Movie("The Terminator", "Scifi"));
        //    vhs.Add(new Movie("Die Hard", "Action"));
        //    vhs.Add(new Movie("Lethal Weapon", "Action"));
        //    vhs.Add(new Movie("Harry Potter", "Fantasy"));
        //    vhs.Add(new Movie("House of Cards", "Drama"));
        //    vhs.Add(new Movie("The Office", "Comedy"));
        //    vhs.Add(new Movie("Friends", "Comedy"));
        //    vhs.Add(new Movie("Lord of the Rings", "Fantasy"));
        //    vhs.Add(new Movie("Clash of the Titans", "Fantasy"));
        //    vhs.Add(new Movie("The fast and the furious", "Action"));
        //    return vhs;
        //}
    }
}
