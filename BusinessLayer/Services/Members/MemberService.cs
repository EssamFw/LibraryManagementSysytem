using BusinessLayer.DTOs;
using BusinessLayer.DTOs.Members;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories;
using DataAccessLayer.Repositories.Members;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services.Members
{
    public class MemberService :IMemberService
    {
        private readonly IMemberRepository _memberRepository;
        public MemberService(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }

        public async Task<List<MemberListDTO>> GetAll()
        {
            var MemberEntities = await _memberRepository.GetAll();
            var members =
                MemberEntities.Select(entity => (MemberListDTO)entity)
                .ToList();

            return members;
        }
        public async Task<MemberDetailsDTO?> GetById(int id)
        {
            var memberEntity = await _memberRepository.GetMemberbyId(id);
            var memberDTO = new MemberDetailsDTO()
            {
                ID = memberEntity.ID,
                First_Name = memberEntity.First_Name,
                Last_Name = memberEntity.Last_Name,
                Phone = memberEntity.Phone,

            };
            return memberDTO;
        }

        public async Task AddMember(AddMemberDTO memberDTO)
        {
            Member member = memberDTO.ToMember();
            _memberRepository.Add(member);
            _memberRepository.SaveChanges();
        }


        public async Task UpdateMember(Member updatedmember)
        {
            _memberRepository.update(updatedmember);
            _memberRepository.SaveChanges();
        }

        public async Task<MemberDetailsDTO?> GetbyId(int id)
        {

            var memberEntity = await _memberRepository.GetMemberbyId(id); 
            var memberDTO = new MemberDetailsDTO()
            {
                ID = memberEntity.ID,
                First_Name = memberEntity.First_Name,
                Last_Name = memberEntity.Last_Name,
                Email = memberEntity.Email,
                Phone = memberEntity.Phone

            };
            return memberDTO;
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



        public async Task DeleteMember(int id)
        {
            await _memberRepository.Delete(id);
            _memberRepository.SaveChanges();

        }
    }
}
