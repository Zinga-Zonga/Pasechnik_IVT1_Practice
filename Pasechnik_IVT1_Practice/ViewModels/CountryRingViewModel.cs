using Pasechnik_IVT1_Practice.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasechnik_IVT1_Practice.ViewModels
{
    internal class CountryRingViewModel
    {
        public int? Id { get; set; }
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public int RingId { get; set; }
        public string RingName { get; set; }
        public int Amount { get; set; }
    }
}
