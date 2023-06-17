using Pasechnik_IVT1_Practice.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasechnik_IVT1_Practice.ViewModels
{
    internal class SportsEquipmentViewModel
    {
        public int? Id { get; set; }
        public int SportTypeId { get; set; }
        public string SportTypeName { get; set; }
        public string Title { get; set; }
        public float Price { get; set; }
    }
}
