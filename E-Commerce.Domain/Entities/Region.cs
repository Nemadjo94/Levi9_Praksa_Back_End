using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce.Domain.Entities
{
    public class Region
    {
        public Region()
        {
            Territories = new HashSet<Territory>();
        }

        public int RegionId { get; set; }
        public string RegionDescription { get; set; }

        public ICollection<Territory> Territories { get; private set; }
    }
}
