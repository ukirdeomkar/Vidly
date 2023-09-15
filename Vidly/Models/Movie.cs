using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Movie Name")]
        public string Name { get; set; }



        public MovieGenre Genre { get; set; }
        public int GenreId { get; set; }

        [Required]
        [Display(Name = "Date of Release")]
        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }
        [Required ]
        [Range(1,20)]
        [Display(Name="Number of Stocks")]
        public  int  NumberOfStocks { get; set; }

    }

    // route -> /movies/random
}
