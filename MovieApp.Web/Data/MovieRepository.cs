using MovieApp.Web.Models;
using System.Collections.Generic;
using System.Linq;

namespace MovieApp.Web.Data
{
    public class MovieRepository
    {
        private static readonly List<Movie> _movies = null;

        static MovieRepository()
        {
            _movies = new List<Movie>()
            {
                new Movie
                {
                    MovieId = 1,
                    Title = "film 1",
                    Description = "açıklama 1",
                    Director = "yönetmen 1",
                    Players = new string[] { "oyuncu 1", "oyuncu 2" },
                    ImageUrl = "1.jpg"
                },
                new Movie
                {
                    MovieId = 2,
                    Title = "film 2",
                    Description = "açıklama 1",
                    Director = "yönetmen 1",
                    Players = new string[] { "oyuncu 2", "oyuncu 2" },
                    ImageUrl = "2.jpg"
                },
                new Movie
                {
                    MovieId = 3,
                    Title = "film 1",
                    Description = "açıklama 1",
                    Director = "yönetmen 1",
                    Players = new string[] { "oyuncu 1", "oyuncu 2" },
                    ImageUrl = "3.jpg"
                },
                new Movie
                {
                    MovieId = 4,
                    Title = "film 1",
                    Description = "açıklama 1",
                    Director = "yönetmen 1",
                    Players = new string[] { "oyuncu 1", "oyuncu 2" },
                    ImageUrl = "1.jpg"
                },
                new Movie
                {
                    MovieId = 5,
                    Title = "film 2",
                    Description = "açıklama 1",
                    Director = "yönetmen 1",
                    Players = new string[] { "oyuncu 2", "oyuncu 2" },
                    ImageUrl = "2.jpg"
                },
                new Movie
                {
                    MovieId = 6,
                    Title = "film 1",
                    Description = "açıklama 1",
                    Director = "yönetmen 1",
                    Players = new string[] { "oyuncu 1", "oyuncu 2" },
                    ImageUrl = "3.jpg"
                }
            };
        }

        public static List<Movie> Movies
        {
            get
            {
                return _movies;
            }
        }

        public static void Add(Movie movie)
        {
            _movies.Add(movie);
        }

        public static Movie GeyById(int id)
        {
            return _movies.FirstOrDefault(m => m.MovieId == id);
        }
    }
}
