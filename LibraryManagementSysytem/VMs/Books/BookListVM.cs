using BusinessLayer.DTOs.Books;

namespace LibraryManagementSysytem.VMs.Books
{
    public class BookListVM
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
        public int Amount { get; set; }
        public string Image { get; set; }
        public string status { get; set; }
        public decimal Daily_Rent { get; set; }
        public int LibrarianID_FK { get; set; }

        public string searchTerm { get; set; }

        public static explicit operator BookListVM(BookListDTO book)
        {
            return new BookListVM()
            {
                ID = book.ID,
                Title = book.Title,
                Genre = book.Genre,
                Author = book.Author,
                Amount = book.Amount,
                Image = book.Image,
                status = book.status,
                Daily_Rent = book.Daily_Rent,
                LibrarianID_FK = book.LibrarianID_FK,

            };
        }
    }
}
