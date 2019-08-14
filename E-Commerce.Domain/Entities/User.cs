using E_Commerce.Domain.ValueObjects;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce.Domain.Entities
{

    public class User : IdentityUser
    {

        public User() : base() { }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsDeleted { get; set; }

        public AddAccount AddAccount { get; set; }

    }
}
