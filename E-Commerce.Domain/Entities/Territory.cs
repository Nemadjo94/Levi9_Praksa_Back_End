using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce.Domain.Entities
{
    public class Territory
    {
        public Guid TerritoryId { get; set; }
        public string TerritoryDescription { get; set; }
        public string RegionId { get; set; }

        public Region Region { get; set; }
    }
}
