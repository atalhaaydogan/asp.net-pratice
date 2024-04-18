using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieApp.Web.Entity
{
    public class Movie
    {
        // Primary Key => Id, <TypeName>Id
        //[Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MovieId { get; set; }
        [Required]
        public string Title { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        [Required]
        public Genre Genre { get; set; } // navigation property

        public int GenreId { get; set; } 
    }
}
