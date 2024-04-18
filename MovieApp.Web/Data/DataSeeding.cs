using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieApp.Web.Entity;
using System.Collections.Generic;
using System.Linq;

namespace MovieApp.Web.Data
{
    public static class DataSeeding
    {
        public static void Seed(IApplicationBuilder app)
        {
            var scope = app.ApplicationServices.CreateScope();
            var context = scope.ServiceProvider.GetService<MovieContext>();

            context.Database.Migrate(); // dotnet ed databese update

            var genres = new List<Genre>()
                        {

                            new Genre {Name = "Mecara", Movies=
                                new List<Movie>(){
                                     new Movie {
                                        Title = "yeni macera filmi 1",
                                        Description = "açıklama 1",
                                        ImageUrl = "1.jpg",
                                    },
                                    new Movie {
                                        Title = "yeni macera filmi 2",
                                        Description = "açıklama 1",
                                        ImageUrl = "2.jpg",
                                    },

                                } 
                            },
                            new Genre {Name = "Komedi"},
                            new Genre {Name = "Romantik"},
                            new Genre {Name = "Savaş"},
                            new Genre {Name = "Bilim Kurgu"}
                        };
            var movies = new List<Movie>()
                            {
                                new Movie
                                {
                                    Title = "film 1",
                                    Description = "açıklama 1",
                                    ImageUrl = "1.jpg",
                                    Genre = genres[0]
                                },
                                new Movie
                                {
                                    Title = "film 2",
                                    Description = "açıklama 1",
                                    ImageUrl = "2.jpg",
                                    Genre = genres[1]
                                },
                                new Movie
                                {
                                    Title = "film 3",
                                    Description = "açıklama 1",
                                    ImageUrl = "3.jpg",
                                    Genre = genres[1]
                                },
                                new Movie
                                {
                                    Title = "film 4",
                                    Description = "açıklama 1",
                                    ImageUrl = "1.jpg",
                                    Genre = genres[2]
                                },
                                new Movie
                                {
                                    Title = "film 5",
                                    Description = "açıklama 1",
                                    ImageUrl = "1.jpg",
                                    Genre = genres[3]
                                },
                            };

            if (context.Database.GetPendingMigrations().Count()==0)
            {
                if (context.Genres.Count() == 0)
                {
                    context.Genres.AddRange(genres);
                }
                if (context.Movies.Count()==0)
                {
                    context.Movies.AddRange(movies);
                }
                
                context.SaveChanges();
            }
        }
    }
}
