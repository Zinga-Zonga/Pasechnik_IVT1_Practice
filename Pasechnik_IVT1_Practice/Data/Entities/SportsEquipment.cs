using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasechnik_IVT1_Practice.Data.Entities
{
    public class SportsEquipment : IEntity
    {
        public int? Id { get; set; }
        public int SportTypeId { get; set; }
        public SportType SportType {get; set;}
        public string Title { get; set; }
        public float Price { get; set; }
    }
}
