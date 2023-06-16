using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasechnik_IVT1_Practice.Data.Entities
{
    public class SportType : IEntity
    {
        public int? Id { get; set; }
        public string Title { get; set; }
    }
}
