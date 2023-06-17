using Pasechnik_IVT1_Practice.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasechnik_IVT1_Practice.Services
{
    internal class SportsEquipmentService
    {
        //Create
        public void Add(SportsEquipment sportsEquipment)
        {
            if (sportsEquipment != null)
            {
                using (Data.ApplicationContext db = new Data.ApplicationContext())
                {
                    db.Sports_Equipments.Add(sportsEquipment);
                    db.SaveChanges();
                }
            }

        }
        //Read
        public List<SportsEquipment> GetList()
        {
            List<SportsEquipment> sportsEquipments = new List<SportsEquipment>();
            using (Data.ApplicationContext db = new Data.ApplicationContext())
            {
                sportsEquipments = db.Sports_Equipments.ToList();
                db.SaveChanges();
            }
            return sportsEquipments;
        }
        public SportsEquipment GetById(int id)
        {
            SportsEquipment sportsEquipment = new SportsEquipment();
            using (Data.ApplicationContext db = new Data.ApplicationContext())
            {
                sportsEquipment = (SportsEquipment)db.Sports_Equipments.Where(f => f.Id == id).First();
            }
            return sportsEquipment;
        }
        //Delate
        public void Delate(SportsEquipment sportsEquipment)
        {
            using (Data.ApplicationContext db = new Data.ApplicationContext())
            {
                db.Sports_Equipments.Remove(sportsEquipment);
                db.SaveChanges();
            }
        }
        public void DelateRange(SportsEquipment[] sportsEquipments)
        {
            using (Data.ApplicationContext db = new Data.ApplicationContext())
            {
                foreach (SportsEquipment sportsEquipment in sportsEquipments)
                {
                    db.Sports_Equipments.Remove(sportsEquipment);

                }
                db.SaveChanges();

            }
        }
        //Update
        public void Update(SportsEquipment sportsEquipment)
        {
            using (Data.ApplicationContext db = new Data.ApplicationContext())
            {
                db.Sports_Equipments.Update(sportsEquipment);
                db.SaveChanges();
            }
        }
    }
}
