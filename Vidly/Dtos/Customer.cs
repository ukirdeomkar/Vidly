using System.ComponentModel.DataAnnotations;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        [Required(ErrorMessage = "Please select a valid Membership Type.")]
        public int MembershipTypeId { get; set; }

        [Class18YearsIfMember]
        public DateTime? BirthDate { get; set; }
    }
}
