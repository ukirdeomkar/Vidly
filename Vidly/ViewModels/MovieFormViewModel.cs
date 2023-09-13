using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<MovieGenre> MovieGenre{ get; set; }
        public Movie Movie { get; set; }
    }
}
