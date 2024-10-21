using DataAccessLayer.context;
using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories.Books
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public BookRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Book>> GetAllBooks()
        {
            return await _dbContext.Books.ToListAsync();
        }

        public async Task<int> GetMaxId()
        {
            return await _dbContext.Books.MaxAsync(Book => Book.ID);
        }
        public async Task AddBook(Book Book)
        {

            await _dbContext.AddAsync(Book);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Book?> GetById(int id)
        {
            var Book = await _dbContext.Books.AsNoTracking().FirstOrDefaultAsync(Book => Book.ID == id);
            return Book;

        }
        public async Task SaveChanges()
        {
            await _dbContext.SaveChangesAsync();
        }


        public async Task UpdateBook(Book updatebook)
        {

            _dbContext.Update(updatebook);
            await _dbContext.SaveChangesAsync();

        }


        public async Task DeleteBookById(int id)
        {
            var book = await _dbContext.Books.FirstOrDefaultAsync(Book => Book.ID == id);
            if (book != null)
            {
                _dbContext.Remove(book);
                await _dbContext.SaveChangesAsync();

            }
        }
    }
}
