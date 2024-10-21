﻿
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class AppUser : IdentityUser
    {
        public string FristName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
    }
}