using DataAccessLayer.context;
using DataAccessLayer.entities;
using LibraryManagementSysytem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Members
{
    public class MemberRepository : IMemberRepository
    {
        private readonly ApplicationDbContext _dbcontext;
        public MemberRepository(ApplicationDbContext dbContext)
        {
            _dbcontext = dbContext;
        }
        public async Task Add(Member member)
        {
            await _dbcontext.Members.AddAsync(member);
        }

        public async Task Delete(int id)
        {
            var member = await _dbcontext.Members.FirstOrDefaultAsync(p => p.ID == id);
            if (member != null)
            {
                _dbcontext.Members.Remove(member);
            }
        }

        public async Task<List<Member>> GetAll()
        {
            return await _dbcontext.Members.ToListAsync();
        }

        public async Task<Member?> GetMemberbyId(int id)
        {
            return await _dbcontext.Members.FirstOrDefaultAsync(member => member.ID == id);
        }
        public void update(Member member)
        {
            _dbcontext.Members.Update(member);
        }
        public async Task SaveChanges()
        {
            await _dbcontext.SaveChangesAsync();
        }

    }
}
