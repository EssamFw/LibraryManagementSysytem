using BusinessLayer.DTOs;
using DataAccessLayer.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public interface ILibrarianService
    {
        Task<List<LibrarianListDTO>> GetAll();
        Task< LibrarianDetailsDTO?> GetbyId(int id);

        Task UpdateLibrarian(Librarian updatedLibrarian);
        Task AddLibrarian(AddLibrarianDTO librarianDTO);
        Task DeleteLibrarian(int id);



    }
}
