using DataAccessLayer.Entities;

namespace BusinessLayer.DTOs.Members
{
    public class AddMemberDTO
    {
        public int ID { get; set; }

        public string First_Name { get; set; }


        public string Last_Name { get; set; }


        public string Email { get; set; }

        public string Phone { get; set; }

        public Member ToMember()
        {
            return new Member()
            {
               
                First_Name = First_Name,
                Last_Name = Last_Name,
                Email = Email,
                Phone = Phone

            };
        }
    }
}
