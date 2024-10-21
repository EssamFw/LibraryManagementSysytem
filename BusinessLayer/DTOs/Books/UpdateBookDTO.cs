using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTOs.Books
{
    public class UpdateBookDTO
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
        public int Amount { get; set; }
        public string Image { get; set; }
        public string status { get; set; }
        public decimal DailyRent { get; set; }
        public int LibrarianID { get; set; }
    }
}
