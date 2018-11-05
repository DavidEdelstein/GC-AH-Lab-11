using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_AH_Lab_11
{
    // James - It's pretty common convention to put your classes in a seperate file.  so this could exist in something like Movie.cs. 
    // this helps make your code more organized.
    class Movie
    {
        // James - for private fields, it's common convention to keep the name lower case and or to have an underscore in front of 
        // it. ie  private string _title;
        // also, as syntatctic sugar you could completely change how you handle getting the information and completely remove 
        // your private fields, by using properties.  
        // for example...
        //
        // public string Title { get; }
        //
        // this is a property that only Gets the data, ie, it's readonly and public outside of the class. this would 
        // also remove your GetTitle() method.
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
            // James - I like this solution a bunch.
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





        // James - when you push your code, please remove commented code.


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
