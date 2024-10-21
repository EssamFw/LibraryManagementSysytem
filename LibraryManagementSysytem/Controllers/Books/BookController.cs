using BusinessLayer.DTOs.Books;
using BusinessLayer.Services.Books;
using LibraryManagementSysytem.ActionRequests.Books;
using LibraryManagementSysytem.VMs.Books;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSysytem.Controllers.Books
{
    [Authorize(Roles = "Admin")]
    public class BookController : Controller
    {
        private readonly IBookService _BookService;

        public BookController(IBookService BookService)
        {
            _BookService = BookService;

        }

        //[HttpGet]
        //public async Task<IActionResult> Index()
        //{
        //    var BooksDTO = await _BookService.GetAllBooks();
        //    var BooksVM = BooksDTO.Select(b => (BookListVM)b).ToList();

        //    return View(BooksVM);

        //}

        //[HttpPost]
        public async Task<IActionResult> Index(string searchTerm)
        {
            var BooksDTO = await _BookService.Search(searchTerm);

            var BooksVM = BooksDTO.Select(b => (BookListVM)b).ToList();


            return View(BooksVM);

        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddBookActionRequest Book, IFormFile imageFile)
        {

            if (ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors);
                foreach (var error in errors)
                {
                    // You can log or display the error message
                    Console.WriteLine(error.ErrorMessage);
                }


                #region UploadImageFile

                string UniqueFileName = Guid.NewGuid().ToString() + "_" + imageFile.FileName;

                if (imageFile != null && imageFile.Length > 0)
                {

                    var filePath = Path.Combine(@".\wwwroot\Images\", UniqueFileName);
                    using (var filestraem = new FileStream(filePath, FileMode.Create))
                    {
                        imageFile.CopyTo(filestraem);
                    }
                }

                #endregion

                var AddBookDTO = new AddBookDTO

                {
                    Title = Book.Title,
                    Genre = Book.Genre,
                    Author = Book.Author,
                    Amount = Book.Amount,
                    DailyRent = Book.Daily_Rent,
                    LibrarianID = Book.LibrarianID_FK,
                    Image = UniqueFileName
                };
                await _BookService.AddBook(AddBookDTO);
                TempData["SuccessMessage"] = "Book added successfully!";
                return RedirectToAction(nameof(Index));

            }

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var BookDTO = await _BookService.GetById(id);
            var BookVM = (BookDetailsVM)BookDTO;

            return View(BookVM);
        }

        [HttpGet]
        public async Task<IActionResult> Update()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateBookActionRequest updateBook, IFormFile imageFile)
        {

            var BookToUpdate = await _BookService.GetById(updateBook.ID);

            if (ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors);
                foreach (var error in errors)
                {
                    // You can log or display the error message
                    Console.WriteLine(error.ErrorMessage);
                }
                #region UploadImageFile

                string UniqueFileName = Guid.NewGuid().ToString() + "_" + imageFile.FileName;

                if (imageFile != null && imageFile.Length > 0)
                {

                    var filePath = Path.Combine(@".\wwwroot\Images\", UniqueFileName);
                    using (var filestraem = new FileStream(filePath, FileMode.Create))
                    {
                        imageFile.CopyTo(filestraem);
                    }
                }

                #endregion
                BookToUpdate = new BookDetailsDTO()
                {
                    ID = updateBook.ID,
                    Title = updateBook.Title,
                    Genre = updateBook.Genre,
                    Author = updateBook.Author,
                    Amount = updateBook.Amount,
                    Daily_Rent = updateBook.Daily_Rent,
                    Image = UniqueFileName,
                    LibrarianID = updateBook.LibrarianID_FK
                };
                await _BookService.UpdateBook(BookToUpdate);
                await _BookService.SaveChanges();
                TempData["SuccessMessage"] = "Book Updated successfully!";
                return RedirectToAction(nameof(Index));
            }

            return View();
        }

        public async Task<IActionResult> Remove(int id)
        {
            await _BookService.DeleteBookById(id);
            return RedirectToAction(nameof(Index));
            return View();
        }
    }
}
