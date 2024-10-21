using DataAccessLayer.context;
using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Librarians
{
    public class LibrarianRepository : ILibrarianRepository
    {
        private readonly ApplicationDbContext _dbcontext;
        public LibrarianRepository(ApplicationDbContext dbContext)
        {
            _dbcontext = dbContext;
        }
        public async Task Add(Librarian librarian)
        {
            await _dbcontext.Librarians.AddAsync(librarian);
        }

        public async Task Delete(int id)
        {
            var librarian = await _dbcontext.Librarians.FirstOrDefaultAsync(p => p.ID == id);
            if (librarian != null)
            {
                _dbcontext.Librarians.Remove(librarian);
            }
        }

        public async Task<List<Librarian>> GetAll()
        {
            return await _dbcontext.Librarians.ToListAsync();
        }

        public async Task<Librarian?> GetLibrarianbyId(int id)
        {
            return await _dbcontext.Librarians.FirstOrDefaultAsync(librarian => librarian.ID == id);
        }
        public void update(Librarian librarian)
        {
            _dbcontext.Librarians.Update(librarian);
        }
        public async Task SaveChanges()
        {
            await _dbcontext.SaveChangesAsync();
        }



    }
}
