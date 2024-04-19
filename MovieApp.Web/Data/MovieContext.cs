﻿using Microsoft.EntityFrameworkCore;
using MovieApp.Web.Entity;

namespace MovieApp.Web.Data
{
    public class MovieContext: DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options):base(options)
        {
            
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Person> People { get; set; }

    }
}
