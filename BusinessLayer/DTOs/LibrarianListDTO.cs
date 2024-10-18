﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.entities;

namespace BusinessLayer.DTOs
{
    public class LibrarianListDTO
    {
 
        public int ID { get; set; }

        public string First_Name { get; set; }


        public string Last_Name { get; set; }


        public string Email { get; set; }

        public string Phone { get; set; }

        public static explicit operator LibrarianListDTO(Librarian librarian)
        {
            return new LibrarianListDTO()
            {
                ID = librarian.ID,
                First_Name = librarian.First_Name,
                Last_Name = librarian.Last_Name,
                Email = librarian.Email,
                Phone = librarian.Phone
            };
        }

    }
}