using Pasechnik_IVT1_Practice.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasechnik_IVT1_Practice.Services
{
    internal class CountrySportsEquipmentService
    {
        //Create
        public void Add(CountrySportsEquipment countrySportsEquipment)
        {
            if (countrySportsEquipment != null)
            {
                using (Data.ApplicationContext db = new Data.ApplicationContext())
                {
                    db.Country_Sports_Equipments.Add(countrySportsEquipment);
                    db.SaveChanges();
                }
            }

        }
        //Read
        public List<CountrySportsEquipment> GetList()
        {
            List<CountrySportsEquipment> countrySportsEquipments = new List<CountrySportsEquipment>();
            using (Data.ApplicationContext db = new Data.ApplicationContext())
            {
                countrySportsEquipments = db.Country_Sports_Equipments.ToList();
                db.SaveChanges();
            }
            return countrySportsEquipments;
        }
        //Delate
        public void Delate(CountrySportsEquipment countrySportsEquipment)
        {
            using (Data.ApplicationContext db = new Data.ApplicationContext())
            {
                db.Country_Sports_Equipments.Remove(countrySportsEquipment);
                db.SaveChanges();
            }
        }
        public void DelateRange(CountrySportsEquipment[] countrySportsEquipments)
        {
            using (Data.ApplicationContext db = new Data.ApplicationContext())
            {
                foreach (CountrySportsEquipment countrySportsEquipment in countrySportsEquipments)
                {
                    db.Country_Sports_Equipments.Remove(countrySportsEquipment);

                }
                db.SaveChanges();

            }
        }
        //Update
        public void Update(CountrySportsEquipment countrySportsEquipment)
        {
            using (Data.ApplicationContext db = new Data.ApplicationContext())
            {
                db.Country_Sports_Equipments.Update(countrySportsEquipment);
                db.SaveChanges();
            }
        }
    }
}
