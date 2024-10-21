using BusinessLayer.DTOs.Books;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services.Books
{
    public interface IBookService
    {
        public Task<List<BookListDTO>> GetAllBooks();
        public Task<int> GetMaxId();
        public Task AddBook(AddBookDTO book);
        public Task<BookDetailsDTO?> GetById(int id);
        public Task UpdateBook(BookDetailsDTO updatebook);
        public Task DeleteBookById(int id);
        public Task SaveChanges();

        public Task<List<BookListDTO>> Search(string searchTerm);
    }
}
