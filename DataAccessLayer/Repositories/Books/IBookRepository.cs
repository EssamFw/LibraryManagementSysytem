using DataAccessLayer.Entities;

namespace DataAccessLayer.Repositories.Books
{
    public interface IBookRepository
    {
        public Task<List<Book>> GetAllBooks();
        public Task<int> GetMaxId();
        public Task AddBook(Book Book);
        public Task<Book?> GetById(int id);
        public Task SaveChanges();
        public Task UpdateBook(Book updatebook);
        public Task DeleteBookById(int id);
    }
}
