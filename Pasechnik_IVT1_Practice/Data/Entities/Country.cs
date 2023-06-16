using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasechnik_IVT1_Practice.Data.Entities
{
    public class Country : IEntity
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string? Population { get; set; }
        public int RegionId { get; set; }
        public Region Region { get; set; }
    }
}
