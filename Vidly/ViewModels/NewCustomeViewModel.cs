using Vidly.Models;

namespace Vidly.ViewModels
{
    public class NewCustomeViewModel
    {
        public IEnumerable<MembershipType> MembershipType { get; set; }
        public Customer Customer { get; set; }
    }
}
