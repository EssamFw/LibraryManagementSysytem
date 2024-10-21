using BusinessLayer.DTOs.Books;
using DataAccessLayer.Repositories.Books;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services.Books
{
    public class BookService : IBookService
    {
        public readonly IBookRepository _BookRepository;
        public BookService(IBookRepository BookRepository)
        {
            _BookRepository = BookRepository;
        }

        public async Task<List<BookListDTO>> GetAllBooks()
        {
            var BookEntities = await _BookRepository.GetAllBooks();
            var BooksDTO = BookEntities.Select(entity => (BookListDTO)entity).ToList();
            return BooksDTO;

        }

        public Task<int> GetMaxId()
        {
            return _BookRepository.GetMaxId();
        }

        public async Task AddBook(AddBookDTO book)
        {


            var BookDTO = book;

            if (book.Amount > 0)
            {
                book.status = "Available";
            }
            else
            {
                book.status = "Not Available Now";
            }

            Book Book = new Book()
            {

                //ID = await  _BookRepository.GetMaxId()+1,
                Title = book.Title,
                Author = book.Author,
                Daily_Rent = book.DailyRent,
                Amount = book.Amount,
                Genre = book.Genre,
                LibrarianID_FK = book.LibrarianID,
                Status = book.status,
                Image = book.Image

            };
            await _BookRepository.AddBook(Book);
            await _BookRepository.SaveChanges();


        }

        public async Task<BookDetailsDTO?> GetById(int id)
        {

            var BookDetails = await _BookRepository.GetById(id);

            var BookDTO = (BookDetailsDTO)BookDetails;

            return BookDTO;
        }

        public async Task UpdateBook(BookDetailsDTO updatebook)
        {


            if (updatebook.Amount > 0)
            {
                updatebook.status = "Available";
            }
            else
            {
                updatebook.status = "Not Available Now";
            }

            var BookDTO = updatebook;
            var Book = new Book()
            {
                ID = BookDTO.ID,
                Title = BookDTO.Title,
                Author = BookDTO.Author,
                Amount = BookDTO.Amount,
                Status = BookDTO.status,
                Image = BookDTO.Image,
                Genre = BookDTO.Genre,
                Daily_Rent = BookDTO.Daily_Rent,
                LibrarianID_FK = BookDTO.LibrarianID
            };

            await _BookRepository.UpdateBook(Book);
            await _BookRepository.SaveChanges();

        }

        public async Task DeleteBookById(int id)
        {
            await _BookRepository.DeleteBookById(id);
            await _BookRepository.SaveChanges();
        }

        public async Task SaveChanges()
        {
            await _BookRepository.SaveChanges();
        }

        public async Task<List<BookListDTO>> Search(String searchTerm)
        {
            var BookEntities = await _BookRepository.GetAllBooks();
            var BookSearchDTO = BookEntities.Select(b => (BookListDTO)b).ToList();

            if (string.IsNullOrEmpty(searchTerm))
            {
                return BookSearchDTO;
            }
            else
            {

                return BookSearchDTO
                    .Where(p => p.Title.Contains(searchTerm) || p.Genre.Contains(searchTerm) || p.Author.Contains(searchTerm))
                    .ToList();
            }

        }
    }
}
