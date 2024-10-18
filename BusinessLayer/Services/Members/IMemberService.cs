using BusinessLayer.DTOs;
using BusinessLayer.DTOs.Members;
using DataAccessLayer.entities;
using LibraryManagementSysytem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services.Members
{
    public interface IMemberService
    {
        Task<List<MemberListDTO>> GetAll();
        Task<MemberDetailsDTO?> GetbyId(int id);

        Task UpdateMember(Member updatedMember);
        Task AddMember(AddMemberDTO memberDTO);
        Task DeleteMember(int id);
    }
}
