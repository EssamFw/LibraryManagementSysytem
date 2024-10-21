using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Entities
{
    public class Member
    {
        public int ID { get; set; }

        [MaxLength(100)]
        public string First_Name { get; set; }

        [MaxLength(100)]
        public string Last_Name { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }

        [MaxLength(20)]
        public string Phone { get; set; }
    }

}
