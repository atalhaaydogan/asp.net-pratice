using MovieApp.Web.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace MovieApp.Web.Data
{
    public class GenreRepository
    {
        private static readonly List<Genre> _genres = null;

        static GenreRepository()
        {
            _genres = new List<Genre>()
            {
                 
                new Genre {GenreId=1,Name = "Mecara"},
                new Genre {GenreId=2,Name = "Komedi"},
                new Genre {GenreId=3,Name = "Romantik"},
                new Genre {GenreId=4,Name = "Savaş"}
            };
        }

        public static List<Genre> Genres
        {
            get
            {
                return _genres;
            }
        }

        public static void Add(Genre genre)
        {
            _genres.Add(genre);
        }

        public static Genre GetById(int id) 
        {
            return _genres.FirstOrDefault(g=>g.GenreId == id);  
        }
    }
}
