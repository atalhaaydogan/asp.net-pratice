using MovieApp.Web.Entity;
using MovieApp.Web.Models;
using System;
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
                    ImageUrl = "1.jpg",
                    GenreId = 1
                },
                new Movie
                {
                    MovieId = 2,
                    Title = "film 2",
                    Description = "açıklama 1",
                    Director = "yönetmen 1",
                    Players = new string[] { "oyuncu 2", "oyuncu 2" },
                    ImageUrl = "2.jpg",
                    GenreId = 1
                },
                new Movie
                {
                    MovieId = 3,
                    Title = "film 3",
                    Description = "açıklama 1",
                    Director = "yönetmen 1",
                    Players = new string[] { "oyuncu 1", "oyuncu 2" },
                    ImageUrl = "3.jpg",
                    GenreId = 3
                },
                new Movie
                {
                    MovieId = 4,
                    Title = "film 4",
                    Description = "açıklama 1",
                    Director = "yönetmen 1",
                    Players = new string[] { "oyuncu 1", "oyuncu 2" },
                    ImageUrl = "1.jpg",
                    GenreId = 4
                },
                new Movie
                {
                    MovieId = 4,
                    Title = "film 5",
                    Description = "açıklama 1",
                    Director = "yönetmen 1",
                    Players = new string[] { "oyuncu 1", "oyuncu 2" },
                    ImageUrl = "1.jpg",
                    GenreId = 4
                },
                new Movie
                {
                    MovieId = 4,
                    Title = "film 6",
                    Description = "açıklama 1",
                    Director = "yönetmen 1",
                    Players = new string[] { "oyuncu 1", "oyuncu 2" },
                    ImageUrl = "1.jpg",
                    GenreId = 4
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
            movie.MovieId = Movies.Count() + 1;
            _movies.Add(movie);
        }

        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(m => m.MovieId == id);
        }
        public static void Edit(Movie m)
        {
            foreach (var movie in _movies)
            {
                if (movie.MovieId == m.MovieId)
                {
                    movie.Title = m.Title;
                    movie.Description = m.Description;
                    movie.Director = m.Director;
                    movie.ImageUrl = m.ImageUrl;
                    movie.GenreId = m.GenreId;
                    break;


                }
            }
        }
        public static void Delete(int MovieId)
        {
            var movie = GetById(MovieId);
            if (movie != null)
            {
                _movies.Remove(movie);
            }
        }

    }
}
