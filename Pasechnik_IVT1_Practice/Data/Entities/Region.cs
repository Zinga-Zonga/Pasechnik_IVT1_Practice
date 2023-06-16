using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasechnik_IVT1_Practice.Data.Entities
{
    public class Region : IEntity
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public double Territory { get; set; }
        public int Population { get; set; }

        public static implicit operator Region(System.Drawing.Region v)
        {
            throw new NotImplementedException();
        }
    }
}
