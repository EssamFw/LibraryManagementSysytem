using BusinessLayer.DTOs.Librarians;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories.Librarians;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services.Librarians
{
    public class LibrarianService : ILibrarianService

    {
        private readonly ILibrarianRepository _librarianRepository;
        public LibrarianService(ILibrarianRepository liprarianarepository)
        {
            _librarianRepository = liprarianarepository;
        }

        public async Task<List<LibrarianListDTO>> GetAll()
        {
            var LibrarianEntities = await _librarianRepository.GetAll();
            var librarians =
                LibrarianEntities.Select(entity => (LibrarianListDTO)entity)
                .ToList();

            return librarians;
        }
        public async Task<LibrarianDetailsDTO?> GetById(int id)
        {
            var librarianEntity = await _librarianRepository.GetLibrarianbyId(id);
            var librarianDTO = new LibrarianDetailsDTO()
            {
                ID = librarianEntity.ID,
                First_Name = librarianEntity.First_Name,
                Last_Name = librarianEntity.Last_Name,
                Phone = librarianEntity.Phone,

            };
            return librarianDTO;
        }

        public async Task AddLibrarian(AddLibrarianDTO librarianDTO)
        {
            Librarian librarian = librarianDTO.ToLibrarian();
            _librarianRepository.Add(librarian);
            _librarianRepository.SaveChanges();
        }


        public async Task UpdateLibrarian(Librarian updatedlibrarian)
        {
            _librarianRepository.update(updatedlibrarian);
            _librarianRepository.SaveChanges();
        }

        public async Task<LibrarianDetailsDTO?> GetbyId(int id)
        {

            var libraroanEntity = await _librarianRepository.GetLibrarianbyId(id); // استبدل Librarians باسم مجموعة المكتبيين في DbContext
            var librarianDTO = new LibrarianDetailsDTO()
            {
                ID = libraroanEntity.ID,
                First_Name = libraroanEntity.First_Name,
                Last_Name = libraroanEntity.Last_Name,
                Email = libraroanEntity.Email,
                Phone = libraroanEntity.Phone

            };
            return librarianDTO;
        }
        //        if (librarian == null)
        //        {
        //            return null; // أو يمكنك رمي استثناء هنا حسب احتياجاتك
        //        }

        //        // تحويل الكائن إلى DTO
        //        var librarianDTO = new LibrarianDetailsDTO
        //        {
        //            ID = librarian.ID,
        //            First_Name = librarian.First_Name,
        //            Last_Name = librarian.Last_Name,
        //            Email = librarian.Email,
        //            Phone = librarian.Phone
        //        };

        //        return librarianDTO;
        //}



        public async Task DeleteLibrarian(int id)
        {
            await _librarianRepository.Delete(id);
            _librarianRepository.SaveChanges();

        }

    }
}
