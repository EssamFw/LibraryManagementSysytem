using DataAccessLayer.entities;
using LibraryManagementSysytem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Members
{
    public interface IMemberRepository
    {
        Task<List<Member>> GetAll();
        Task<Member?> GetMemberbyId(int id);
        Task Add(Member id);

        void update(Member id);
        Task Delete(int id);

        Task SaveChanges();
    }
}
