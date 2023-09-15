using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customer

    {
        public int Id { get; set; }


        [Display(Name = "Customer Name")]

        public string Name { get; set; }

        [Display(Name = "Subscribe to Newsletter")]
        public bool IsSubscribedToNewsLetter { get; set; }



        public MembershipType MembershipType { get; set; }

        
        [Display(Name = "Membership Type")]

        public int MembershipTypeId { get; set; }

        [Display(Name = "Date Of Birth")]
        //[Class18YearsIfMember]
        public DateTime? BirthDate { get; set; }

    }
}
