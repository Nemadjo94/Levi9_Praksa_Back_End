
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce.Domain.Entities
{
    /// <summary>
    /// Role entity class where we can implement any role by passing it in the constructor
    /// </summary>
    public class Role : IdentityRole
    {
        public Role() : base() 
        {

        }

        public Role(string roleName) : base(roleName)
        {

        }
    }
}
