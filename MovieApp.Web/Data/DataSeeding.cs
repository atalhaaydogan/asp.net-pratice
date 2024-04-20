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
            var users = new List<User>() {
                new User() { Username="usera", Email="usera@gmail.com", Password="1234", ImageUrl="person1.jpg"},
                new User() { Username="userb", Email="userb@gmail.com", Password="1234", ImageUrl="person2.jpg"},
                new User() { Username="userc", Email="userc@gmail.com", Password="1234", ImageUrl="person3.jpg",},
                new User() { Username="userb", Email="userb@gmail.com", Password="1234", ImageUrl="person4.jpg"}
            };
            var people = new List<Person>()
            {
                new Person()
                {
                    Name = "Personel 1",
                    Biography = "tanıtım 1",
                    User = users[0]
                },
                new Person()
                {
                    Name = "Personel 2",
                    Biography = "tanıtım 2",
                    User = users[1]
                }
            };
            var crews = new List<Crew>()
            {
                new Crew() { Movie=movies[0], Person=people[0], Job="Yönetmen"},
                new Crew() { Movie=movies[0], Person=people[1], Job="Yönetmen Yard"}
            };
            var casts = new List<Cast>()
            {
                new Cast() { Movie=movies[0], Person=people[0], Name="Oyuncu Adı 1", Character="Karakter 1"},
                new Cast() { Movie=movies[0], Person=people[1], Name="Oyuncu Adı 2", Character="Karakter 2"}
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

                if (context.Users.Count() == 0)
                {
                    context.Users.AddRange(users);
                }

                if (context.People.Count() == 0)
                {
                    context.People.AddRange(people);
                }

                if (context.Casts.Count() == 0)
                {
                    context.Casts.AddRange(casts);
                }

                if (context.Crews.Count() == 0)
                {
                    context.Crews.AddRange(crews);
                }

                context.SaveChanges();
            }
        }
    }
}
