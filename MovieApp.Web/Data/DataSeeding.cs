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

            context.Database.Migrate();

            if(context.Database.GetPendingMigrations().Count()==0)
            {
                if(context.Movies.Count()==0)
                {
                    context.Movies.AddRange(
                        new List<Movie>()
                            {
                                new Movie
                                {
                                    Title = "film 1",
                                    Description = "açıklama 1",
                                    ImageUrl = "1.jpg",
                                    GenreId = 1
                                },
                                new Movie
                                {
                                    Title = "film 2",
                                    Description = "açıklama 1",
                                    ImageUrl = "2.jpg",
                                    GenreId = 1
                                },
                                new Movie
                                {
                                    Title = "film 3",
                                    Description = "açıklama 1",
                                    ImageUrl = "3.jpg",
                                    GenreId = 3
                                },
                                new Movie
                                {
                                    Title = "film 4",
                                    Description = "açıklama 1",
                                    ImageUrl = "1.jpg",
                                    GenreId = 4
                                },
                                new Movie
                                {
                                    Title = "film 5",
                                    Description = "açıklama 1",
                                    ImageUrl = "1.jpg",
                                    GenreId = 4
                                },
                                new Movie
                                {
                                    Title = "film 6",
                                    Description = "açıklama 1",
                                    ImageUrl = "1.jpg",
                                    GenreId = 4
                                }
                            }

                    );
                }
                if (context.Genres.Count() == 0)
                {
                    context.Genres.AddRange(
                        new List<Genre>()
                        {

                            new Genre {Name = "Mecara"},
                            new Genre {Name = "Komedi"},
                            new Genre {Name = "Romantik"},
                            new Genre {Name = "Savaş"},
                            new Genre {Name = "Bilim Kurgu"}
                        }
                    );
                }

                context.SaveChanges();
            }
        }
    }
}
