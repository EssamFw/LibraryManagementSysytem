using BusinessLayer.DTOs;
using BusinessLayer.DTOs.Members;
using BusinessLayer.Services;
using BusinessLayer.Services.Members;
using DataAccessLayer.Entities;
using LibraryManagementSysytem.ActionRequests.Members;
using LibraryManagementSysytem.Models;
using LibraryManagementSysytem.VMs.Members;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSysytem.Controllers.Members
{
    public class MemberController : Controller
    {
        //    private readonly IMemberService _memberService;
        private readonly IMemberService _memberService;
        public MemberController(IMemberService memberService)
        {
            _memberService = memberService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<MemberListDTO> memberDTOs = await _memberService.GetAll();
            var members = new List<MemberListVM>();
            foreach (var entity in memberDTOs)
            {
                members.Add(new MemberListVM()
                {
                    ID = entity.ID,
                    First_Name = entity.First_Name,
                    Last_Name = entity.Last_Name,
                    Email = entity.Email,
                    Phone = entity.Phone
                });

            }
            return View("Index", members);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateMemberActionRequest member1)
        {
            if (ModelState.IsValid)
            {
                AddMemberDTO memberDTO = new AddMemberDTO()
                {
                    First_Name = member1.First_Name,
                    Last_Name = member1.Last_Name,
                    Email = member1.Email,
                    Phone = member1.Phone
                };
                await _memberService.AddMember(memberDTO);


                TempData["Success"] = "تم الإضافة بنجاح";

                return RedirectToAction("Index");

            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {

            MemberDetailsDTO memberDTO = await _memberService.GetbyId(id);

            if (memberDTO == null)
            {
                return NotFound();
            }


            EditMemberDTO memberDTO1 = new EditMemberDTO()
            {
                ID = memberDTO.ID,
                First_Name = memberDTO.First_Name,
                Last_Name = memberDTO.Last_Name,
                Email = memberDTO.Email,
                Phone = memberDTO.Phone
            };



            return View(memberDTO);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(Member member2)
        {
            if (ModelState.IsValid)
            {

                EditMemberDTO updatedLibrarian = new EditMemberDTO()
                {
                    ID = member2.ID,
                    First_Name = member2.First_Name,
                    Last_Name = member2.Last_Name,
                    Email = member2.Email,
                    Phone = member2.Phone
                };
                await _memberService.UpdateMember(member2);
                TempData["Success"] = "تم التعديل بنجاح";
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {

            var memberDTO2 = await _memberService.GetbyId(id);

            if (memberDTO2 == null)
            {
                return NotFound();
            }


            MemberDetailsDTO memberDTO1 = new MemberDetailsDTO()
            {
                ID = memberDTO2.ID,
                First_Name = memberDTO2.First_Name,
                Last_Name = memberDTO2.Last_Name,
                Email = memberDTO2.Email,
                Phone = memberDTO2.Phone
            };



            return View(memberDTO2);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteMember(int id)
        {

            if (ModelState.IsValid)
            {

                await _memberService.DeleteMember(id);
                TempData["Success"] = "تم الحذف بنجاح";
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}

