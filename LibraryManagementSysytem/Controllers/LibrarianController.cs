using LibraryManagementSysytem.Data;
using LibraryManagementSysytem.Models;

using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSysytem.Controllers
{
    public class LibrarianController : Controller
    {
        private readonly ApplicationDbContext _db;
        public LibrarianController(ApplicationDbContext db)
        {
             _db = db;
        }
        public IActionResult Index()
        {
            List<Librarian> LibrarianList=_db.Librarians.ToList();
            return View(LibrarianList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Librarian lib)
        {
            //if(lib.First_Name.ToLower() == lib.DisplayOrder.Tostring)
            if (ModelState.IsValid)
            {
                _db.Librarians.Add(lib);
                _db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View();

        }
        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            Librarian LibrarianfromDB = _db.Librarians.Find(id);
            if (LibrarianfromDB==null)
            {
                return NotFound();
            }
            return View(LibrarianfromDB);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Librarian lib)
        {
            //if(lib.First_Name.ToLower() == lib.DisplayOrder.Tostring)
            if (ModelState.IsValid)
            {
                _db.Librarians.Add(lib);
                _db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View();

        }
    }
}
