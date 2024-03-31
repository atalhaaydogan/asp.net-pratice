using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MovieApp.Web.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        [DisplayName("Başlık")]
        [Required(ErrorMessage = "film başlığı eklemelisiniz.")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "film başlığı 5-50 aralığında olmalıdır.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "film açıklaması eklemelisiniz.")]
        public string Description { get; set; }
        public string Director { get; set; }
        public string[] Players { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        public int? GenreId { get; set; } // null
    }
}
