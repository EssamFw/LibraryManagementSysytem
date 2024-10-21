using DataAccessLayer.Entities;

namespace BusinessLayer.DTOs.Members
{
    public class MemberListDTO
    {
        public int ID { get; set; }

        public string First_Name { get; set; }


        public string Last_Name { get; set; }


        public string Email { get; set; }

        public string Phone { get; set; }

        public static explicit operator MemberListDTO(Member member)
        {
            return new MemberListDTO()
            {
                ID = member.ID,
                First_Name = member.First_Name,
                Last_Name = member.Last_Name,
                Email = member.Email,
                Phone = member.Phone
            };
        }
    }
}
