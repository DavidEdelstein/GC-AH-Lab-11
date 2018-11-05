using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_AH_Lab_11
{
    class MovieDatabase
    {
        public static List<Movie> MovieList()
        {
            List<Movie> vhs = new List<Movie>();
            vhs.Add(new Movie("Star Wars", "Scifi"));
            vhs.Add(new Movie("The Terminator", "Scifi"));
            vhs.Add(new Movie("Die Hard", "Action"));
            vhs.Add(new Movie("Lethal Weapon", "Action"));
            vhs.Add(new Movie("Harry Potter", "Fantasy"));
            vhs.Add(new Movie("House of Cards", "Drama"));
            vhs.Add(new Movie("The Office", "Comedy"));
            vhs.Add(new Movie("Friends", "Comedy"));
            vhs.Add(new Movie("The Lord of the Rings", "Fantasy"));
            vhs.Add(new Movie("Clash of the Titans", "Fantasy"));
            vhs.Add(new Movie("The Fast and the Furious", "Action"));
            vhs.Add(new Movie("Conan the Barbarian", "Fanatasy"));
            vhs.Add(new Movie("The Wizard of OZ", "Fanatasy"));
            vhs.Add(new Movie("The Godfather", "Drama"));
            vhs.Add(new Movie("Goodfellas", "Drama"));
            vhs.Add(new Movie("Gladiator", "Drama"));
            vhs.Add(new Movie("2001: A Space Odyssey", "Scifi"));
            vhs.Add(new Movie("Airplane", "Comedy"));
            vhs.Add(new Movie("Meet the Parents", "Comedy"));
            vhs.Add(new Movie("21 Jump Street", "Comedy"));
            vhs.Add(new Movie("IT", "Horror"));
            vhs.Add(new Movie("The Ring", "Horror"));
            vhs.Add(new Movie("The Texas Chainsaw Massacre", "Horror"));
            vhs.Add(new Movie("The Shining", "Horror"));
            vhs.Add(new Movie("Holloween", "Horror"));
            vhs.Add(new Movie("The Exorcist", "Horror"));
            vhs.Add(new Movie("Blade Runner", "Scifi"));
            vhs.Add(new Movie("The Matrix", "Scifi"));
            vhs.Add(new Movie("Minority Report", "Scifi"));
            return vhs;
        }
    }
}
