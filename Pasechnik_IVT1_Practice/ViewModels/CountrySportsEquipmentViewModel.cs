using Pasechnik_IVT1_Practice.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasechnik_IVT1_Practice.ViewModels
{
    internal class CountrySportsEquipmentViewModel
    {
        public int? Id { get; set; }
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public int SportsEquipmentId { get; set; }
        public string SportsEquipmentName { get; set; }
        public int Amount { get; set; }
    }
}
