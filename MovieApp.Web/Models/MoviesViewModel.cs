using System.Collections.Generic;

namespace MovieApp.Web.Models
{
    public class MoviesViewModel
    {
        public List<Movie> Movies { get; set; }
        public List<Genre> Genres { get; set; }
    }
}
