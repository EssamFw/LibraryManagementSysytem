using DataAccessLayer.Entities;

namespace BusinessLayer.DTOs.Books

{
    public class BookDetailsDTO
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
        public int Amount { get; set; }
        public string Image { get; set; }
        public string status { get; set; }
        public decimal Daily_Rent { get; set; }
        public int LibrarianID { get; set; }

        public static explicit operator BookDetailsDTO(Book book)
        {
            return new BookDetailsDTO()
            {
                ID = book.ID,
                Title = book.Title,
                Genre = book.Genre,
                Author = book.Author,
                Amount = book.Amount,
                status = book.Status,
                Daily_Rent = book.Daily_Rent,
                LibrarianID = book.LibrarianID_FK,
                Image = book.Image
            };
        }
    }
}
