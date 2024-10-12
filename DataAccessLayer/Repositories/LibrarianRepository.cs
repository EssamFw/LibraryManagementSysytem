using DataAccessLayer.context;
using DataAccessLayer.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class LibrarianRepository : ILibrarianRepository
    {
        private readonly ApplicationDbContext _dbcontext;
        public LibrarianRepository(ApplicationDbContext dbContext)
        {
            _dbcontext = dbContext;
        }
        public void Add(Librarian librarian)
        {
            _dbcontext.Librarians.Add(librarian);
        }

        public void Delete(int id)
        {
            var librarian=_dbcontext.Librarians.FirstOrDefault(p=>p.ID==id);
            if (librarian != null)
            {
                _dbcontext.Librarians.Remove(librarian);
            }
        }

        public List<Librarian> GetAll()
        {
            return _dbcontext.Librarians.ToList();
        }

        public Librarian? GetLibrarianbyId(int id)
        {
            return _dbcontext.Librarians.FirstOrDefault( librarian=>librarian.ID == id);
        }

        public void update(Librarian librarian)
        {
            _dbcontext.Librarians.Update(librarian);
        }

        public void SaveChanges()
        {
            _dbcontext.SaveChanges();
        }
    }
}
