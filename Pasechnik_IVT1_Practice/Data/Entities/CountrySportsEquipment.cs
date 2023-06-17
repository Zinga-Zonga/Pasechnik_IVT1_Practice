using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasechnik_IVT1_Practice.Data.Entities
{
    public class CountrySportsEquipment : IEntity
    {
        public int? Id { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public int SportsEquipmentId { get; set; }
        public SportsEquipment SportsEquipment { get; set; }
        public int Amount { get; set; }
    }
}
