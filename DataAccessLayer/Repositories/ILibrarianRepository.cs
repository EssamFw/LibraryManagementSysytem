using DataAccessLayer.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public interface ILibrarianRepository
    {


        Task<List<Librarian>> GetAll();
        Task<Librarian?> GetLibrarianbyId(int id);
        Task Add(Librarian id);

        void update(Librarian id);
        Task Delete(int id);

        Task SaveChanges();
      
    }
}
