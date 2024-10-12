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
        List<Librarian> GetAll();
        Librarian? GetLibrarianbyId(int id);
        void Add(Librarian id);

        void update(Librarian id);
        void Delete(int id);

        void SaveChanges();

    }
}
