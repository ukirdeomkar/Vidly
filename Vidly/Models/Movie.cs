namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }



        public MovieGenre Genre { get; set; }
        public int GenreId { get; set; }

        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }
        public  int  NumberOfStocks { get; set; }

    }

    // route -> /movies/random
}
