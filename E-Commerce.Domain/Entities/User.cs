using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce.Domain.Entities
{
    public class User : ValueObject
    {
        public int Id { get; set; }

        public AddAccount AddAccount { get; set; }
    }
}
