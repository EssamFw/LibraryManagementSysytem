using DataAccessLayer.context;
using DataAccessLayer.entities;

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
                TempData["Success"] = "تم الإضافة بنجاح";

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
            Librarian? LibrarianfromDB = _db.Librarians.Find(id);
            //Librarian? LibrarianfromDB1 = _db.Librarians.FirstOrDefault(u=>u.ID==id);
            //Librarian? LibrarianfromDB2 = _db.Librarians.Where(u=>u.ID==id).FirstOrDefault();
            if (LibrarianfromDB==null)
            {
                return NotFound();
            }
            return View(LibrarianfromDB);
        }



        [HttpPost]
        public IActionResult Edit(Librarian lib)
        {
            //if(lib.First_Name.ToLower() == lib.DisplayOrder.Tostring)
            if (ModelState.IsValid)
            {
                _db.Librarians.Update(lib);
                _db.SaveChanges();
                TempData["Success"] = "تم تحديث البيانات بنجاح";

                return RedirectToAction("Index");

            }
            return View();

        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Librarian? LibrarianfromDB = _db.Librarians.Find(id);

            if (LibrarianfromDB == null)
            {
                return NotFound();
            }
            return View(LibrarianfromDB);
        }



        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
                Librarian? Lib = _db.Librarians.Find(id);
                if (Lib == null)
                {
                    return NotFound();
                }
                _db.Librarians.Remove(Lib);
                _db.SaveChanges();
            TempData["Success"] = "تم الحذف بنجاح";
                return RedirectToAction("Index");
        }
    }
}
