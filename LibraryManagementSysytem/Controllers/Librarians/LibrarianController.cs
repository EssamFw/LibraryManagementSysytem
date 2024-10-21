using DataAccessLayer.context;
using DataAccessLayer.Entities;
using LibraryManagementSysytem.Models;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.DTOs.Librarians;
using BusinessLayer.Services.Librarians;
using LibraryManagementSysytem.ActionRequests.Librarians;
using LibraryManagementSysytem.VMs.Librarians;
using Microsoft.AspNetCore.Authorization;

namespace LibraryManagementSysytem.Controllers.Librarians
{
    [Authorize(Roles = "Admin")]
    public class LibrarianController : Controller
    {

        private readonly ILibrarianService _librarianService;
        public LibrarianController(ILibrarianService librarianService)
        {
            _librarianService = librarianService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<LibrarianListDTO> librarianDTOs = await _librarianService.GetAll();
            var librarians = new List<LibrarianListVM>();
            foreach (var entity in librarianDTOs)
            {
                librarians.Add(new LibrarianListVM()
                {
                    ID = entity.ID,
                    First_Name = entity.First_Name,
                    Last_Name = entity.Last_Name,
                    Email = entity.Email,
                    Phone = entity.Phone
                });

            }
            return View("Index", librarians);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateLibrarianActionRequest librarian)
        {
            if (ModelState.IsValid)
            {
                AddLibrarianDTO librarianDTO = new AddLibrarianDTO()
                {
                    First_Name = librarian.First_Name,
                    Last_Name = librarian.Last_Name,
                    Email = librarian.Email,
                    Phone = librarian.Phone
                };
                await _librarianService.AddLibrarian(librarianDTO);
                //return RedirectToAction(nameof(Index));

                TempData["Success"] = "تم الإضافة بنجاح";

                return RedirectToAction("Index");

            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {

            LibrarianDetailsDTO librarianDTO = await _librarianService.GetbyId(id);

            if (librarianDTO == null)
            {
                return NotFound();
            }

            //var librarianVM = new LibrarianEditVM
            EditLibrarianDTO librarianDTO1 = new EditLibrarianDTO()
            {
                ID = librarianDTO.ID,
                First_Name = librarianDTO.First_Name,
                Last_Name = librarianDTO.Last_Name,
                Email = librarianDTO.Email,
                Phone = librarianDTO.Phone
            };



            return View(librarianDTO);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(Librarian librarian)
        {
            if (ModelState.IsValid)
            {

                EditLibrarianDTO updatedLibrarian = new EditLibrarianDTO()
                {
                    ID = librarian.ID,
                    First_Name = librarian.First_Name,
                    Last_Name = librarian.Last_Name,
                    Email = librarian.Email,
                    Phone = librarian.Phone
                };
                await _librarianService.UpdateLibrarian(librarian);
                TempData["Success"] = "تم التعديل بنجاح";
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {

            var librarianDTO = await _librarianService.GetbyId(id);

            if (librarianDTO == null)
            {
                return NotFound();
            }

            //var librarianVM = new LibrarianEditVM
            LibrarianDetailsDTO librarianDTO1 = new LibrarianDetailsDTO()
            {
                ID = librarianDTO.ID,
                First_Name = librarianDTO.First_Name,
                Last_Name = librarianDTO.Last_Name,
                Email = librarianDTO.Email,
                Phone = librarianDTO.Phone
            };



            return View(librarianDTO);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteLibrarian(int id)
        {

            if (ModelState.IsValid)
            {

                await _librarianService.DeleteLibrarian(id);
                TempData["Success"] = "تم الحذف بنجاح";
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}
//***********************************************************************************

//    public IActionResult Delete(int? id)
//    {
//        if (id == null || id == 0)
//        {
//            return NotFound();
//        }
//        Librarian? LibrarianfromDB = _librarianService.DeleteLibrarian(id);

//        if (LibrarianfromDB == null)
//        {
//            return NotFound();
//        }
//        return View(LibrarianfromDB);
//    }



//    [HttpPost, ActionName("Delete")]
//    public async Task<IActionResult> DeleteConfirmed(int? id)
//    {
//        if (id == null)
//        {
//            return NotFound();
//        }

//        await _librarianService.DeleteLibrarian((int)id);
//        TempData["Success"] = "تم الحذف بنجاح";
//        return RedirectToAction("Index");
//    }
//}

