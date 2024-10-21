using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace LibraryManagementSysytem.ActionRequests.Members
{
    public class CreateMemberActionRequest
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(100)]
        [Required]
        [DisplayName("First Name")]


        public string First_Name { get; set; }

        [MaxLength(100)]
        [Required]
        [DisplayName("Last Name")]

        public string Last_Name { get; set; }

        [MaxLength(100)]
        [EmailAddress]
        [Required]

        [DisplayName("Email Address")]

        public string Email { get; set; }

        [MaxLength(20)]
        [Required]
        [DisplayName("Phone Number")]

        public string Phone { get; set; }
    }
}
