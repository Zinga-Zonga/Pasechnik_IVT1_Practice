using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasechnik_IVT1_Practice.ViewModels
{
    internal class CountryViewModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int? Population { get; set; }
        public int RegionId { get; set; }
        public string RegionName { get; set; }
    }
}
