using DataAccessLayer.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Entities
{
    public class Book
    {
        public int ID { get; set; }

        [Required, MaxLength(255)]
        public string Title { get; set; }

        [MaxLength(100)]
        public string Genre { get; set; }

        [MaxLength(255)]
        public string Author { get; set; }

        public int Amount { get; set; }

        [MaxLength(255)]
        public string Image { get; set; }

        [MaxLength(50)]
        public string Status { get; set; }

        public decimal Daily_Rent { get; set; }

        [ForeignKey("Librarian")]
        public int LibrarianID_FK { get; set; }

        public Librarian Librarian { get; set; }
    }

}
