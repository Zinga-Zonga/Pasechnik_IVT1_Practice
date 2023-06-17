using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasechnik_IVT1_Practice.Data.Entities
{
    public class CountryMat : IEntity
    {
        public int? Id { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public int MatId { get; set; }
        public Mat Mat { get; set; }
        public int Amount { get; set; }
    }
}
