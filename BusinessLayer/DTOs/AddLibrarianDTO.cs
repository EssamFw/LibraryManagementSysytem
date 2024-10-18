using DataAccessLayer.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTOs
{
    public class AddLibrarianDTO
    {
        public int ID { get; set; }

        public string First_Name { get; set; }


        public string Last_Name { get; set; }


        public string Email { get; set; }

        public string Phone { get; set; }

        public Librarian ToLibrarian() 
        {
            return new Librarian()
            {
                //ID = ID,
                First_Name = First_Name,
                Last_Name = Last_Name,  
                Email = Email,
                Phone = Phone

            };
        }
    }
}
