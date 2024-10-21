using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSysytem.ActionRequests.Books
{
    public class UpdateBookActionRequest
    {
        [Required(ErrorMessage = "Please, Enter Book ID")]
        public int ID { get; set; }
        [Required(ErrorMessage = "Please, Enter Book Title")]
        [StringLength(100, ErrorMessage = "Book Title Characters Shouldn’t be more than 100 character")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please, Enter Book Genre")]
        public string Genre { get; set; }
        [Required(ErrorMessage = "Please, Enter Book Author")]
        public string Author { get; set; }
        [Required(ErrorMessage = "Please, Enter Book Amount")]
        [Range(1, 1000, ErrorMessage = "Book Amount must be between 1 to 1000")]
        public int Amount { get; set; }
        //public string Image { get; set; }
        [Required(ErrorMessage = "Please, Enter Book DailyRent")]
        [Range(1, 100, ErrorMessage = "Daily Rent must be between 1 to 100 EGP")]
        public decimal Daily_Rent { get; set; }
        [Required(ErrorMessage = "Please, Enter Your ID")]
        [Range(1, 100, ErrorMessage = "Your Id must be between 1 to 100")]
        public int LibrarianID_FK { get; set; }
    }
}
